
namespace ProjetPT2K
{
    partial class FormAdmin
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.listBoxAdminResults = new System.Windows.Forms.ListBox();
            this.ButtonExtendedLoans = new System.Windows.Forms.Button();
            this.ButtonLateLoans = new System.Windows.Forms.Button();
            this.ButtonCleanse = new System.Windows.Forms.Button();
            this.ButtonMostLoaned = new System.Windows.Forms.Button();
            this.ButtonLessLoaned = new System.Windows.Forms.Button();
            this.labelButtonsBackground = new System.Windows.Forms.Label();
            this.buttonsubsribers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.ErrorImage = global::ProjetPT2K.Properties.Resources.App_Logo;
            this.logo.Image = global::ProjetPT2K.Properties.Resources.App_Logo;
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(5, 5);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 105);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // listBoxAdminResults
            // 
            this.listBoxAdminResults.FormattingEnabled = true;
            this.listBoxAdminResults.Location = new System.Drawing.Point(428, 46);
            this.listBoxAdminResults.Name = "listBoxAdminResults";
            this.listBoxAdminResults.Size = new System.Drawing.Size(651, 485);
            this.listBoxAdminResults.TabIndex = 1;
            // 
            // ButtonExtendedLoans
            // 
            this.ButtonExtendedLoans.AutoEllipsis = true;
            this.ButtonExtendedLoans.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExtendedLoans.Location = new System.Drawing.Point(195, 50);
            this.ButtonExtendedLoans.Name = "ButtonExtendedLoans";
            this.ButtonExtendedLoans.Size = new System.Drawing.Size(190, 40);
            this.ButtonExtendedLoans.TabIndex = 2;
            this.ButtonExtendedLoans.Text = "Emprunts prolongés";
            this.ButtonExtendedLoans.UseVisualStyleBackColor = true;
            this.ButtonExtendedLoans.Click += new System.EventHandler(this.ButtonExtendedLoans_Click);
            // 
            // ButtonLateLoans
            // 
            this.ButtonLateLoans.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLateLoans.Location = new System.Drawing.Point(195, 121);
            this.ButtonLateLoans.Name = "ButtonLateLoans";
            this.ButtonLateLoans.Size = new System.Drawing.Size(190, 40);
            this.ButtonLateLoans.TabIndex = 3;
            this.ButtonLateLoans.Text = "Emprunts en retard";
            this.ButtonLateLoans.UseVisualStyleBackColor = true;
            this.ButtonLateLoans.Click += new System.EventHandler(this.ButtonLateLoans_Click);
            // 
            // ButtonCleanse
            // 
            this.ButtonCleanse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanse.Location = new System.Drawing.Point(195, 202);
            this.ButtonCleanse.Name = "ButtonCleanse";
            this.ButtonCleanse.Size = new System.Drawing.Size(190, 40);
            this.ButtonCleanse.TabIndex = 4;
            this.ButtonCleanse.Text = "Purger";
            this.ButtonCleanse.UseVisualStyleBackColor = true;
            this.ButtonCleanse.Click += new System.EventHandler(this.ButtonCleanse_Click);
            // 
            // ButtonMostLoaned
            // 
            this.ButtonMostLoaned.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMostLoaned.Location = new System.Drawing.Point(195, 277);
            this.ButtonMostLoaned.Name = "ButtonMostLoaned";
            this.ButtonMostLoaned.Size = new System.Drawing.Size(190, 59);
            this.ButtonMostLoaned.TabIndex = 5;
            this.ButtonMostLoaned.Text = "Albums les plus empruntés";
            this.ButtonMostLoaned.UseVisualStyleBackColor = true;
            this.ButtonMostLoaned.Click += new System.EventHandler(this.ButtonMostLoaned_Click);
            // 
            // ButtonLessLoaned
            // 
            this.ButtonLessLoaned.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLessLoaned.Location = new System.Drawing.Point(195, 369);
            this.ButtonLessLoaned.Name = "ButtonLessLoaned";
            this.ButtonLessLoaned.Size = new System.Drawing.Size(190, 59);
            this.ButtonLessLoaned.TabIndex = 6;
            this.ButtonLessLoaned.Text = "Albums les moins empruntés";
            this.ButtonLessLoaned.UseVisualStyleBackColor = true;
            this.ButtonLessLoaned.Click += new System.EventHandler(this.ButtonLessLoaned_Click);
            // 
            // labelButtonsBackground
            // 
            this.labelButtonsBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.labelButtonsBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelButtonsBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelButtonsBackground.Location = new System.Drawing.Point(151, 50);
            this.labelButtonsBackground.Name = "labelButtonsBackground";
            this.labelButtonsBackground.Size = new System.Drawing.Size(11, 476);
            this.labelButtonsBackground.TabIndex = 7;
            // 
            // buttonsubsribers
            // 
            this.buttonsubsribers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubsribers.Location = new System.Drawing.Point(195, 467);
            this.buttonsubsribers.Name = "buttonsubsribers";
            this.buttonsubsribers.Size = new System.Drawing.Size(190, 59);
            this.buttonsubsribers.TabIndex = 8;
            this.buttonsubsribers.Text = "Voir les abonnés";
            this.buttonsubsribers.UseVisualStyleBackColor = true;
            this.buttonsubsribers.Click += new System.EventHandler(this.buttonsubsribers_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1112, 613);
            this.Controls.Add(this.buttonsubsribers);
            this.Controls.Add(this.labelButtonsBackground);
            this.Controls.Add(this.ButtonLessLoaned);
            this.Controls.Add(this.ButtonMostLoaned);
            this.Controls.Add(this.ButtonCleanse);
            this.Controls.Add(this.ButtonLateLoans);
            this.Controls.Add(this.ButtonExtendedLoans);
            this.Controls.Add(this.listBoxAdminResults);
            this.Controls.Add(this.logo);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ListBox listBoxAdminResults;
        private System.Windows.Forms.Button ButtonExtendedLoans;
        private System.Windows.Forms.Button ButtonLateLoans;
        private System.Windows.Forms.Button ButtonCleanse;
        private System.Windows.Forms.Button ButtonMostLoaned;
        private System.Windows.Forms.Button ButtonLessLoaned;
        private System.Windows.Forms.Label labelButtonsBackground;
        private System.Windows.Forms.Button buttonsubsribers;
    }
}