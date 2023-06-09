﻿namespace mschreiber_Software2_c969Project
{
    partial class LoginForm
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
            this.lbl_LoginHeader = new System.Windows.Forms.Label();
            this.lbl_InvalidCredentials = new System.Windows.Forms.Label();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.txt_LoginPass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_CancelLogin = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_LoginHeader
            // 
            this.lbl_LoginHeader.AutoSize = true;
            this.lbl_LoginHeader.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginHeader.Location = new System.Drawing.Point(290, 11);
            this.lbl_LoginHeader.Name = "lbl_LoginHeader";
            this.lbl_LoginHeader.Size = new System.Drawing.Size(254, 50);
            this.lbl_LoginHeader.TabIndex = 0;
            this.lbl_LoginHeader.Text = "Welcome!";
            // 
            // lbl_InvalidCredentials
            // 
            this.lbl_InvalidCredentials.AutoSize = true;
            this.lbl_InvalidCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_InvalidCredentials.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.lbl_InvalidCredentials.Location = new System.Drawing.Point(210, 283);
            this.lbl_InvalidCredentials.Name = "lbl_InvalidCredentials";
            this.lbl_InvalidCredentials.Size = new System.Drawing.Size(101, 24);
            this.lbl_InvalidCredentials.TabIndex = 1;
            this.lbl_InvalidCredentials.Text = "-------";
            this.lbl_InvalidCredentials.Visible = false;
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(214, 115);
            this.txt_LoginName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(566, 26);
            this.txt_LoginName.TabIndex = 2;
            // 
            // txt_LoginPass
            // 
            this.txt_LoginPass.Location = new System.Drawing.Point(214, 227);
            this.txt_LoginPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LoginPass.Name = "txt_LoginPass";
            this.txt_LoginPass.Size = new System.Drawing.Size(566, 26);
            this.txt_LoginPass.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Login.Location = new System.Drawing.Point(178, 335);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(194, 60);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.LoginClick);
            // 
            // btn_CancelLogin
            // 
            this.btn_CancelLogin.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_CancelLogin.Location = new System.Drawing.Point(417, 335);
            this.btn_CancelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CancelLogin.Name = "btn_CancelLogin";
            this.btn_CancelLogin.Size = new System.Drawing.Size(194, 60);
            this.btn_CancelLogin.TabIndex = 5;
            this.btn_CancelLogin.Text = "Cancel";
            this.btn_CancelLogin.UseVisualStyleBackColor = true;
            this.btn_CancelLogin.Click += new System.EventHandler(this.btn_CancelLogin_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_UserName.Location = new System.Drawing.Point(12, 113);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(138, 25);
            this.lbl_UserName.TabIndex = 6;
            this.lbl_UserName.Text = "User Name";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Password.Location = new System.Drawing.Point(12, 225);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(124, 25);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(814, 419);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_CancelLogin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_LoginPass);
            this.Controls.Add(this.txt_LoginName);
            this.Controls.Add(this.lbl_InvalidCredentials);
            this.Controls.Add(this.lbl_LoginHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LoginHeader;
        private System.Windows.Forms.Label lbl_InvalidCredentials;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.TextBox txt_LoginPass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_CancelLogin;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
    }
}

