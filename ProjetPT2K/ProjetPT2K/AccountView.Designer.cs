
namespace ProjetPT2K
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
            this.actionListBox = new System.Windows.Forms.ListBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.extendAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
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
            this.actionListBox.Location = new System.Drawing.Point(471, 93);
            this.actionListBox.Name = "actionListBox";
            this.actionListBox.Size = new System.Drawing.Size(325, 347);
            this.actionListBox.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::ProjetPT2K.Properties.Resources.Logo;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(11, 3);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(105, 105);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prolonger l\'emprunt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // extendAllButton
            // 
            this.extendAllButton.Location = new System.Drawing.Point(228, 343);
            this.extendAllButton.Name = "extendAllButton";
            this.extendAllButton.Size = new System.Drawing.Size(143, 36);
            this.extendAllButton.TabIndex = 4;
            this.extendAllButton.Text = "         Prolonger tous            les l\'emprunt";
            this.extendAllButton.UseVisualStyleBackColor = true;
            this.extendAllButton.Click += new System.EventHandler(this.ExtendAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prénom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nom d\'utilisateur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pays:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(25, 4, 25, 4);
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(25, 4, 25, 4);
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(25, 4, 25, 4);
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(25, 4, 25, 4);
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(370, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(25, 4, 25, 4);
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "label10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(145, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 3);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(127, -15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 479);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(143, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 3);
            this.panel3.TabIndex = 22;
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Load += new System.EventHandler(this.AccountView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}