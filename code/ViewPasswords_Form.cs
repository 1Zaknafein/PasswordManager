using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class ViewPasswords_Form : Form
    {
        public ViewPasswords_Form()
        {
            InitializeComponent();

            flowLayoutPanel.AutoScroll = true;

            ShowData();
        }

        public void ShowData() {
            flowLayoutPanel.Controls.Clear();

            int i = MainWindow.credentialsDictionary.Count;

            if (MainWindow.credentialsDictionary.ContainsKey("Masterkey"))
                i--;
            if (i > 1)
                textBox_currentAmount.Text = "There are " + i + " credentials currently saved";
            else if (i == 1)
                textBox_currentAmount.Text = "There is " + i + " credential currently saved";
            else
                textBox_currentAmount.Text = "There are no credentials currently saved";


            foreach (KeyValuePair<string, string> data in MainWindow.credentialsDictionary)
            {
                if (data.Key != "Masterkey") {
                    dataPanel_control x = new dataPanel_control();
                    x.setName(data.Key);
                    x.setPassword(data.Value);
                    flowLayoutPanel.Controls.Add(x);
                }

            }
        }
    }

}
