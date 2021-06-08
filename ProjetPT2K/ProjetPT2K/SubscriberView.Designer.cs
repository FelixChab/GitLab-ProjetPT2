
namespace ProjetPT2K
{
    partial class SubscriberView
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
            this.mainMenuListBox = new System.Windows.Forms.ListBox();
            this.deconnectionButton = new System.Windows.Forms.Button();
            this.actionListBox = new System.Windows.Forms.ListBox();
            this.selectionButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.extendAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuListBox
            // 
            this.mainMenuListBox.FormattingEnabled = true;
            this.mainMenuListBox.Location = new System.Drawing.Point(12, 12);
            this.mainMenuListBox.Name = "mainMenuListBox";
            this.mainMenuListBox.Size = new System.Drawing.Size(380, 225);
            this.mainMenuListBox.TabIndex = 0;
            // 
            // deconnectionButton
            // 
            this.deconnectionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.deconnectionButton.Location = new System.Drawing.Point(296, 257);
            this.deconnectionButton.Name = "deconnectionButton";
            this.deconnectionButton.Size = new System.Drawing.Size(96, 23);
            this.deconnectionButton.TabIndex = 1;
            this.deconnectionButton.Text = "Déconnexion";
            this.deconnectionButton.UseVisualStyleBackColor = true;
            // 
            // actionListBox
            // 
            this.actionListBox.FormattingEnabled = true;
            this.actionListBox.Location = new System.Drawing.Point(398, 12);
            this.actionListBox.Name = "actionListBox";
            this.actionListBox.Size = new System.Drawing.Size(615, 225);
            this.actionListBox.TabIndex = 2;
            this.actionListBox.SelectedValueChanged += new System.EventHandler(this.ActionListBox_SelectedValueChanged);
            // 
            // selectionButton
            // 
            this.selectionButton.Location = new System.Drawing.Point(195, 257);
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Size = new System.Drawing.Size(75, 23);
            this.selectionButton.TabIndex = 3;
            this.selectionButton.Text = "Sélectionner";
            this.selectionButton.UseVisualStyleBackColor = true;
            this.selectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // actionButton
            // 
            this.actionButton.Enabled = false;
            this.actionButton.Location = new System.Drawing.Point(823, 257);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 4;
            this.actionButton.Text = "Action";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Visible = false;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // albumTitleTextBox
            // 
            this.albumTitleTextBox.Enabled = false;
            this.albumTitleTextBox.Location = new System.Drawing.Point(544, 259);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.Size = new System.Drawing.Size(255, 20);
            this.albumTitleTextBox.TabIndex = 5;
            this.albumTitleTextBox.Visible = false;
            this.albumTitleTextBox.TextChanged += new System.EventHandler(this.AlbumTitleTextBox_TextChanged);
            // 
            // extendAllButton
            // 
            this.extendAllButton.Enabled = false;
            this.extendAllButton.Location = new System.Drawing.Point(918, 257);
            this.extendAllButton.Name = "extendAllButton";
            this.extendAllButton.Size = new System.Drawing.Size(95, 23);
            this.extendAllButton.TabIndex = 6;
            this.extendAllButton.Text = "Prolonger tout";
            this.extendAllButton.UseVisualStyleBackColor = true;
            this.extendAllButton.Visible = false;
            this.extendAllButton.Click += new System.EventHandler(this.ExtendAllButton_Click);
            // 
            // SubscriberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 510);
            this.Controls.Add(this.extendAllButton);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.selectionButton);
            this.Controls.Add(this.actionListBox);
            this.Controls.Add(this.deconnectionButton);
            this.Controls.Add(this.mainMenuListBox);
            this.Name = "SubscriberView";
            this.Text = "SubscriberView";
            this.Load += new System.EventHandler(this.SubscriberView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mainMenuListBox;
        private System.Windows.Forms.Button deconnectionButton;
        private System.Windows.Forms.ListBox actionListBox;
        private System.Windows.Forms.Button selectionButton;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.Button extendAllButton;
    }
}