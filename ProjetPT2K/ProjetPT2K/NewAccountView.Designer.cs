
using System;

namespace ProjetPT2K
{
    partial class NewAccountView
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
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.InscriptionLabel = new System.Windows.Forms.Label();
            this.connectionBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.countryboxlabel = new System.Windows.Forms.ComboBox();
            this.familyNameLabel = new System.Windows.Forms.TextBox();
            this.familyNameLabelTitle = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.TextBox();
            this.nameLabelTitle = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.TextBox();
            this.labelPasswordTitle = new System.Windows.Forms.Label();
            this.labelUsernameTitle = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.connectionBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::ProjetPT2K.Properties.Resources.App_Logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(105, 105);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            this.PictureBoxLogo.Click += new System.EventHandler(this.PictureBoxLogo_Click);
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
            this.connectionBackground.Controls.Add(this.countryboxlabel);
            this.connectionBackground.Controls.Add(this.familyNameLabel);
            this.connectionBackground.Controls.Add(this.familyNameLabelTitle);
            this.connectionBackground.Controls.Add(this.namelabel);
            this.connectionBackground.Controls.Add(this.nameLabelTitle);
            this.connectionBackground.Controls.Add(this.errorLabel);
            this.connectionBackground.Controls.Add(this.userlabel);
            this.connectionBackground.Controls.Add(this.passwordlabel);
            this.connectionBackground.Controls.Add(this.labelPasswordTitle);
            this.connectionBackground.Controls.Add(this.labelUsernameTitle);
            this.connectionBackground.Controls.Add(this.connectionButton);
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
            // countryboxlabel
            // 
            this.countryboxlabel.FormattingEnabled = true;
            this.countryboxlabel.ItemHeight = 13;
            this.countryboxlabel.Location = new System.Drawing.Point(149, 296);
            this.countryboxlabel.Name = "countryboxlabel";
            this.countryboxlabel.Size = new System.Drawing.Size(192, 21);
            this.countryboxlabel.TabIndex = 12;
            // 
            // familyNameLabel
            // 
            this.familyNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyNameLabel.Location = new System.Drawing.Point(257, 128);
            this.familyNameLabel.Name = "familyNameLabel";
            this.familyNameLabel.Size = new System.Drawing.Size(192, 30);
            this.familyNameLabel.TabIndex = 11;
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
            // namelabel
            // 
            this.namelabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(46, 128);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(192, 30);
            this.namelabel.TabIndex = 9;
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
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(0, 361);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(475, 23);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Identifiant non disponible";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // userlabel
            // 
            this.userlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(46, 208);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(192, 30);
            this.userlabel.TabIndex = 6;
            // 
            // passwordlabel
            // 
            this.passwordlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(257, 208);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(191, 30);
            this.passwordlabel.TabIndex = 5;
            this.passwordlabel.UseSystemPasswordChar = true;
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
            // connectionButton
            // 
            this.connectionButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionButton.ForeColor = System.Drawing.Color.Black;
            this.connectionButton.Location = new System.Drawing.Point(149, 410);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(192, 40);
            this.connectionButton.TabIndex = 1;
            this.connectionButton.Text = "Inscription";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.InscriptionButton);
            // 
            // NewAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.connectionBackground);
            this.Controls.Add(this.PictureBoxLogo);
            this.Name = "NewAccountView";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.connectionBackground.ResumeLayout(false);
            this.connectionBackground.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label InscriptionLabel;
        private System.Windows.Forms.Panel connectionBackground;
        private System.Windows.Forms.TextBox namelabel;
        private System.Windows.Forms.Label nameLabelTitle;
        private System.Windows.Forms.TextBox userlabel;
        private System.Windows.Forms.TextBox passwordlabel;
        private System.Windows.Forms.Label labelPasswordTitle;
        private System.Windows.Forms.Label labelUsernameTitle;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox familyNameLabel;
        private System.Windows.Forms.Label familyNameLabelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countryboxlabel;
        private System.Windows.Forms.Label errorLabel;
    }
}