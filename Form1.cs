using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiscoScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOkButton_Click(object sender, EventArgs e)
        {
            if (firstIpInput.Text == "" || lastIpInput.Text == "" || userNameInput.Text == "" || passwordInput.Text == "")
            {
                MessageBox.Show("Input all fields");
            }
            else
            {
                Form2 f2 = new Form2(firstIpInput.Text, lastIpInput.Text, userNameInput.Text, passwordInput.Text);
                f2.Show();
                this.Hide();
            }
        }

    }
}
