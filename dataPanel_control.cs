
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class dataPanel_control : UserControl
    {
        public dataPanel_control()
        {
            InitializeComponent();
        }

        public void setName(string name) {
            textBox_name.Text = name;
        }

        public void setPassword(string pass) {
            textBox_password.Text = pass;
        }

        private void btn_delete_Click(object sender, System.EventArgs e)
        {
            MainWindow.credentialsDictionary.Remove(textBox_name.Text);

            ViewPasswords_Form x = (ViewPasswords_Form) FindForm();
            x.ShowData();
            
        }

        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(textBox_password.Text);
        }

        private void btn_visibility_Click(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;

            if (button.BackColor == System.Drawing.Color.Transparent)
            {
                button.BackColor = System.Drawing.Color.WhiteSmoke;
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                button.BackColor = System.Drawing.Color.Transparent;
                textBox_password.UseSystemPasswordChar = true;
            }

        }
    }
}
