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
            this.asentajaLabel = new System.Windows.Forms.Label();
            this.operatorTextbox = new System.Windows.Forms.TextBox();
            this.dayTextbox = new System.Windows.Forms.TextBox();
            this.dayLabel = new System.Windows.Forms.Label();
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
            // asentajaLabel
            // 
            this.asentajaLabel.AutoSize = true;
            this.asentajaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asentajaLabel.Location = new System.Drawing.Point(4, 291);
            this.asentajaLabel.Name = "asentajaLabel";
            this.asentajaLabel.Size = new System.Drawing.Size(72, 20);
            this.asentajaLabel.TabIndex = 2;
            this.asentajaLabel.Text = "Asentaja";
            // 
            // operatorTextbox
            // 
            this.operatorTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.operatorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorTextbox.Location = new System.Drawing.Point(8, 315);
            this.operatorTextbox.Name = "operatorTextbox";
            this.operatorTextbox.ReadOnly = true;
            this.operatorTextbox.Size = new System.Drawing.Size(100, 26);
            this.operatorTextbox.TabIndex = 3;
            // 
            // dayTextbox
            // 
            this.dayTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dayTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTextbox.Location = new System.Drawing.Point(115, 315);
            this.dayTextbox.Name = "dayTextbox";
            this.dayTextbox.ReadOnly = true;
            this.dayTextbox.Size = new System.Drawing.Size(145, 26);
            this.dayTextbox.TabIndex = 4;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(111, 291);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(47, 20);
            this.dayLabel.TabIndex = 5;
            this.dayLabel.Text = "Päivä";
            // 
            // customButton
            // 
            this.customButton.Location = new System.Drawing.Point(332, 315);
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
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.dayTextbox);
            this.Controls.Add(this.operatorTextbox);
            this.Controls.Add(this.asentajaLabel);
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
        private System.Windows.Forms.Label asentajaLabel;
        private System.Windows.Forms.TextBox operatorTextbox;
        private System.Windows.Forms.TextBox dayTextbox;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Button customButton;
    }
}
