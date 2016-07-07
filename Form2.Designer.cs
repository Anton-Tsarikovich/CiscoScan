namespace CiscoScan
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.commandInput = new System.Windows.Forms.ComboBox();
            this.currentIpPull = new System.Windows.Forms.ComboBox();
            this.findInput = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // commandInput
            // 
            this.commandInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commandInput.FormattingEnabled = true;
            this.commandInput.Location = new System.Drawing.Point(12, 12);
            this.commandInput.Name = "commandInput";
            this.commandInput.Size = new System.Drawing.Size(121, 21);
            this.commandInput.TabIndex = 0;
            this.commandInput.SelectedIndexChanged += new System.EventHandler(this.commandInput_SelectedIndexChanged);
            this.commandInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // currentIpPull
            // 
            this.currentIpPull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentIpPull.FormattingEnabled = true;
            this.currentIpPull.Location = new System.Drawing.Point(279, 12);
            this.currentIpPull.Name = "currentIpPull";
            this.currentIpPull.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentIpPull.Size = new System.Drawing.Size(121, 21);
            this.currentIpPull.TabIndex = 1;
            this.currentIpPull.SelectedIndexChanged += new System.EventHandler(this.currentIpPull_SelectedIndexChanged);
            // 
            // findInput
            // 
            this.findInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findInput.Location = new System.Drawing.Point(530, 12);
            this.findInput.Name = "findInput";
            this.findInput.Size = new System.Drawing.Size(100, 20);
            this.findInput.TabIndex = 2;
            this.findInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findInput_KeyDown);
            // 
            // outText
            // 
            this.outText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outText.Location = new System.Drawing.Point(12, 55);
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(618, 230);
            this.outText.TabIndex = 3;
            this.outText.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(555, 299);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(433, 299);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(29, 309);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 334);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.findInput);
            this.Controls.Add(this.currentIpPull);
            this.Controls.Add(this.commandInput);
            this.Name = "Form2";
            this.Text = "Cisco Scan";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox commandInput;
        private System.Windows.Forms.ComboBox currentIpPull;
        private System.Windows.Forms.TextBox findInput;
        private System.Windows.Forms.RichTextBox outText;
        private System.Windows.Forms.Button exitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLabel;
    }
}