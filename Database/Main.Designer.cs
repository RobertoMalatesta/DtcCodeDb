namespace Database
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturersListBox = new System.Windows.Forms.ListBox();
            this.modelsListbox = new System.Windows.Forms.ListBox();
            this.engineListbox = new System.Windows.Forms.ListBox();
            this.dtcListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.carObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autotGridView = new System.Windows.Forms.DataGridView();
            this.autotListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostotToolStripMenuItem
            // 
            this.tiedostotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisääToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.muokkaaToolStripMenuItem});
            this.tiedostotToolStripMenuItem.Name = "tiedostotToolStripMenuItem";
            this.tiedostotToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tiedostotToolStripMenuItem.Text = "Tiedostot";
            // 
            // lisääToolStripMenuItem
            // 
            this.lisääToolStripMenuItem.Name = "lisääToolStripMenuItem";
            this.lisääToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.lisääToolStripMenuItem.Text = "Lisää";
            this.lisääToolStripMenuItem.Click += new System.EventHandler(this.lisääToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // muokkaaToolStripMenuItem
            // 
            this.muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            this.muokkaaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.muokkaaToolStripMenuItem.Text = "Muokkaa";
            this.muokkaaToolStripMenuItem.Click += new System.EventHandler(this.muokkaaToolStripMenuItem_Click);
            // 
            // manufacturersListBox
            // 
            this.manufacturersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturersListBox.FormattingEnabled = true;
            this.manufacturersListBox.ItemHeight = 20;
            this.manufacturersListBox.Location = new System.Drawing.Point(15, 67);
            this.manufacturersListBox.Name = "manufacturersListBox";
            this.manufacturersListBox.Size = new System.Drawing.Size(148, 184);
            this.manufacturersListBox.TabIndex = 2;
            this.manufacturersListBox.SelectedIndexChanged += new System.EventHandler(this.manufacturersListBox_SelectedIndexChanged);
            // 
            // modelsListbox
            // 
            this.modelsListbox.DisplayMember = "Model";
            this.modelsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelsListbox.FormattingEnabled = true;
            this.modelsListbox.ItemHeight = 20;
            this.modelsListbox.Location = new System.Drawing.Point(169, 67);
            this.modelsListbox.Name = "modelsListbox";
            this.modelsListbox.Size = new System.Drawing.Size(148, 184);
            this.modelsListbox.TabIndex = 3;
            this.modelsListbox.SelectedIndexChanged += new System.EventHandler(this.modelsListbox_SelectedIndexChanged);
            // 
            // engineListbox
            // 
            this.engineListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineListbox.FormattingEnabled = true;
            this.engineListbox.ItemHeight = 20;
            this.engineListbox.Location = new System.Drawing.Point(324, 68);
            this.engineListbox.Name = "engineListbox";
            this.engineListbox.Size = new System.Drawing.Size(148, 184);
            this.engineListbox.TabIndex = 4;
            this.engineListbox.SelectedIndexChanged += new System.EventHandler(this.engineListbox_SelectedIndexChanged);
            // 
            // dtcListbox
            // 
            this.dtcListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcListbox.FormattingEnabled = true;
            this.dtcListbox.ItemHeight = 20;
            this.dtcListbox.Location = new System.Drawing.Point(479, 68);
            this.dtcListbox.Name = "dtcListbox";
            this.dtcListbox.Size = new System.Drawing.Size(339, 184);
            this.dtcListbox.TabIndex = 5;
            this.dtcListbox.SelectedIndexChanged += new System.EventHandler(this.dtcListbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valmistaja :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Malli :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Moottori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vika:";
            // 
            // resultPanel
            // 
            this.resultPanel.Location = new System.Drawing.Point(18, 279);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(800, 335);
            this.resultPanel.TabIndex = 7;
            this.resultPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.resultPanel_Paint);
            // 
            // carObjectBindingSource
            // 
            this.carObjectBindingSource.DataSource = typeof(Backend.Objects.DtcCodeObject);
            // 
            // autotGridView
            // 
            this.autotGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autotGridView.Location = new System.Drawing.Point(825, 67);
            this.autotGridView.Name = "autotGridView";
            this.autotGridView.Size = new System.Drawing.Size(240, 150);
            this.autotGridView.TabIndex = 8;
            // 
            // autotListBox
            // 
            this.autotListBox.FormattingEnabled = true;
            this.autotListBox.Location = new System.Drawing.Point(837, 238);
            this.autotListBox.Name = "autotListBox";
            this.autotListBox.Size = new System.Drawing.Size(120, 95);
            this.autotListBox.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 626);
            this.Controls.Add(this.autotListBox);
            this.Controls.Add(this.autotGridView);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtcListbox);
            this.Controls.Add(this.engineListbox);
            this.Controls.Add(this.modelsListbox);
            this.Controls.Add(this.manufacturersListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Vika Pankki";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autotGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisääToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource carObjectBindingSource;
        private System.Windows.Forms.ListBox manufacturersListBox;
        private System.Windows.Forms.ListBox modelsListbox;
        private System.Windows.Forms.ListBox engineListbox;
        private System.Windows.Forms.ListBox dtcListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.ToolStripMenuItem muokkaaToolStripMenuItem;
        private System.Windows.Forms.DataGridView autotGridView;
        private System.Windows.Forms.ListBox autotListBox;
    }
}