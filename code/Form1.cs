using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections.Generic;
using PasswordManager.graphics;
using System.IO;
using System.Linq;
using PasswordManager.code;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManager
{
    public partial class MainWindow : Form
    {

        public static Dictionary<string,string> credentialsDictionary = new Dictionary<string,string>();


        private int[] colorGreen = new int[] { 8, 163, 26 };
        private int[] colorBlue = new int[] { 0, 126, 250 };

        private List<Button> buttons = new List<Button>();
        private string publicKey = "rxIdwETS";
        public static string privateKey = "x+HXf92M";


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            TopPanel.MouseDown += Form1_MouseDown;
            LeftPanel.MouseDown += Form1_MouseDown;
            pictureBox1.MouseDown += Form1_MouseDown;


            LoadData();


            if (credentialsDictionary.ContainsKey("Masterkey"))
            {
                btnAddPassword.Enabled = false;
                btnGeneratePassword.Enabled = false;
                btnViewPasswords.Enabled = false;
                btnKey.Enabled = false;
                label_enterKey.Visible = true;
                textBox_key.Visible = true;
                btnSubmitKey.Visible = true;
            }
            else {
                credentialsDictionary = credentialsDictionary.ToDictionary(k => k.Key, v => Decrypt(v.Value, privateKey));

            }

            Focus();

        }


        private void btnViewPasswords_Click(object sender, EventArgs e)
        {
            ResetButtonsColour();
            Button button = sender as Button;
            button.ForeColor = Color.FromArgb(colorGreen[0], colorGreen[1], colorGreen[2]);

           
            if (!buttons.Contains(button))
            {
                buttons.Add(button);
            }

            loadForm(new ViewPasswords_Form());
        }

        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            ResetButtonsColour();
            Button button = sender as Button;
            button.ForeColor = Color.FromArgb(colorGreen[0], colorGreen[1], colorGreen[2]);

            if (!buttons.Contains(button)) { 
                buttons.Add(button);
            }

            loadForm(new AddPassword_Form());
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            ResetButtonsColour();
            Button button = sender as Button;
            button.ForeColor = Color.FromArgb(colorGreen[0], colorGreen[1], colorGreen[2]);
            if (!buttons.Contains(button))
            {
                buttons.Add(button);
            }

            loadForm(new GeneratePassword_Form());

        }


        private void ResetButtonsColour() {
            foreach (Button b in buttons)
            {
                b.ForeColor = Color.FromArgb(colorBlue[0], colorBlue[1], colorBlue[2]);
            }
        }


        public void loadForm(Form form) {
            if (childPanel.Controls.Count > 0) {
                childPanel.Controls.RemoveAt(0);
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.FromArgb(46, 60, 75);
            childPanel.Controls.Add(form);
            childPanel.Tag = form;
            form.Show();
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }


        public void SaveData() {

            
            byte[] secretkeyByte = { };
            if (UsesMasterPassword()) privateKey = GetMasterPassword();
            secretkeyByte = Encoding.UTF8.GetBytes(privateKey);
            byte[] publickeybyte = { };
            publickeybyte = Encoding.UTF8.GetBytes(publicKey);
            MemoryStream ms = null;
            CryptoStream cs = null;

            var encryptedPasswordsDict = new Dictionary<string, string>();

            foreach (var i in credentialsDictionary) {

                byte[] inputbyteArray = Encoding.UTF8.GetBytes(i.Value);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {

                    
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    encryptedPasswordsDict.Add(i.Key, Convert.ToBase64String(ms.ToArray()));
                }
            }


            File.WriteAllLines(
                Directory.GetCurrentDirectory() + "\\SavedPasswords",
                encryptedPasswordsDict.Select(kvp => string.Format("{0};{1}", kvp.Key, kvp.Value)));
        }

        public void LoadData() {

            try
            {
                credentialsDictionary.Clear();
                using (var reader = new StreamReader(Directory.GetCurrentDirectory() + "\\SavedPasswords"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line == null) continue;
                        var v = line.Split(';');
                        credentialsDictionary.Add(v[0], v[1]);
                    }
                }

            }
            catch (FileNotFoundException) { }
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            ResetButtonsColour();
            if (!credentialsDictionary.ContainsKey("Masterkey"))
            {
                DialogResult q = MessageBox.Show("" +
                    "Do you want to use master password on startup?\n" +
                    "Losing master key will result in being unable to use program",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


                if (q == DialogResult.Yes){loadForm(new KeySettings_Form());}

            }
            else { loadForm(new KeySettings_Form()); }
        }


        public bool UsesMasterPassword() {
            return credentialsDictionary.ContainsKey("Masterkey");
        }

        public string GetMasterPassword() {
            try
            {
                return credentialsDictionary["Masterkey"];
            }
            catch (Exception) {
                return null;
            }
            
        }

        private void btnSubmitKey_Click(object sender, EventArgs e)
        {
            


            // if correct key has been put

            var key = Decrypt(GetMasterPassword(), textBox_key.Text);

            if (key != null && textBox_key.Text == key)
            {


                // then decrypt rest of data

                credentialsDictionary = credentialsDictionary.ToDictionary(k => k.Key, v => Decrypt(v.Value, key));


                privateKey = textBox_key.Text;

                btnAddPassword.Enabled = true;
                btnGeneratePassword.Enabled = true;
                btnViewPasswords.Enabled = true;
                btnKey.Enabled = true;

                textBox_key.Text = "";
                label_enterKey.Visible = false;
                textBox_key.Visible = false;
                btnSubmitKey.Visible = false;

            }
            else {

                MessageBox.Show("" +
                    "Invalid password",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBox_key.Text = "";
            }
        }

        private string Decrypt(string text, string key) {

            string result = null;


            try
            {
                byte[] privateKeyByte = Encoding.UTF8.GetBytes(key);
                byte[] publicKeyByte = Encoding.UTF8.GetBytes(publicKey);
                byte[] inputbyteArray = new byte[text.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(text.Replace(" ", "+"));

                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    MemoryStream ms = new MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(publicKeyByte, privateKeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    result = encoding.GetString(ms.ToArray());
                }


            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }

    }

}
