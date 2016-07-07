using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CiscoScan
{
    public partial class Form2 : Form
    {
        private string firstIp;
        private string lastIp;
        private string userName;
        private string password;
        private string[] ipPull;
        private List<string> cIpPull;
        private string outDevice;
        private string command;
        private string currentCommand;
        private string currentIp;
        TextBox usTx;
        TextBox psTx;

        private Form form3;

        public Form2(string _fIp, string _lIp, string _uName, string _pass)
        {
            InitializeComponent();
            firstIp = _fIp;
            lastIp = _lIp;
            userName = _uName;
            password = _pass;
            int _firstIp = Int32.Parse(firstIp.Split(new char[] { '.' }, 4)[3]);
            int _secondIp = Int32.Parse(lastIp.Split(new char[] { '.' }, 4)[3]);
            ipPull = new string[_secondIp - _firstIp + 1];
            for (int i = 0; i < _secondIp - _firstIp + 1; ++i)
            {
                for (int j = 0; j < 3; ++j)
                    ipPull[i] += firstIp.Split(new char[] { '.' }, 4)[j] + ".";
                ipPull[i] += (_firstIp + i).ToString();
            }
            cIpPull = new List<string>();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (commandInput.Text != "" && e.KeyCode == Keys.Enter)
            {
                command = commandInput.Text;
                bool isCommand = false;
                for (int i = 0; i < commandInput.Items.Count; i++)
                {
                    if (commandInput.Text.Equals(commandInput.GetItemText(commandInput.Items[i])))
                        isCommand = true;
                }
                if (!isCommand)
                    commandInput.Items.Add(commandInput.Text);
                outText.Clear();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            outText.Text += outDevice;
            bool isCommand = false;
            foreach (var i in cIpPull)
            {
                for (int j = 0; j < currentIpPull.Items.Count; j++)
                {
                    if (i.Equals(currentIpPull.GetItemText(currentIpPull.Items[j])))
                        isCommand = true;
                }
                if (!isCommand)
                    currentIpPull.Items.Add(i);
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (e.ProgressPercentage < 100)
                statusLabel.Text = "Scaning";
            else if (e.ProgressPercentage == 100)
                statusLabel.Text = "Success";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            outDevice = "";
            for (var i = 0; i < ipPull.Length; i++) 
            {
                currentIp = ipPull[i];
                backgroundWorker1.ReportProgress(i * 100 / ipPull.Length);
                currentCommand = ipPull[i] + Environment.NewLine;
                currentCommand += ScanDevice.TelnetScan(userName, password, ipPull[i], command) + "  " + ipPull[i].ToString() + Environment.NewLine;
                if (currentCommand.Contains("Authentication failed"))
                {
                    createDialog();
                    if (form3.DialogResult == DialogResult.OK)
                    {
                        userName = usTx.Text;
                        password = psTx.Text;
                        form3.Dispose();
                        --i;
                        continue; 
                    }
                }
                outDevice += currentCommand;
                addComboBox();
            }
            backgroundWorker1.ReportProgress(100);
        }
        private void addComboBox()
        {
            if (!currentCommand.Contains("I can't connect to device") && ! currentCommand.Contains("Ambiguous command"))
            {
                cIpPull.Add(currentIp);
                ScanDevice.WriteToFile(currentCommand, command, currentIp);
            }
        }
        private void createDialog()
        {
            form3 = new Form();
            Button button1 = new Button();

            usTx = new TextBox();
            psTx = new TextBox();
            usTx.Text = "UserName";
            psTx.Text = "Password";
            psTx.PasswordChar = '*';
            usTx.Location = new Point(20, 50);
            psTx.Location = new Point(150, 50);

            button1.Text = "OK";
            button1.Location = new Point( 100, 230);
            button1.DialogResult = DialogResult.OK;
            form3.Text = "Authentication";

            form3.FormBorderStyle = FormBorderStyle.FixedDialog;
            form3.AcceptButton = button1;
            form3.StartPosition = FormStartPosition.CenterScreen;

            form3.Controls.Add(button1);
            form3.Controls.Add(usTx);
            form3.Controls.Add(psTx);

            form3.ShowDialog();
        }

        private void commandInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            outText.Clear();
            String[] tempStr = ScanDevice.ReadFromFile(commandInput.Text, currentIpPull.Text);
            if (tempStr == null)
            {
                outText.Text = "Can't open this file";
                return;
            }
           
            foreach (var i in tempStr)
            {
                outText.AppendText(Environment.NewLine);
                outText.Text += i;
            }
        }

        private void currentIpPull_SelectedIndexChanged(object sender, EventArgs e)
        {
            outText.Clear();
            String[] tempStr = ScanDevice.ReadFromFile(commandInput.Text, currentIpPull.Text);
            if (tempStr == null)
            {
                outText.Text = "Can't open this file";
                return;
            }

            foreach (var i in tempStr)
            {
                outText.AppendText(Environment.NewLine);
                outText.Text += i;
            }
        }

        private void findInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool isCompareTrue = false;
                outText.Clear();
                String[] ar;
                string[] tmp = new string[3];
                for (int i = 0; i < commandInput.Items.Count; i++)
                {
                    for (int j = 0; j < currentIpPull.Items.Count; j++)
                    {
                        ar = ScanDevice.ReadFromFile(commandInput.GetItemText(commandInput.Items[i]), currentIpPull.GetItemText(currentIpPull.Items[j]));
                        for (int k = 0; k < ar.Length; k++) 
                        {
                            String[] tempArr = ar[k].Split(' ');
                            for (int q = 0; q < tempArr.Length; q++)
                                if (findInput.Text == tempArr[q] && tempArr[q] != "" && tempArr[q].Length != 1)
                                {
                                    isCompareTrue = true;
                                    tmp[0] = ar[ar.Length - 1];
                                    tmp[1] = ar[k - 1];
                                    tmp[2] = ar[k];
                                }
                        }
                        if (isCompareTrue)
                        {
                            foreach (var k in tmp)
                                outText.Text += k + Environment.NewLine;
                        }
                        isCompareTrue = false;
                    }
                }
            }
        }
    }
}
