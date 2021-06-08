
namespace ProjetPT2K
{
    partial class AdminView
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
            this.result = new System.Windows.Forms.ListBox();
            this.extendedLoansButton = new System.Windows.Forms.Button();
            this.inLateButton = new System.Windows.Forms.Button();
            this.purgeButton = new System.Windows.Forms.Button();
            this.mostBorrowedAlbumsButton = new System.Windows.Forms.Button();
            this.albumNotCheckedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.Location = new System.Drawing.Point(393, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(906, 420);
            this.result.TabIndex = 0;
            // 
            // extendedLoansButton
            // 
            this.extendedLoansButton.Location = new System.Drawing.Point(134, 50);
            this.extendedLoansButton.Name = "extendedLoansButton";
            this.extendedLoansButton.Size = new System.Drawing.Size(210, 23);
            this.extendedLoansButton.TabIndex = 1;
            this.extendedLoansButton.Text = "Emprunts prolongés";
            this.extendedLoansButton.UseVisualStyleBackColor = true;
            this.extendedLoansButton.Click += new System.EventHandler(this.extendedLoansButton_Click);
            // 
            // inLateButton
            // 
            this.inLateButton.Location = new System.Drawing.Point(134, 118);
            this.inLateButton.Name = "inLateButton";
            this.inLateButton.Size = new System.Drawing.Size(210, 23);
            this.inLateButton.TabIndex = 2;
            this.inLateButton.Text = "Emprunts en retard";
            this.inLateButton.UseVisualStyleBackColor = true;
            this.inLateButton.Click += new System.EventHandler(this.inLateButton_Click);
            // 
            // purgeButton
            // 
            this.purgeButton.Location = new System.Drawing.Point(134, 194);
            this.purgeButton.Name = "purgeButton";
            this.purgeButton.Size = new System.Drawing.Size(210, 23);
            this.purgeButton.TabIndex = 3;
            this.purgeButton.Text = "Purger";
            this.purgeButton.UseVisualStyleBackColor = true;
            this.purgeButton.Click += new System.EventHandler(this.purgeButton_Click);
            // 
            // mostBorrowedAlbumsButton
            // 
            this.mostBorrowedAlbumsButton.Location = new System.Drawing.Point(134, 271);
            this.mostBorrowedAlbumsButton.Name = "mostBorrowedAlbumsButton";
            this.mostBorrowedAlbumsButton.Size = new System.Drawing.Size(210, 23);
            this.mostBorrowedAlbumsButton.TabIndex = 4;
            this.mostBorrowedAlbumsButton.Text = "Albums les plus empruntés";
            this.mostBorrowedAlbumsButton.UseVisualStyleBackColor = true;
            this.mostBorrowedAlbumsButton.Click += new System.EventHandler(this.MostBorrowedAlbumsButton_Click);
            // 
            // albumNotCheckedButton
            // 
            this.albumNotCheckedButton.Location = new System.Drawing.Point(134, 351);
            this.albumNotCheckedButton.Name = "albumNotCheckedButton";
            this.albumNotCheckedButton.Size = new System.Drawing.Size(210, 23);
            this.albumNotCheckedButton.TabIndex = 5;
            this.albumNotCheckedButton.Text = "Albums non empruntés depuis un an";
            this.albumNotCheckedButton.UseVisualStyleBackColor = true;
            this.albumNotCheckedButton.Click += new System.EventHandler(this.AlbumNotCheckedButton_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 450);
            this.Controls.Add(this.albumNotCheckedButton);
            this.Controls.Add(this.mostBorrowedAlbumsButton);
            this.Controls.Add(this.purgeButton);
            this.Controls.Add(this.inLateButton);
            this.Controls.Add(this.extendedLoansButton);
            this.Controls.Add(this.result);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox result;
        private System.Windows.Forms.Button extendedLoansButton;
        private System.Windows.Forms.Button inLateButton;
        private System.Windows.Forms.Button purgeButton;
        private System.Windows.Forms.Button mostBorrowedAlbumsButton;
        private System.Windows.Forms.Button albumNotCheckedButton;
    }
}