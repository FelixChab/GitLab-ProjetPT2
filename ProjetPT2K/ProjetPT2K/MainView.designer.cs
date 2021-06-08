
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
            this.goToAcountView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goToAcountView)).BeginInit();
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
            this.tagRecommandations.Location = new System.Drawing.Point(231, 186);
            this.tagRecommandations.Name = "tagRecommandations";
            this.tagRecommandations.Size = new System.Drawing.Size(25, 13);
            this.tagRecommandations.TabIndex = 13;
            this.tagRecommandations.Text = "___";
            // 
            // tagBestAlbums
            // 
            this.tagBestAlbums.AutoSize = true;
            this.tagBestAlbums.Location = new System.Drawing.Point(231, 342);
            this.tagBestAlbums.Name = "tagBestAlbums";
            this.tagBestAlbums.Size = new System.Drawing.Size(25, 13);
            this.tagBestAlbums.TabIndex = 14;
            this.tagBestAlbums.Text = "___";
            // 
            // goToAcountView
            // 
            this.goToAcountView.Image = ((System.Drawing.Image)(resources.GetObject("goToAcountView.Image")));
            this.goToAcountView.Location = new System.Drawing.Point(753, 12);
            this.goToAcountView.Name = "goToAcountView";
            this.goToAcountView.Size = new System.Drawing.Size(39, 35);
            this.goToAcountView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goToAcountView.TabIndex = 15;
            this.goToAcountView.TabStop = false;
            this.goToAcountView.Click += new System.EventHandler(this.GoToAccountView_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.goToAcountView);
            this.Controls.Add(this.tagBestAlbums);
            this.Controls.Add(this.tagRecommandations);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.mainMenuListBox);
            this.Controls.Add(this.recommandationsLabel);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.goToAcountView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recommandationsLabel;
        private System.Windows.Forms.ListBox mainMenuListBox;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.Label tagRecommandations;
        private System.Windows.Forms.Label tagBestAlbums;
        private System.Windows.Forms.PictureBox goToAcountView;
    }
}