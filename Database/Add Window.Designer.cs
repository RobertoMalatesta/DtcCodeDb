namespace Database
{
    partial class Add
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
            this.components = new System.ComponentModel.Container();
            this.saveButton = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.EngineTextBox = new System.Windows.Forms.TextBox();
            this.Merkki = new System.Windows.Forms.Label();
            this.Malli = new System.Windows.Forms.Label();
            this.Moottori = new System.Windows.Forms.Label();
            this.DtcTextBox = new System.Windows.Forms.TextBox();
            this.DTC = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Importbutton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(607, 248);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Tallenna";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(301, 12);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(380, 230);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(3, 3);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(165, 26);
            this.ManufacturerTextBox.TabIndex = 3;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(3, 33);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(165, 26);
            this.ModelTextBox.TabIndex = 4;
            // 
            // EngineTextBox
            // 
            this.EngineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineTextBox.Location = new System.Drawing.Point(3, 63);
            this.EngineTextBox.Name = "EngineTextBox";
            this.EngineTextBox.Size = new System.Drawing.Size(165, 26);
            this.EngineTextBox.TabIndex = 5;
            // 
            // Merkki
            // 
            this.Merkki.AutoSize = true;
            this.Merkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Merkki.Location = new System.Drawing.Point(7, 6);
            this.Merkki.Name = "Merkki";
            this.Merkki.Size = new System.Drawing.Size(82, 20);
            this.Merkki.TabIndex = 6;
            this.Merkki.Text = "Valmistaja";
            // 
            // Malli
            // 
            this.Malli.AutoSize = true;
            this.Malli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Malli.Location = new System.Drawing.Point(49, 36);
            this.Malli.Name = "Malli";
            this.Malli.Size = new System.Drawing.Size(40, 20);
            this.Malli.TabIndex = 7;
            this.Malli.Text = "Malli";
            // 
            // Moottori
            // 
            this.Moottori.AutoSize = true;
            this.Moottori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moottori.Location = new System.Drawing.Point(23, 66);
            this.Moottori.Name = "Moottori";
            this.Moottori.Size = new System.Drawing.Size(67, 20);
            this.Moottori.TabIndex = 8;
            this.Moottori.Text = "Moottori";
            // 
            // DtcTextBox
            // 
            this.DtcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtcTextBox.Location = new System.Drawing.Point(3, 92);
            this.DtcTextBox.Name = "DtcTextBox";
            this.DtcTextBox.Size = new System.Drawing.Size(165, 26);
            this.DtcTextBox.TabIndex = 9;
            // 
            // DTC
            // 
            this.DTC.AutoSize = true;
            this.DTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTC.Location = new System.Drawing.Point(49, 95);
            this.DTC.Name = "DTC";
            this.DTC.Size = new System.Drawing.Size(41, 20);
            this.DTC.TabIndex = 10;
            this.DTC.Text = "DTC";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(19, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DTC);
            this.splitContainer1.Panel1.Controls.Add(this.Moottori);
            this.splitContainer1.Panel1.Controls.Add(this.Malli);
            this.splitContainer1.Panel1.Controls.Add(this.Merkki);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DtcTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.EngineTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ModelTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ManufacturerTextBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(276, 179);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 12;
            // 
            // Importbutton
            // 
            this.Importbutton.Location = new System.Drawing.Point(164, 197);
            this.Importbutton.Name = "Importbutton";
            this.Importbutton.Size = new System.Drawing.Size(75, 23);
            this.Importbutton.TabIndex = 13;
            this.Importbutton.Text = "Import";
            this.Importbutton.UseVisualStyleBackColor = true;
            this.Importbutton.Click += new System.EventHandler(this.Importbutton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 280);
            this.Controls.Add(this.Importbutton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "Add";
            this.Text = "Lisää";
            this.Load += new System.EventHandler(this.Add_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox EngineTextBox;
        private System.Windows.Forms.Label Merkki;
        private System.Windows.Forms.Label Malli;
        private System.Windows.Forms.Label Moottori;
        private System.Windows.Forms.TextBox DtcTextBox;
        private System.Windows.Forms.Label DTC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Importbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}