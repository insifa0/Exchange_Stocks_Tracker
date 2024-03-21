using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;

namespace Exchange_Stocks_Tracker
{
    public partial class Main : Form
    {
        HtmlWeb htmlStock = new HtmlWeb();
        private List<StockClass> allStocks = new List<StockClass>();
        private Form activeForm;
        double totalStocksProfit;        
        public Main()
        {
            InitializeComponent();
            LoadShareListFromFile();
        }

        //finance.yahoo // I pull share prices from the following site and this is the path in HTML
        private const string stockPriceXpath = "//div[@class='D(ib) Mend(20px)']//fin-streamer[@data-field='regularMarketPrice']";
        string stockName;
        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            stockName = txtBoxStockName.Text.ToUpper();
            try
            {
                string stockGraphLink = "https://finance.yahoo.com/quote/" + stockName + ".IS?p=" + stockName + ".IS&.tsrc=fin-srch";
                HtmlAgilityPack.HtmlDocument document = htmlStock.Load(stockGraphLink);

                // Using XPath expressions
                var stockPriceNode = document.DocumentNode.SelectSingleNode(stockPriceXpath).InnerText.Replace(".", ",");

                if (stockPriceNode != null)
                {
                    double stockPriceDouble = Convert.ToDouble(stockPriceNode);
                    double purchasePrice = Convert.ToDouble(txtBoxPurchasePrice.Text.Replace(".", ","));

                    lblCurrentStock.Text = stockName + ": " + stockPriceNode + " TL";                                                         

                    // Check if stock is already in the list
                    StockClass existingStock = allStocks.FirstOrDefault(s => s.stockName == stockName);

                    if (existingStock != null)
                    {
                        //Update existing stock price
                        existingStock.stockPrice = stockPriceDouble;
                        MessageBox.Show($"'{stockName}' is exist in the list. You don't need to add again");
                        MessageBox.Show($"'{stockName}' price updated now.");
                    }
                    else
                    {
                        // Add new stock to the list
                        int stockValue = Convert.ToInt32(txtBoxNumberOfStocks.Text);
                        allStocks.Add(new StockClass { stockName = stockName, stockPrice = stockPriceDouble, stockPurchasePrice = purchasePrice, stockValue = stockValue, stockProfit = stockValue * purchasePrice });
                    }
                    // Save updated list to "StocksJson.json"
                    SaveStocksListToFile();

                }
                else
                {
                    MessageBox.Show("No elements matching the specified XPath expression were found.");
                }
            }
            catch (Exception ex)
            {
                if (stockName == "")
                {
                    MessageBox.Show("You forgot to write the name of the stock!");
                }
                else
                {
                    MessageBox.Show($"An error has occurred: {ex.Message}");
                }
            }
        }


        public void allStocksConsPors() {
            double totalStocksProfit = allStocks.Sum(stock => (stock.stockPrice - stock.stockPurchasePrice) * stock.stockValue);
            lblTotalProfit.Text = $"Current total profit and loss situation: {totalStocksProfit:N2}";
        }

        public void totalStocksValue() // toplam hiisse hesabındaki para
        {
            double totalSharePrice = allStocks.Sum(stock => stock.stockPrice * stock.stockValue);
            lblTotalStocksValue.Text = $"{totalSharePrice:N2} TL";
            SaveStocksListToFile();
        }

        //Loads the table from a JSON file.
        private void LoadShareListFromFile()
        {
            try
            {
                if (System.IO.File.Exists("StocksJson.json"))
                {
                    string jsonString = System.IO.File.ReadAllText("StocksJson.json");
                    allStocks = JsonConvert.DeserializeObject<List<StockClass>>(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Share list file could not be read: {ex.Message}");
            }
        }

        // Saving to a JSON file
        private void SaveStocksListToFile()
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(allStocks, Formatting.Indented);
                System.IO.File.WriteAllText("StocksJson.json", jsonString);
                //UpdateStockInfo(); // Burada yeni metod çağrılıyor
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error in not being able to write to the share list file: {ex.Message}");
            }
        }

