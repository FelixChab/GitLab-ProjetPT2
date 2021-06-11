
namespace Discotèque
{
    partial class AccountView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountView));
            this.actionListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.extendAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listeAlbum = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountinfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // actionListBox
            // 
            this.actionListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.actionListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionListBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionListBox.ForeColor = System.Drawing.Color.Black;
            this.actionListBox.FormattingEnabled = true;
            this.actionListBox.HorizontalScrollbar = true;
            this.actionListBox.ItemHeight = 15;
            this.actionListBox.Location = new System.Drawing.Point(471, 90);
            this.actionListBox.MaximumSize = new System.Drawing.Size(320, 360);
            this.actionListBox.MinimumSize = new System.Drawing.Size(320, 360);
            this.actionListBox.Name = "actionListBox";
            this.actionListBox.Size = new System.Drawing.Size(320, 347);
            this.actionListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 280);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prolonger l\'emprunt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // extendAllButton
            // 
            this.extendAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.extendAllButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendAllButton.Location = new System.Drawing.Point(228, 362);
            this.extendAllButton.Name = "extendAllButton";
            this.extendAllButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.extendAllButton.Size = new System.Drawing.Size(143, 36);
            this.extendAllButton.TabIndex = 4;
            this.extendAllButton.Text = "         Prolonger tous            les l\'emprunt";
            this.extendAllButton.UseVisualStyleBackColor = false;
            this.extendAllButton.Click += new System.EventHandler(this.ExtendAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prénom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nom d\'utilisateur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pays:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(184, 114);
            this.name.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.name.MaximumSize = new System.Drawing.Size(105, 25);
            this.name.MinimumSize = new System.Drawing.Size(105, 25);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(15, 4, 1, 4);
            this.name.Size = new System.Drawing.Size(105, 25);
            this.name.TabIndex = 15;
            this.name.Text = "name";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.firstname.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(352, 114);
            this.firstname.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.firstname.MaximumSize = new System.Drawing.Size(105, 25);
            this.firstname.MinimumSize = new System.Drawing.Size(105, 25);
            this.firstname.Name = "firstname";
            this.firstname.Padding = new System.Windows.Forms.Padding(15, 4, 1, 4);
            this.firstname.Size = new System.Drawing.Size(105, 25);
            this.firstname.TabIndex = 16;
            this.firstname.Text = "firstname";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.username.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(250, 143);
            this.username.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.username.MaximumSize = new System.Drawing.Size(105, 25);
            this.username.MinimumSize = new System.Drawing.Size(105, 25);
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(15, 4, 1, 4);
            this.username.Size = new System.Drawing.Size(105, 25);
            this.username.TabIndex = 17;
            this.username.Text = "username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.password.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(228, 172);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.MaximumSize = new System.Drawing.Size(105, 25);
            this.password.MinimumSize = new System.Drawing.Size(105, 25);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(15, 4, 1, 4);
            this.password.Size = new System.Drawing.Size(105, 25);
            this.password.TabIndex = 18;
            this.password.Text = "password";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.country.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(184, 201);
            this.country.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.country.MaximumSize = new System.Drawing.Size(105, 25);
            this.country.MinimumSize = new System.Drawing.Size(105, 25);
            this.country.Name = "country";
            this.country.Padding = new System.Windows.Forms.Padding(15, 4, 1, 4);
            this.country.Size = new System.Drawing.Size(105, 25);
            this.country.TabIndex = 19;
            this.country.Text = "country";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(146, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 3);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(134, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 467);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(146, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 3);
            this.panel3.TabIndex = 22;
            // 
            // listeAlbum
            // 
            this.listeAlbum.DropDownHeight = 140;
            this.listeAlbum.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeAlbum.FormattingEnabled = true;
            this.listeAlbum.IntegralHeight = false;
            this.listeAlbum.ItemHeight = 29;
            this.listeAlbum.Location = new System.Drawing.Point(146, 21);
            this.listeAlbum.Name = "listeAlbum";
            this.listeAlbum.Size = new System.Drawing.Size(553, 37);
            this.listeAlbum.TabIndex = 23;
            this.listeAlbum.Text = "Rechercher";
            this.listeAlbum.TextChanged += new System.EventHandler(this.listeAlbum_TextChanged);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(11, 3);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(105, 105);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(718, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // accountinfo
            // 
            this.accountinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.accountinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountinfo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountinfo.Location = new System.Drawing.Point(146, 91);
            this.accountinfo.Name = "accountinfo";
            this.accountinfo.Size = new System.Drawing.Size(250, 21);
            this.accountinfo.TabIndex = 25;
            this.accountinfo.Text = "Informations du compte:";
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.accountinfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listeAlbum);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.country);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extendAllButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.actionListBox);
            this.Name = "AccountView";
            this.Text = "AccountView";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox actionListBox;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button extendAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox listeAlbum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox accountinfo;
    }
}