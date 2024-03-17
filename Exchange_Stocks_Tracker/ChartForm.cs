using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Exchange_Stocks_Tracker
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            reflesTheAllShares();
        }

        private void reflesTheListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reflesTheAllShares();
        }

        private void reflesTheAllShares() {
            try
            {
                // Read the JSON file and deserialize the content as a list
                string json = System.IO.File.ReadAllText("StocksJson.json");
                List<StockClass> allStocks = JsonConvert.DeserializeObject<List<StockClass>>(json);

                // Show by assigning list data to the DataSource property of the DataGridView control
                dataGridStocks.DataSource = allStocks;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data reading error: " + ex.Message);
            }
        }
    }
}
