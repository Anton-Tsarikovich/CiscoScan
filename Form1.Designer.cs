namespace CiscoScan
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstIpInput = new System.Windows.Forms.TextBox();
            this.lastIpInput = new System.Windows.Forms.TextBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.logOkButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstIpInput
            // 
            this.firstIpInput.Location = new System.Drawing.Point(13, 23);
            this.firstIpInput.Name = "firstIpInput";
            this.firstIpInput.Size = new System.Drawing.Size(100, 20);
            this.firstIpInput.TabIndex = 0;
            // 
            // lastIpInput
            // 
            this.lastIpInput.Location = new System.Drawing.Point(167, 23);
            this.lastIpInput.Name = "lastIpInput";
            this.lastIpInput.Size = new System.Drawing.Size(100, 20);
            this.lastIpInput.TabIndex = 1;
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(13, 82);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(100, 20);
            this.userNameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(167, 82);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(100, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // logOkButton
            // 
            this.logOkButton.Location = new System.Drawing.Point(13, 129);
            this.logOkButton.Name = "logOkButton";
            this.logOkButton.Size = new System.Drawing.Size(75, 23);
            this.logOkButton.TabIndex = 4;
            this.logOkButton.Text = "OK";
            this.logOkButton.UseVisualStyleBackColor = true;
            this.logOkButton.Click += new System.EventHandler(this.logOkButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(192, 129);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Ip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logOkButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.lastIpInput);
            this.Controls.Add(this.firstIpInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstIpInput;
        private System.Windows.Forms.TextBox lastIpInput;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button logOkButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;



    }
}

