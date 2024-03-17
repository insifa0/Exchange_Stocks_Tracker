namespace Exchange_Stocks_Tracker
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddNewStock = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioBtnReduce = new System.Windows.Forms.RadioButton();
            this.radioBtnIncrease = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSubstractAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNumberOfStocks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPurchasePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxStockName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dövizSeçenekleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnRefleshStocks = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStocksProfitAndLoss = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.sharesProfitAndLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.radioBtnReduce);
            this.groupBox1.Controls.Add(this.radioBtnIncrease);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxSubstractAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxNumberOfStocks);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxPurchasePrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxStockName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home Page";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 39);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 39);
            this.panel3.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAddNewStock);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(425, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(212, 39);
            this.panel7.TabIndex = 20;
            // 
            // btnAddNewStock
            // 
            this.btnAddNewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewStock.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewStock.Name = "btnAddNewStock";
            this.btnAddNewStock.Size = new System.Drawing.Size(212, 39);
            this.btnAddNewStock.TabIndex = 19;
            this.btnAddNewStock.Text = "New Stock";
            this.btnAddNewStock.UseVisualStyleBackColor = true;
            this.btnAddNewStock.Click += new System.EventHandler(this.btnAddNewStock_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 39);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 39);
            this.panel4.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(212, 39);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Detele";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 39);
            this.panel2.TabIndex = 14;
            // 
            // radioBtnReduce
            // 
            this.radioBtnReduce.AutoSize = true;
            this.radioBtnReduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnReduce.Location = new System.Drawing.Point(298, 195);
            this.radioBtnReduce.Name = "radioBtnReduce";
            this.radioBtnReduce.Size = new System.Drawing.Size(80, 22);
            this.radioBtnReduce.TabIndex = 12;
            this.radioBtnReduce.TabStop = true;
            this.radioBtnReduce.Text = "Reduce";
            this.radioBtnReduce.UseVisualStyleBackColor = true;
            // 
            // radioBtnIncrease
            // 
            this.radioBtnIncrease.AutoSize = true;
            this.radioBtnIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnIncrease.Location = new System.Drawing.Point(205, 195);
            this.radioBtnIncrease.Name = "radioBtnIncrease";
            this.radioBtnIncrease.Size = new System.Drawing.Size(85, 22);
            this.radioBtnIncrease.TabIndex = 11;
            this.radioBtnIncrease.TabStop = true;
            this.radioBtnIncrease.Text = "Increase";
            this.radioBtnIncrease.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of Stocks";
            // 
            // txtBoxSubstractAdd
            // 
            this.txtBoxSubstractAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSubstractAdd.Location = new System.Drawing.Point(205, 162);
            this.txtBoxSubstractAdd.Name = "txtBoxSubstractAdd";
            this.txtBoxSubstractAdd.Size = new System.Drawing.Size(173, 27);
            this.txtBoxSubstractAdd.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subtract / Add";
            // 
            // txtBoxNumberOfStocks
            // 
            this.txtBoxNumberOfStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxNumberOfStocks.Location = new System.Drawing.Point(205, 118);
            this.txtBoxNumberOfStocks.Name = "txtBoxNumberOfStocks";
            this.txtBoxNumberOfStocks.Size = new System.Drawing.Size(173, 27);
            this.txtBoxNumberOfStocks.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stocks Purchase Price \r\n(Average Cost)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPurchasePrice
            // 
            this.txtBoxPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPurchasePrice.Location = new System.Drawing.Point(205, 72);
            this.txtBoxPurchasePrice.Name = "txtBoxPurchasePrice";
            this.txtBoxPurchasePrice.Size = new System.Drawing.Size(173, 27);
            this.txtBoxPurchasePrice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock Names";
            // 
            // txtBoxStockName
            // 
            this.txtBoxStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxStockName.Location = new System.Drawing.Point(205, 30);
            this.txtBoxStockName.Name = "txtBoxStockName";
            this.txtBoxStockName.Size = new System.Drawing.Size(173, 27);
            this.txtBoxStockName.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sharesProfitAndLossToolStripMenuItem,
            this.dövizSeçenekleriToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dövizSeçenekleriToolStripMenuItem
            // 
            this.dövizSeçenekleriToolStripMenuItem.Name = "dövizSeçenekleriToolStripMenuItem";
            this.dövizSeçenekleriToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.dövizSeçenekleriToolStripMenuItem.Text = "Döviz Seçenekleri";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBoxButtons.Controls.Add(this.lblStocksProfitAndLoss);
            this.groupBoxButtons.Controls.Add(this.label6);
            this.groupBoxButtons.Controls.Add(this.btnChart);
            this.groupBoxButtons.Controls.Add(this.btnRefleshStocks);
            this.groupBoxButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxButtons.Location = new System.Drawing.Point(0, 354);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(643, 92);
            this.groupBoxButtons.TabIndex = 2;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Buttons";
            // 
            // btnChart
            // 
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChart.Location = new System.Drawing.Point(449, 21);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(182, 58);
            this.btnChart.TabIndex = 1;
            this.btnChart.Text = "Charts";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnRefleshStocks
            // 
            this.btnRefleshStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefleshStocks.Location = new System.Drawing.Point(263, 21);
            this.btnRefleshStocks.Name = "btnRefleshStocks";
            this.btnRefleshStocks.Size = new System.Drawing.Size(180, 58);
            this.btnRefleshStocks.TabIndex = 0;
            this.btnRefleshStocks.Text = "Reflesh the Stocks";
            this.btnRefleshStocks.UseVisualStyleBackColor = true;
            this.btnRefleshStocks.Click += new System.EventHandler(this.btnRefleshStocks_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Şuanki total kar zarar durumu.";
            // 
            // lblStocksProfitAndLoss
            // 
            this.lblStocksProfitAndLoss.AutoSize = true;
            this.lblStocksProfitAndLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStocksProfitAndLoss.Location = new System.Drawing.Point(60, 45);
            this.lblStocksProfitAndLoss.Name = "lblStocksProfitAndLoss";
            this.lblStocksProfitAndLoss.Size = new System.Drawing.Size(42, 25);
            this.lblStocksProfitAndLoss.TabIndex = 16;
            this.lblStocksProfitAndLoss.Text = "null";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Location = new System.Drawing.Point(212, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 39);
            this.panel5.TabIndex = 22;
            // 
            // sharesProfitAndLossToolStripMenuItem
            // 
            this.sharesProfitAndLossToolStripMenuItem.Name = "sharesProfitAndLossToolStripMenuItem";
            this.sharesProfitAndLossToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.sharesProfitAndLossToolStripMenuItem.Text = "Shares Profit And Loss";
            this.sharesProfitAndLossToolStripMenuItem.Click += new System.EventHandler(this.sharesProfitAndLossToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 446);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Exchange Stocks Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxButtons.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dövizSeçenekleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSubstractAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNumberOfStocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPurchasePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxStockName;
        private System.Windows.Forms.RadioButton radioBtnReduce;
        private System.Windows.Forms.RadioButton radioBtnIncrease;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddNewStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnRefleshStocks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStocksProfitAndLoss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem sharesProfitAndLossToolStripMenuItem;
    }
}

