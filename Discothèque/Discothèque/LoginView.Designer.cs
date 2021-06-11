
using System;
using System.Windows.Forms;

namespace Discotèque
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.connectionLabel = new System.Windows.Forms.Label();
            this.connectionBackground = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.TextBox();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.CreateAccountLabel = new System.Windows.Forms.LinkLabel();
            this.connectionButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.connectionBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLabel.ForeColor = System.Drawing.Color.White;
            this.connectionLabel.Location = new System.Drawing.Point(127, 7);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(171, 45);
            this.connectionLabel.TabIndex = 0;
            this.connectionLabel.Text = "Connexion";
            // 
            // connectionBackground
            // 
            this.connectionBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.connectionBackground.Controls.Add(this.ErrorLabel);
            this.connectionBackground.Controls.Add(this.LoginLabel);
            this.connectionBackground.Controls.Add(this.PasswordLabel);
            this.connectionBackground.Controls.Add(this.labelPasswordLogin);
            this.connectionBackground.Controls.Add(this.labelUserLogin);
            this.connectionBackground.Controls.Add(this.CreateAccountLabel);
            this.connectionBackground.Controls.Add(this.connectionButton);
            this.connectionBackground.Controls.Add(this.connectionLabel);
            this.connectionBackground.Location = new System.Drawing.Point(192, 51);
            this.connectionBackground.Name = "connectionBackground";
            this.connectionBackground.Size = new System.Drawing.Size(426, 359);
            this.connectionBackground.TabIndex = 2;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Location = new System.Drawing.Point(0, 284);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(426, 23);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "Mot de passe incorrect";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(116, 102);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(192, 30);
            this.LoginLabel.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(117, 175);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(191, 30);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.UseSystemPasswordChar = true;
            this.PasswordLabel.KeyDown += PasswordLabel_KeyDown;
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordLogin.Location = new System.Drawing.Point(148, 146);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(128, 26);
            this.labelPasswordLogin.TabIndex = 4;
            this.labelPasswordLogin.Text = "Mot de passe";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLogin.Location = new System.Drawing.Point(158, 73);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(107, 26);
            this.labelUserLogin.TabIndex = 3;
            this.labelUserLogin.Text = "Identifiant";
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLabel.LinkColor = System.Drawing.Color.Navy;
            this.CreateAccountLabel.Location = new System.Drawing.Point(101, 319);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(223, 21);
            this.CreateAccountLabel.TabIndex = 2;
            this.CreateAccountLabel.TabStop = true;
            this.CreateAccountLabel.Text = "Vous n\'avez pas de compte ?";
            this.CreateAccountLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.CreateAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountLabel_LinkClicked);
            // 
            // connectionButton
            // 
            this.connectionButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionButton.ForeColor = System.Drawing.Color.Black;
            this.connectionButton.Location = new System.Drawing.Point(116, 228);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(192, 40);
            this.connectionButton.TabIndex = 1;
            this.connectionButton.Text = "Connexion";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 105);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectionBackground);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginView";
            this.Text = "Form2";
            this.connectionBackground.ResumeLayout(false);
            this.connectionBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

  



        #endregion

        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Panel connectionBackground;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox LoginLabel;
        private System.Windows.Forms.TextBox PasswordLabel;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.LinkLabel CreateAccountLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.PictureBox logo;
    }
}