
namespace ProjetPT2K
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.recommandationsLabel = new System.Windows.Forms.Label();
            this.mainMenuListBox = new System.Windows.Forms.ListBox();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.tagRecommandations = new System.Windows.Forms.Label();
            this.tagBestAlbums = new System.Windows.Forms.Label();
            this.mostBorrowedAlbumsLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listeAlbum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // recommandationsLabel
            // 
            this.recommandationsLabel.AutoSize = true;
            this.recommandationsLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommandationsLabel.Location = new System.Drawing.Point(226, 124);
            this.recommandationsLabel.Name = "recommandationsLabel";
            this.recommandationsLabel.Size = new System.Drawing.Size(185, 29);
            this.recommandationsLabel.TabIndex = 9;
            this.recommandationsLabel.Text = "Recommandations";
            // 
            // mainMenuListBox
            // 
            this.mainMenuListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.mainMenuListBox.FormattingEnabled = true;
            this.mainMenuListBox.Location = new System.Drawing.Point(12, 12);
            this.mainMenuListBox.Name = "mainMenuListBox";
            this.mainMenuListBox.Size = new System.Drawing.Size(179, 433);
            this.mainMenuListBox.TabIndex = 10;
            this.mainMenuListBox.SelectedIndexChanged += new System.EventHandler(this.mainMenuListBox_SelectedIndexChanged);
            // 
            // albumTitleTextBox
            // 
            this.albumTitleTextBox.Enabled = false;
            this.albumTitleTextBox.Location = new System.Drawing.Point(231, 12);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.Size = new System.Drawing.Size(372, 20);
            this.albumTitleTextBox.TabIndex = 11;
            this.albumTitleTextBox.Visible = false;
            // 
            // tagRecommandations
            // 
            this.tagRecommandations.AutoSize = true;
            this.tagRecommandations.BackColor = System.Drawing.Color.Transparent;
            this.tagRecommandations.Location = new System.Drawing.Point(231, 168);
            this.tagRecommandations.Name = "tagRecommandations";
            this.tagRecommandations.Size = new System.Drawing.Size(10, 13);
            this.tagRecommandations.TabIndex = 13;
            this.tagRecommandations.Text = " ";
            // 
            // tagBestAlbums
            // 
            this.tagBestAlbums.AutoSize = true;
            this.tagBestAlbums.BackColor = System.Drawing.Color.Transparent;
            this.tagBestAlbums.Location = new System.Drawing.Point(228, 322);
            this.tagBestAlbums.Name = "tagBestAlbums";
            this.tagBestAlbums.Size = new System.Drawing.Size(10, 13);
            this.tagBestAlbums.TabIndex = 14;
            this.tagBestAlbums.Text = " ";
            // 
            // mostBorrowedAlbumsLabel
            // 
            this.mostBorrowedAlbumsLabel.AutoSize = true;
            this.mostBorrowedAlbumsLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostBorrowedAlbumsLabel.Location = new System.Drawing.Point(226, 283);
            this.mostBorrowedAlbumsLabel.Name = "mostBorrowedAlbumsLabel";
            this.mostBorrowedAlbumsLabel.Size = new System.Drawing.Size(302, 29);
            this.mostBorrowedAlbumsLabel.TabIndex = 16;
            this.mostBorrowedAlbumsLabel.Text = "Les albums les plus empruntés";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = global::ProjetPT2K.Properties.Resources.Logo;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(11, 3);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(105, 105);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 17;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(134, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 467);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(146, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 3);
            this.panel3.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetPT2K.Properties.Resources.Bouton_compte_removebg_preview;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(718, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.listeAlbum.TabIndex = 26;
            this.listeAlbum.Text = "Rechercher";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.listeAlbum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.mostBorrowedAlbumsLabel);
            this.Controls.Add(this.tagBestAlbums);
            this.Controls.Add(this.tagRecommandations);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.mainMenuListBox);
            this.Controls.Add(this.recommandationsLabel);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recommandationsLabel;
        private System.Windows.Forms.ListBox mainMenuListBox;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.Label tagRecommandations;
        private System.Windows.Forms.Label tagBestAlbums;
        private System.Windows.Forms.Label mostBorrowedAlbumsLabel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox listeAlbum;
    }
}