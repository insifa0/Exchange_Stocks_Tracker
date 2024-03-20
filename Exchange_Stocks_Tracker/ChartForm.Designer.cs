namespace Exchange_Stocks_Tracker
{
    partial class ChartForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reflesTheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dövizSeçenekleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridStocks = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reflesTheListToolStripMenuItem,
            this.dövizSeçenekleriToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reflesTheListToolStripMenuItem
            // 
            this.reflesTheListToolStripMenuItem.Name = "reflesTheListToolStripMenuItem";
            this.reflesTheListToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.reflesTheListToolStripMenuItem.Text = "Update Share Prices";
            this.reflesTheListToolStripMenuItem.Click += new System.EventHandler(this.reflesTheListToolStripMenuItem_Click);
            // 
            // dövizSeçenekleriToolStripMenuItem
            // 
            this.dövizSeçenekleriToolStripMenuItem.Name = "dövizSeçenekleriToolStripMenuItem";
            this.dövizSeçenekleriToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.dövizSeçenekleriToolStripMenuItem.Text = "Döviz Seçenekleri";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataGridStocks
            // 
            this.dataGridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStocks.Location = new System.Drawing.Point(0, 30);
            this.dataGridStocks.Name = "dataGridStocks";
            this.dataGridStocks.RowHeadersWidth = 51;
            this.dataGridStocks.RowTemplate.Height = 24;
            this.dataGridStocks.Size = new System.Drawing.Size(685, 420);
            this.dataGridStocks.TabIndex = 5;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.dataGridStocks);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dövizSeçenekleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflesTheListToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridStocks;
    }
}