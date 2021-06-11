
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
            this.extendLoanButton = new System.Windows.Forms.Button();
            this.extendAllButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panelLine3 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBoxAccount = new System.Windows.Forms.PictureBox();
            this.SearchResults = new System.Windows.Forms.ListBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.LabelSearchText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // actionListBox
            // 
            this.actionListBox.BackColor = System.Drawing.Color.White;
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
            this.actionListBox.SelectedIndexChanged += new System.EventHandler(this.actionListBox_SelectedIndexChanged_1);
            // 
            // extendLoanButton
            // 
            this.extendLoanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.extendLoanButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendLoanButton.Location = new System.Drawing.Point(228, 278);
            this.extendLoanButton.Name = "extendLoanButton";
            this.extendLoanButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.extendLoanButton.Size = new System.Drawing.Size(155, 46);
            this.extendLoanButton.TabIndex = 2;
            this.extendLoanButton.Text = "Prolonger l\'emprunt";
            this.extendLoanButton.UseVisualStyleBackColor = false;
            this.extendLoanButton.Click += new System.EventHandler(this.extendLoanButton_Click);
            // 
            // extendAllButton
            // 
            this.extendAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.extendAllButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendAllButton.Location = new System.Drawing.Point(228, 349);
            this.extendAllButton.Name = "extendAllButton";
            this.extendAllButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.extendAllButton.Size = new System.Drawing.Size(155, 59);
            this.extendAllButton.TabIndex = 4;
            this.extendAllButton.Text = "Prolonger tous les emprunts";
            this.extendAllButton.UseVisualStyleBackColor = false;
            this.extendAllButton.Click += new System.EventHandler(this.ExtendAllButton_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(143, 117);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 19);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Nom:";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.Location = new System.Drawing.Point(297, 117);
            this.labelFirstname.Margin = new System.Windows.Forms.Padding(0);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(59, 19);
            this.labelFirstname.TabIndex = 11;
            this.labelFirstname.Text = "Prénom:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(143, 175);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(99, 19);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Mot de passe:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(143, 146);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(127, 19);
            this.labelUsername.TabIndex = 13;
            this.labelUsername.Text = "Nom d\'utilisateur:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(143, 204);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(42, 19);
            this.labelCountry.TabIndex = 14;
            this.labelCountry.Text = "Pays:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(182, 118);
            this.name.Margin = new System.Windows.Forms.Padding(0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 18);
            this.name.TabIndex = 15;
            this.name.Text = "name";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.BackColor = System.Drawing.Color.Transparent;
            this.firstname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(353, 118);
            this.firstname.Margin = new System.Windows.Forms.Padding(0);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(66, 18);
            this.firstname.TabIndex = 16;
            this.firstname.Text = "firstname";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(268, 147);
            this.username.Margin = new System.Windows.Forms.Padding(0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(64, 18);
            this.username.TabIndex = 17;
            this.username.Text = "username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(238, 175);
            this.password.Margin = new System.Windows.Forms.Padding(0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(65, 18);
            this.password.TabIndex = 18;
            this.password.Text = "password";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.BackColor = System.Drawing.Color.Transparent;
            this.country.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(181, 205);
            this.country.Margin = new System.Windows.Forms.Padding(0);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(54, 18);
            this.country.TabIndex = 19;
            this.country.Text = "country";
            // 
            // panelLine2
            // 
            this.panelLine2.BackColor = System.Drawing.Color.Black;
            this.panelLine2.Location = new System.Drawing.Point(146, 237);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(319, 3);
            this.panelLine2.TabIndex = 20;
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.Black;
            this.panelLine1.Location = new System.Drawing.Point(134, -10);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(3, 467);
            this.panelLine1.TabIndex = 21;
            // 
            // panelLine3
            // 
            this.panelLine3.BackColor = System.Drawing.Color.Black;
            this.panelLine3.Location = new System.Drawing.Point(146, 77);
            this.panelLine3.Name = "panelLine3";
            this.panelLine3.Size = new System.Drawing.Size(645, 3);
            this.panelLine3.TabIndex = 22;
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
            // pictureBoxAccount
            // 
            this.pictureBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAccount.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccount.Image")));
            this.pictureBoxAccount.InitialImage = null;
            this.pictureBoxAccount.Location = new System.Drawing.Point(718, 3);
            this.pictureBoxAccount.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAccount.Name = "pictureBoxAccount";
            this.pictureBoxAccount.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccount.TabIndex = 24;
            this.pictureBoxAccount.TabStop = false;
            this.pictureBoxAccount.Click += new System.EventHandler(this.pictureBoxAccount_Click);
            // 
            // SearchResults
            // 
            this.SearchResults.FormattingEnabled = true;
            this.SearchResults.Location = new System.Drawing.Point(255, 46);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(412, 147);
            this.SearchResults.TabIndex = 26;
            this.SearchResults.Visible = false;
            this.SearchResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchResults_MouseClick);
            this.SearchResults.SelectedValueChanged += new System.EventHandler(this.SearchResults_SelectedIndexChanged);
            this.SearchResults.Leave += new System.EventHandler(this.SearchResults_Leave);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(255, 26);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(394, 20);
            this.SearchBar.TabIndex = 27;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // LabelSearchText
            // 
            this.LabelSearchText.AutoSize = true;
            this.LabelSearchText.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchText.Location = new System.Drawing.Point(151, 25);
            this.LabelSearchText.Name = "LabelSearchText";
            this.LabelSearchText.Size = new System.Drawing.Size(98, 19);
            this.LabelSearchText.TabIndex = 28;
            this.LabelSearchText.Text = "Rechercher...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Informations du Compte:";
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.LabelSearchText);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.pictureBoxAccount);
            this.Controls.Add(this.panelLine3);
            this.Controls.Add(this.panelLine1);
            this.Controls.Add(this.panelLine2);
            this.Controls.Add(this.country);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.extendAllButton);
            this.Controls.Add(this.extendLoanButton);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.actionListBox);
            this.Controls.Add(this.label1);
            this.Name = "AccountView";
            this.Text = "AccountView";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox actionListBox;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button extendLoanButton;
        private System.Windows.Forms.Button extendAllButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panelLine3;
        private System.Windows.Forms.PictureBox pictureBoxAccount;
        private System.Windows.Forms.ListBox SearchResults;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label LabelSearchText;
        private System.Windows.Forms.Label label1;
    }
}