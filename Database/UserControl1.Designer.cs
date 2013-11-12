namespace Database
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.decriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.customButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decriptionLabel
            // 
            this.decriptionLabel.AutoSize = true;
            this.decriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.decriptionLabel.Name = "decriptionLabel";
            this.decriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.decriptionLabel.TabIndex = 0;
            this.decriptionLabel.Text = "Description";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextbox.Location = new System.Drawing.Point(4, 24);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ReadOnly = true;
            this.descriptionTextbox.Size = new System.Drawing.Size(459, 260);
            this.descriptionTextbox.TabIndex = 1;
            // 
            // customButton
            // 
            this.customButton.Location = new System.Drawing.Point(513, 261);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(75, 23);
            this.customButton.TabIndex = 6;
            this.customButton.Text = "Muokkaa";
            this.customButton.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.decriptionLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(634, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label decriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Button customButton;
    }
}
