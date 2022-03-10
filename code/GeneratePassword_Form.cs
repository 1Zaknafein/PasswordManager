using System;
using System.Windows.Forms;


namespace PasswordManager.graphics
{
    public partial class GeneratePassword_Form : Form
    {
        public GeneratePassword_Form()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            int len = (int)numeric_passwordLength.Value;
            Random r = new Random();   
            textBoxPasasword.Text = System.Web.Security.Membership.GeneratePassword(len,r.Next(0,len-2) );
            btnCopy.Visible = true;

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPasasword.Text);
        }
    }
}
