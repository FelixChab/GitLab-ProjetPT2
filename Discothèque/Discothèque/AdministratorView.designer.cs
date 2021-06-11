
namespace Discotèque
{
    partial class AdministratorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorView));
            this.logo = new System.Windows.Forms.PictureBox();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.ButtonExtendedLoans = new System.Windows.Forms.Button();
            this.ButtonLateLoans = new System.Windows.Forms.Button();
            this.ButtonCleanse = new System.Windows.Forms.Button();
            this.ButtonMostLoaned = new System.Windows.Forms.Button();
            this.ButtonLessLoaned = new System.Windows.Forms.Button();
            this.buttonsubsribers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(5, 5);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 105);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // ResultListBox
            // 
            this.ResultListBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 18;
            this.ResultListBox.Location = new System.Drawing.Point(334, 138);
            this.ResultListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(671, 418);
            this.ResultListBox.TabIndex = 1;
            // 
            // ButtonExtendedLoans
            // 
            this.ButtonExtendedLoans.AutoEllipsis = true;
            this.ButtonExtendedLoans.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExtendedLoans.Location = new System.Drawing.Point(67, 138);
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
            this.ButtonLateLoans.Location = new System.Drawing.Point(67, 210);
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
            this.ButtonCleanse.Location = new System.Drawing.Point(67, 273);
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
            this.ButtonMostLoaned.Location = new System.Drawing.Point(67, 337);
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
            this.ButtonLessLoaned.Location = new System.Drawing.Point(67, 420);
            this.ButtonLessLoaned.Name = "ButtonLessLoaned";
            this.ButtonLessLoaned.Size = new System.Drawing.Size(190, 59);
            this.ButtonLessLoaned.TabIndex = 6;
            this.ButtonLessLoaned.Text = "Albums les moins empruntés";
            this.ButtonLessLoaned.UseVisualStyleBackColor = true;
            this.ButtonLessLoaned.Click += new System.EventHandler(this.ButtonLessLoaned_Click);
            // 
            // buttonsubsribers
            // 
            this.buttonsubsribers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubsribers.Location = new System.Drawing.Point(67, 499);
            this.buttonsubsribers.Name = "buttonsubsribers";
            this.buttonsubsribers.Size = new System.Drawing.Size(190, 59);
            this.buttonsubsribers.TabIndex = 8;
            this.buttonsubsribers.Text = "Voir les abonnés";
            this.buttonsubsribers.UseVisualStyleBackColor = true;
            this.buttonsubsribers.Click += new System.EventHandler(this.buttonsubsribers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Panel administrateur";
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(75, 1);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(33, 23);
            this.pageLabel.TabIndex = 10;
            this.pageLabel.Text = "1/1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pageLabel);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(828, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 27);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(140, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.Color.White;
            this.loadingLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.Black;
            this.loadingLabel.Location = new System.Drawing.Point(459, 325);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(417, 45);
            this.loadingLabel.TabIndex = 12;
            this.loadingLabel.Text = "Chargement des données...";
            // 
            // AdministratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1112, 613);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsubsribers);
            this.Controls.Add(this.ButtonLessLoaned);
            this.Controls.Add(this.ButtonMostLoaned);
            this.Controls.Add(this.ButtonCleanse);
            this.Controls.Add(this.ButtonLateLoans);
            this.Controls.Add(this.ButtonExtendedLoans);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.logo);
            this.Name = "AdministratorView";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.Button ButtonExtendedLoans;
        private System.Windows.Forms.Button ButtonLateLoans;
        private System.Windows.Forms.Button ButtonCleanse;
        private System.Windows.Forms.Button ButtonMostLoaned;
        private System.Windows.Forms.Button ButtonLessLoaned;
        private System.Windows.Forms.Button buttonsubsribers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label loadingLabel;
    }
}
 