
using System;

namespace Discotèque
{
    partial class CreateAccountView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountView));
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.InscriptionLabel = new System.Windows.Forms.Label();
            this.connectionBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.LastNameLabel = new System.Windows.Forms.TextBox();
            this.familyNameLabelTitle = new System.Windows.Forms.Label();
            this.FistNameLabel = new System.Windows.Forms.TextBox();
            this.nameLabelTitle = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.TextBox();
            this.labelPasswordTitle = new System.Windows.Forms.Label();
            this.labelUsernameTitle = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.connectionBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(105, 105);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // InscriptionLabel
            // 
            this.InscriptionLabel.AutoSize = true;
            this.InscriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscriptionLabel.ForeColor = System.Drawing.Color.White;
            this.InscriptionLabel.Location = new System.Drawing.Point(156, 14);
            this.InscriptionLabel.Name = "InscriptionLabel";
            this.InscriptionLabel.Size = new System.Drawing.Size(185, 45);
            this.InscriptionLabel.TabIndex = 0;
            this.InscriptionLabel.Text = "Inscription";
            // 
            // connectionBackground
            // 
            this.connectionBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.connectionBackground.Controls.Add(this.label1);
            this.connectionBackground.Controls.Add(this.CountryComboBox);
            this.connectionBackground.Controls.Add(this.LastNameLabel);
            this.connectionBackground.Controls.Add(this.familyNameLabelTitle);
            this.connectionBackground.Controls.Add(this.FistNameLabel);
            this.connectionBackground.Controls.Add(this.nameLabelTitle);
            this.connectionBackground.Controls.Add(this.ErrorLabel);
            this.connectionBackground.Controls.Add(this.LoginLabel);
            this.connectionBackground.Controls.Add(this.PasswordLabel);
            this.connectionBackground.Controls.Add(this.labelPasswordTitle);
            this.connectionBackground.Controls.Add(this.labelUsernameTitle);
            this.connectionBackground.Controls.Add(this.SignUpButton);
            this.connectionBackground.Controls.Add(this.InscriptionLabel);
            this.connectionBackground.Location = new System.Drawing.Point(150, 46);
            this.connectionBackground.Name = "connectionBackground";
            this.connectionBackground.Size = new System.Drawing.Size(475, 475);
            this.connectionBackground.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pays";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.ItemHeight = 13;
            this.CountryComboBox.Location = new System.Drawing.Point(149, 296);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(192, 21);
            this.CountryComboBox.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(257, 128);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(192, 30);
            this.LastNameLabel.TabIndex = 11;
            // 
            // familyNameLabelTitle
            // 
            this.familyNameLabelTitle.AutoSize = true;
            this.familyNameLabelTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyNameLabelTitle.Location = new System.Drawing.Point(324, 99);
            this.familyNameLabelTitle.Name = "familyNameLabelTitle";
            this.familyNameLabelTitle.Size = new System.Drawing.Size(52, 26);
            this.familyNameLabelTitle.TabIndex = 10;
            this.familyNameLabelTitle.Text = "Nom";
            // 
            // FistNameLabel
            // 
            this.FistNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FistNameLabel.Location = new System.Drawing.Point(46, 128);
            this.FistNameLabel.Name = "FistNameLabel";
            this.FistNameLabel.Size = new System.Drawing.Size(192, 30);
            this.FistNameLabel.TabIndex = 9;
            // 
            // nameLabelTitle
            // 
            this.nameLabelTitle.AutoSize = true;
            this.nameLabelTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelTitle.Location = new System.Drawing.Point(104, 100);
            this.nameLabelTitle.Name = "nameLabelTitle";
            this.nameLabelTitle.Size = new System.Drawing.Size(76, 26);
            this.nameLabelTitle.TabIndex = 8;
            this.nameLabelTitle.Text = "Prénom";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Location = new System.Drawing.Point(0, 361);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(475, 23);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "Identifiant non disponible";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(46, 208);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(192, 30);
            this.LoginLabel.TabIndex = 6;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(257, 208);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(191, 30);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.UseSystemPasswordChar = true;
            // 
            // labelPasswordTitle
            // 
            this.labelPasswordTitle.AutoSize = true;
            this.labelPasswordTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordTitle.Location = new System.Drawing.Point(287, 180);
            this.labelPasswordTitle.Name = "labelPasswordTitle";
            this.labelPasswordTitle.Size = new System.Drawing.Size(128, 26);
            this.labelPasswordTitle.TabIndex = 4;
            this.labelPasswordTitle.Text = "Mot de passe";
            // 
            // labelUsernameTitle
            // 
            this.labelUsernameTitle.AutoSize = true;
            this.labelUsernameTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameTitle.Location = new System.Drawing.Point(89, 180);
            this.labelUsernameTitle.Name = "labelUsernameTitle";
            this.labelUsernameTitle.Size = new System.Drawing.Size(107, 26);
            this.labelUsernameTitle.TabIndex = 3;
            this.labelUsernameTitle.Text = "Identifiant";
            // 
            // SignUpButton
            // 
            this.SignUpButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SignUpButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.Black;
            this.SignUpButton.Location = new System.Drawing.Point(149, 410);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(192, 40);
            this.SignUpButton.TabIndex = 1;
            this.SignUpButton.Text = "Inscription";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // CreateAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.connectionBackground);
            this.Controls.Add(this.PictureBoxLogo);
            this.Name = "CreateAccountView";
            this.Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.connectionBackground.ResumeLayout(false);
            this.connectionBackground.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label InscriptionLabel;
        private System.Windows.Forms.Panel connectionBackground;
        private System.Windows.Forms.TextBox FistNameLabel;
        private System.Windows.Forms.Label nameLabelTitle;
        private System.Windows.Forms.TextBox LoginLabel;
        private System.Windows.Forms.TextBox PasswordLabel;
        private System.Windows.Forms.Label labelPasswordTitle;
        private System.Windows.Forms.Label labelUsernameTitle;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox LastNameLabel;
        private System.Windows.Forms.Label familyNameLabelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Label ErrorLabel;
    }
}