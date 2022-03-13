using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager.code
{
    public partial class KeySettings_Form : Form
    {
        public KeySettings_Form()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (textBox_key.TextLength < 8) {

                MessageBox.Show("" +
                    "Master password needs to be at least 8 characters long",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            if (!MainWindow.credentialsDictionary.ContainsKey("Masterkey")){
                MainWindow.credentialsDictionary.Add("Masterkey", textBox_key.Text);
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                btnSubmit.Visible = false;
                textBox_key.Enabled = false;
                btn_visibility.Visible = true;
            }
            else if (textBox_key.Text == MainWindow.credentialsDictionary["Masterkey"])
            {
                // correct key
                    btnDelete.Visible = true;
                    btnEdit.Visible = true;
                    btnSubmit.Visible = false;
                    textBox_key.Enabled = false;

                    label_tick.Visible = true;
                    label_tick.Text = "✓";
                    label_tick.ForeColor = Color.Green;

                btn_visibility.Visible = true;
                }
            else {
                    label_tick.Visible = true;
                    label_tick.Text = "x";
                    label_tick.ForeColor = Color.Red;
                }

            }
        

        private void textBox_key_TextChanged(object sender, EventArgs e)
        {
            if (textBox_key.TextLength > 0)
            {
                btnSubmit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEditCancel.Visible = true;
            btnEditOK.Visible = true;
            textBox_edit.Visible = true;
            textBox_edit.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("" +
                    "Are you sure you want to delete master key?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (q == DialogResult.Yes) {
                MainWindow.credentialsDictionary.Remove("Masterkey");

                MainWindow.privateKey = "x+HXf92M";
                Close();
            }

        }

        private void btnEditOK_Click(object sender, EventArgs e)
        {

            if (textBox_edit.TextLength < 8) {
                MessageBox.Show("" +
                    "Master passwords needs to be at least 8 characters long",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox_edit.Text = "";
                return;
            }
            MainWindow.credentialsDictionary["Masterkey"] = textBox_edit.Text;
            btnEditCancel.Visible = false;
            btnEditOK.Visible = false;
            textBox_edit.Visible = false;
            textBox_key.Text = textBox_edit.Text;
            textBox_edit.Text = "";
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            btnEditCancel.Visible = false;
            btnEditOK.Visible = false;
            textBox_edit.Visible = false;
            textBox_edit.Text = "";
        }

        private void textBox_edit_TextChanged(object sender, EventArgs e)
        {
            if (textBox_edit.TextLength > 0) { btnEditOK.Enabled = true; }
        }

        private void btn_visibility_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.BackColor == Color.Transparent)
            {
                button.BackColor = Color.WhiteSmoke;
                textBox_key.UseSystemPasswordChar = false;
            }
            else
            {
                button.BackColor = Color.Transparent;
                textBox_key.UseSystemPasswordChar = true;
            }
        }
    }
}
