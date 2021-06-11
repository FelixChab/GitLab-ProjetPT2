
namespace Discotèque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumView));
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelLine2 = new System.Windows.Forms.Label();
            this.LabelLocationBackground = new System.Windows.Forms.Label();
            this.AlbumCoverBox = new System.Windows.Forms.PictureBox();
            this.LabelAlley = new System.Windows.Forms.Label();
            this.LabelLocker = new System.Windows.Forms.Label();
            this.LabelLocation = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelEditor = new System.Windows.Forms.Label();
            this.LabelEditorCountry = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
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
            this.LabelLine2.Location = new System.Drawing.Point(12, 291);
            this.LabelLine2.Name = "LabelLine2";
            this.LabelLine2.Size = new System.Drawing.Size(658, 10);
            this.LabelLine2.TabIndex = 2;
            // 
            // LabelLocationBackground
            // 
            this.LabelLocationBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.LabelLocationBackground.Location = new System.Drawing.Point(39, 528);
            this.LabelLocationBackground.Name = "LabelLocationBackground";
            this.LabelLocationBackground.Size = new System.Drawing.Size(154, 108);
            this.LabelLocationBackground.TabIndex = 7;
            // 
            // AlbumCoverBox
            // 
            this.AlbumCoverBox.Image = ((System.Drawing.Image)(resources.GetObject("AlbumCoverBox.Image")));
            this.AlbumCoverBox.Location = new System.Drawing.Point(180, 9);
            this.AlbumCoverBox.Name = "AlbumCoverBox";
            this.AlbumCoverBox.Size = new System.Drawing.Size(461, 262);
            this.AlbumCoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumCoverBox.TabIndex = 8;
            this.AlbumCoverBox.TabStop = false;
            // 
            // LabelAlley
            // 
            this.LabelAlley.AutoSize = true;
            this.LabelAlley.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.LabelAlley.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlley.Location = new System.Drawing.Point(53, 573);
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
            this.LabelLocker.Location = new System.Drawing.Point(53, 602);
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
            this.LabelLocation.Location = new System.Drawing.Point(53, 538);
            this.LabelLocation.Name = "LabelLocation";
            this.LabelLocation.Size = new System.Drawing.Size(115, 23);
            this.LabelLocation.TabIndex = 11;
            this.LabelLocation.Text = "Emplacement:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(37, 335);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(66, 30);
            this.LabelTitle.TabIndex = 12;
            this.LabelTitle.Text = "Titre";
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGenre.Location = new System.Drawing.Point(37, 371);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(66, 27);
            this.LabelGenre.TabIndex = 13;
            this.LabelGenre.Text = "Genre";
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.Location = new System.Drawing.Point(37, 405);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(66, 27);
            this.LabelYear.TabIndex = 14;
            this.LabelYear.Text = "Année";
            // 
            // LabelEditor
            // 
            this.LabelEditor.AutoSize = true;
            this.LabelEditor.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditor.Location = new System.Drawing.Point(445, 335);
            this.LabelEditor.Name = "LabelEditor";
            this.LabelEditor.Size = new System.Drawing.Size(87, 30);
            this.LabelEditor.TabIndex = 15;
            this.LabelEditor.Text = "Editeur";
            // 
            // LabelEditorCountry
            // 
            this.LabelEditorCountry.AutoSize = true;
            this.LabelEditorCountry.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditorCountry.Location = new System.Drawing.Point(445, 371);
            this.LabelEditorCountry.Name = "LabelEditorCountry";
            this.LabelEditorCountry.Size = new System.Drawing.Size(58, 29);
            this.LabelEditorCountry.TabIndex = 16;
            this.LabelEditorCountry.Text = "Pays";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(527, 584);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(61, 35);
            this.LabelPrice.TabIndex = 17;
            this.LabelPrice.Text = "Prix";
            // 
            // ActionButton
            // 
            this.ActionButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.Location = new System.Drawing.Point(503, 517);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(125, 64);
            this.ActionButton.TabIndex = 18;
            this.ActionButton.Text = "Action";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ButtonLoan_Click);
            // 
            // AlbumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(676, 662);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelEditorCountry);
            this.Controls.Add(this.LabelEditor);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.LabelGenre);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelLocation);
            this.Controls.Add(this.LabelLocker);
            this.Controls.Add(this.LabelAlley);
            this.Controls.Add(this.AlbumCoverBox);
            this.Controls.Add(this.LabelLocationBackground);
            this.Controls.Add(this.LabelLine2);
            this.Controls.Add(this.PictureBoxLogo);
            this.MaximumSize = new System.Drawing.Size(1201, 701);
            this.Name = "AlbumView";
            this.Text = "AlbumView";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelLine2;
        private System.Windows.Forms.Label LabelLocationBackground;
        private System.Windows.Forms.PictureBox AlbumCoverBox;
        private System.Windows.Forms.Label LabelAlley;
        private System.Windows.Forms.Label LabelLocker;
        private System.Windows.Forms.Label LabelLocation;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelEditor;
        private System.Windows.Forms.Label LabelEditorCountry;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Button ActionButton;
    }
}