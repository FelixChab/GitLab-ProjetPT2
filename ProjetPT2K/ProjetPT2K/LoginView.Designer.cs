
namespace ProjetPT2K
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.connectionLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.connectionBackground = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.TextBox();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.connectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.connectionBackground.SuspendLayout();
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
            // logo
            // 
            this.logo.Image = global::ProjetPT2K.Properties.Resources.App_Logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(121, 112);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // connectionBackground
            // 
            this.connectionBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.connectionBackground.Controls.Add(this.errorLabel);
            this.connectionBackground.Controls.Add(this.userlabel);
            this.connectionBackground.Controls.Add(this.passwordlabel);
            this.connectionBackground.Controls.Add(this.labelPasswordLogin);
            this.connectionBackground.Controls.Add(this.labelUserLogin);
            this.connectionBackground.Controls.Add(this.linkLabel);
            this.connectionBackground.Controls.Add(this.connectionButton);
            this.connectionBackground.Controls.Add(this.connectionLabel);
            this.connectionBackground.Location = new System.Drawing.Point(192, 51);
            this.connectionBackground.Name = "connectionBackground";
            this.connectionBackground.Size = new System.Drawing.Size(426, 359);
            this.connectionBackground.TabIndex = 2;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(132, 230);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(150, 19);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Mot de passe incorect";
            this.errorLabel.Visible = false;
            // 
            // userlabel
            // 
            this.userlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(116, 102);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(192, 30);
            this.userlabel.TabIndex = 6;
            // 
            // passwordlabel
            // 
            this.passwordlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(117, 175);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(191, 30);
            this.passwordlabel.TabIndex = 5;
            this.passwordlabel.UseSystemPasswordChar = true;
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
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel.Location = new System.Drawing.Point(101, 319);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(223, 21);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Vous n\'avez pas de compte ?";
            this.linkLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // connectionButton
            // 
            this.connectionButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionButton.ForeColor = System.Drawing.Color.Black;
            this.connectionButton.Location = new System.Drawing.Point(116, 252);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(192, 40);
            this.connectionButton.TabIndex = 1;
            this.connectionButton.Text = "Connexion";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectionBackground);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.connectionBackground.ResumeLayout(false);
            this.connectionBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel connectionBackground;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox userlabel;
        private System.Windows.Forms.TextBox passwordlabel;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}