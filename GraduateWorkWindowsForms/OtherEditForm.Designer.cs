﻿namespace GraduateWorkWindowsForms
{
    partial class OtherEditForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.OtherListEdit = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 40);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OtherListEdit
            // 
            this.OtherListEdit.Location = new System.Drawing.Point(12, 12);
            this.OtherListEdit.Name = "OtherListEdit";
            this.OtherListEdit.Size = new System.Drawing.Size(180, 176);
            this.OtherListEdit.TabIndex = 2;
            this.OtherListEdit.Text = "";
            // 
            // OtherEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(212, 281);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OtherListEdit);
            this.Name = "OtherEditForm";
            this.Text = "OtherEditForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.RichTextBox OtherListEdit;
    }
}