using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class AddPassword_Form : Form
    {
        public AddPassword_Form()
        {
            InitializeComponent();
        }

        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            if (!MainWindow.credentialsDictionary.ContainsKey(textBox_name.Text)) {
                MainWindow.credentialsDictionary.Add(textBox_name.Text, textBox_password.Text);
                textBox_name.Text = "";
                textBox_password.Text = "";
            }
            else MessageBox.Show("Name already in use", "");

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if(textBox_password.TextLength > 0 && textBox_name.TextLength > 0)
                btnAddPassword.Enabled = true;
            else btnAddPassword.Enabled = false;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (textBox_password.TextLength > 0 && textBox_name.TextLength > 0)
                btnAddPassword.Enabled = true;
            else btnAddPassword.Enabled = false;
        }


    }
}