        private void SaveShareListToFile2()
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(allStocks, Formatting.Indented);
                System.IO.File.WriteAllText("StocksJson.json", jsonString);                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error in not being able to write to the share list file: {ex.Message}");
            }
        }

        // Delete from Json file
        private void DeleteStockFromList(string stockName)
        {
            int index = allStocks.FindIndex(s => s.stockName == stockName);

            if (index != -1)
            {
                allStocks.RemoveAt(index);
                MessageBox.Show($"'{stockName}' share was successfully deleted.");
                SaveStocksListToFile();
            }
            else
            {
                MessageBox.Show($"'{stockName}' share didn't find in the list.");
            }
        }

        // ve value of the share, amount of the share isimlerini kullan
        // This method updates the prices of all shares in the list.
        public void updateAllSharesFiyat()
        {
            foreach (StockClass share in allStocks)
            {
                takeTheValueOfShare(share); // Update the price of each share
            }
            // For example, you might want to update a DataGridView here
            totalStocksValue();
            // This code will open the ChartForm.
            ChartForm chartForm = new ChartForm();
            chartForm.Show();
        }

        // This method retrieves the price of a specific share.
        // This method updates the price of a specific share.
        public void takeTheValueOfShare(StockClass share)
        {
            try
            {
                // Construct the URL to fetch the share price from Yahoo Finance
                string stockGraphLink = "https://finance.yahoo.com/quote/" + share.stockName + ".IS?p=" + share.stockName + ".IS&.tsrc=fin-srch";
                HtmlAgilityPack.HtmlDocument document = htmlStock.Load(stockGraphLink);

                // Using XPath expressions to extract the stock price from the HTML
                var stockPriceNode = document.DocumentNode.SelectSingleNode(stockPriceXpath)?.InnerText.Replace(".", ",");

                if (!string.IsNullOrEmpty(stockPriceNode))
                {
                    double stockPriceDouble = Convert.ToDouble(stockPriceNode);

                    // Update the share price
                    share.stockPrice = stockPriceDouble;
                    MessageBox.Show($"'{share.stockName}' updated now.");

                    // Save the updated list
                    SaveStocksListToFile();                    
                }
                else
                {
                    MessageBox.Show("No elements matching the specified XPath expression were found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred while updating '{share.stockName}' stock price: {ex.Message}");
            }
        }

        bool sell;
        private void stockBuy(string stockName)
        {
            StockClass existingStock = allStocks.FirstOrDefault(s => s.stockName == stockName);            
            try
            {
                if (existingStock != null)
                {
                    // Update existing stock price
                    if (sell == false)
                    {
                        double oldStockDeger = existingStock.stockValue * existingStock.stockPurchasePrice;
                        int addNumberOfStock = Convert.ToInt32(txtBoxSubstractAdd.Text);
                        existingStock.stockValue += addNumberOfStock;
                        int purchasePrice = Convert.ToInt32(txtBoxPurchasePrice.Text);
                        double addedStockDeger = (purchasePrice * addNumberOfStock) + oldStockDeger;
                        existingStock.stockProfit = existingStock.stockValue * existingStock.stockPrice;
                        existingStock.stockPurchasePrice = (addedStockDeger / existingStock.stockValue);
                    }
                    else if (sell == true)
                    {
                        existingStock.stockValue -= Convert.ToInt32(txtBoxSubstractAdd.Text);
                        existingStock.stockProfit = existingStock.stockValue * existingStock.stockPrice;                        
                    }
                    MessageBox.Show($"'{stockName}' updated now.");
                    SaveStocksListToFile();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
        public void UpdateStockInfo()
        {
            allStocksConsPors();
            totalStocksValue();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            sell = false;
            stockBuy(txtBoxStockName.Text.ToUpper());
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            sell = true;
            stockBuy(txtBoxStockName.Text.ToUpper());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStockFromList(txtBoxStockName.Text.ToUpper());
        }

        // Show DataGird
        private void btnChart_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            chartForm.Show();
        }

        private void btnRefleshStocks_Click(object sender, EventArgs e)
        {
            updateAllSharesFiyat();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalStocksValue();
        }

        private void sharesProfitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStockInfo();
        }
    }
}