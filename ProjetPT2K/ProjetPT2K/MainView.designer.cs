
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
            this.recommandationsLabel = new System.Windows.Forms.Label();
            this.tagRecommandations = new System.Windows.Forms.Label();
            this.tagBestAlbums = new System.Windows.Forms.Label();
            this.mostBorrowedAlbumsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(134, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 467);
            this.panel1.TabIndex = 17;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mostBorrowedAlbumsLabel);
            this.Controls.Add(this.tagBestAlbums);
            this.Controls.Add(this.tagRecommandations);
            this.Controls.Add(this.recommandationsLabel);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recommandationsLabel;
        private System.Windows.Forms.Label tagRecommandations;
        private System.Windows.Forms.Label tagBestAlbums;
        private System.Windows.Forms.Label mostBorrowedAlbumsLabel;
        private System.Windows.Forms.Panel panel1;
    }
}