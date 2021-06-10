
namespace ProjetPT2K
{
    partial class AlbumView
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
            this.LabelLine1 = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelLine2 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelSearchText = new System.Windows.Forms.Label();
            this.PictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.PictureBoxAccount = new System.Windows.Forms.PictureBox();
            this.LabelLocationBackground = new System.Windows.Forms.Label();
            this.PictureBoxCover = new System.Windows.Forms.PictureBox();
            this.LabelAlley = new System.Windows.Forms.Label();
            this.LabelLocker = new System.Windows.Forms.Label();
            this.LabelLocation = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelEditor = new System.Windows.Forms.Label();
            this.LabelEditorCountry = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.ButtonLoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLine1
            // 
            this.LabelLine1.BackColor = System.Drawing.Color.Black;
            this.LabelLine1.Location = new System.Drawing.Point(192, 9);
            this.LabelLine1.Name = "LabelLine1";
            this.LabelLine1.Size = new System.Drawing.Size(5, 643);
            this.LabelLine1.TabIndex = 0;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::ProjetPT2K.Properties.Resources.App_Logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(42, 9);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(105, 105);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 1;
            this.PictureBoxLogo.TabStop = false;
            this.PictureBoxLogo.Click += new System.EventHandler(this.PictureBoxLogo_Click);
            // 
            // LabelLine2
            // 
            this.LabelLine2.BackColor = System.Drawing.Color.Black;
            this.LabelLine2.Location = new System.Drawing.Point(215, 95);
            this.LabelLine2.Name = "LabelLine2";
            this.LabelLine2.Size = new System.Drawing.Size(957, 5);
            this.LabelLine2.TabIndex = 2;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(375, 40);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(500, 20);
            this.TextBoxSearch.TabIndex = 3;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearchText
            // 
            this.LabelSearchText.AutoSize = true;
            this.LabelSearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.LabelSearchText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchText.Location = new System.Drawing.Point(231, 36);
            this.LabelSearchText.Name = "LabelSearchText";
            this.LabelSearchText.Size = new System.Drawing.Size(141, 27);
            this.LabelSearchText.TabIndex = 4;
            this.LabelSearchText.Text = "Rechercher...";
            // 
            // PictureBoxSearch
            // 
            this.PictureBoxSearch.Image = global::ProjetPT2K.Properties.Resources.Search;
            this.PictureBoxSearch.Location = new System.Drawing.Point(875, 25);
            this.PictureBoxSearch.Name = "PictureBoxSearch";
            this.PictureBoxSearch.Size = new System.Drawing.Size(59, 50);
            this.PictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSearch.TabIndex = 5;
            this.PictureBoxSearch.TabStop = false;
            // 
            // PictureBoxAccount
            // 
            this.PictureBoxAccount.Image = global::ProjetPT2K.Properties.Resources.Bouton_compte_removebg_preview;
            this.PictureBoxAccount.Location = new System.Drawing.Point(1031, 19);
            this.PictureBoxAccount.Name = "PictureBoxAccount";
            this.PictureBoxAccount.Size = new System.Drawing.Size(100, 60);
            this.PictureBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAccount.TabIndex = 6;
            this.PictureBoxAccount.TabStop = false;
            this.PictureBoxAccount.Click += new System.EventHandler(this.PictureBoxAccount_Click);
            // 
            // LabelLocationBackground
            // 
            this.LabelLocationBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.LabelLocationBackground.Location = new System.Drawing.Point(218, 521);
            this.LabelLocationBackground.Name = "LabelLocationBackground";
            this.LabelLocationBackground.Size = new System.Drawing.Size(154, 108);
            this.LabelLocationBackground.TabIndex = 7;
            // 
            // PictureBoxCover
            // 
            this.PictureBoxCover.BackgroundImage = global::ProjetPT2K.Properties.Resources.FadeC;
            this.PictureBoxCover.Location = new System.Drawing.Point(221, 115);
            this.PictureBoxCover.Name = "PictureBoxCover";
            this.PictureBoxCover.Size = new System.Drawing.Size(942, 262);
            this.PictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxCover.TabIndex = 8;
            this.PictureBoxCover.TabStop = false;
            // 
            // LabelAlley
            // 
            this.LabelAlley.AutoSize = true;
            this.LabelAlley.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.LabelAlley.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlley.Location = new System.Drawing.Point(232, 566);
            this.LabelAlley.Name = "LabelAlley";
            this.LabelAlley.Size = new System.Drawing.Size(48, 23);
            this.LabelAlley.TabIndex = 9;
            this.LabelAlley.Text = "Allée";
            // 
            // LabelLocker
            // 
            this.LabelLocker.AutoSize = true;
            this.LabelLocker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.LabelLocker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLocker.Location = new System.Drawing.Point(232, 595);
            this.LabelLocker.Name = "LabelLocker";
            this.LabelLocker.Size = new System.Drawing.Size(57, 23);
            this.LabelLocker.TabIndex = 10;
            this.LabelLocker.Text = "Casier";
            // 
            // LabelLocation
            // 
            this.LabelLocation.AutoSize = true;
            this.LabelLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.LabelLocation.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLocation.Location = new System.Drawing.Point(232, 531);
            this.LabelLocation.Name = "LabelLocation";
            this.LabelLocation.Size = new System.Drawing.Size(115, 23);
            this.LabelLocation.TabIndex = 11;
            this.LabelLocation.Text = "Emplacement:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(233, 387);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(66, 30);
            this.LabelTitle.TabIndex = 12;
            this.LabelTitle.Text = "Titre";
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGenre.Location = new System.Drawing.Point(233, 423);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(66, 27);
            this.LabelGenre.TabIndex = 13;
            this.LabelGenre.Text = "Genre";
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.Location = new System.Drawing.Point(233, 457);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(66, 27);
            this.LabelYear.TabIndex = 14;
            this.LabelYear.Text = "Année";
            // 
            // LabelEditor
            // 
            this.LabelEditor.AutoSize = true;
            this.LabelEditor.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditor.Location = new System.Drawing.Point(966, 387);
            this.LabelEditor.Name = "LabelEditor";
            this.LabelEditor.Size = new System.Drawing.Size(87, 30);
            this.LabelEditor.TabIndex = 15;
            this.LabelEditor.Text = "Editeur";
            // 
            // LabelEditorCountry
            // 
            this.LabelEditorCountry.AutoSize = true;
            this.LabelEditorCountry.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditorCountry.Location = new System.Drawing.Point(966, 423);
            this.LabelEditorCountry.Name = "LabelEditorCountry";
            this.LabelEditorCountry.Size = new System.Drawing.Size(58, 29);
            this.LabelEditorCountry.TabIndex = 16;
            this.LabelEditorCountry.Text = "Pays";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(987, 578);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(61, 35);
            this.LabelPrice.TabIndex = 17;
            this.LabelPrice.Text = "Prix";
            // 
            // ButtonLoan
            // 
            this.ButtonLoan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoan.Location = new System.Drawing.Point(957, 510);
            this.ButtonLoan.Name = "ButtonLoan";
            this.ButtonLoan.Size = new System.Drawing.Size(125, 64);
            this.ButtonLoan.TabIndex = 18;
            this.ButtonLoan.Text = "EMPRUNTER";
            this.ButtonLoan.UseVisualStyleBackColor = true;
            this.ButtonLoan.Click += new System.EventHandler(this.ButtonLoan_Click);
            // 
            // AlbumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1185, 662);
            this.Controls.Add(this.ButtonLoan);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelEditorCountry);
            this.Controls.Add(this.LabelEditor);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.LabelGenre);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelLocation);
            this.Controls.Add(this.LabelLocker);
            this.Controls.Add(this.LabelAlley);
            this.Controls.Add(this.PictureBoxCover);
            this.Controls.Add(this.LabelLocationBackground);
            this.Controls.Add(this.PictureBoxAccount);
            this.Controls.Add(this.PictureBoxSearch);
            this.Controls.Add(this.LabelSearchText);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.LabelLine2);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.LabelLine1);
            this.MaximumSize = new System.Drawing.Size(1201, 701);
            this.MinimumSize = new System.Drawing.Size(1199, 699);
            this.Name = "AlbumView";
            this.Text = "AlbumView";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AlbumView_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLine1;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelLine2;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearchText;
        private System.Windows.Forms.PictureBox PictureBoxSearch;
        private System.Windows.Forms.PictureBox PictureBoxAccount;
        private System.Windows.Forms.Label LabelLocationBackground;
        private System.Windows.Forms.PictureBox PictureBoxCover;
        private System.Windows.Forms.Label LabelAlley;
        private System.Windows.Forms.Label LabelLocker;
        private System.Windows.Forms.Label LabelLocation;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelEditor;
        private System.Windows.Forms.Label LabelEditorCountry;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Button ButtonLoan;
    }
}