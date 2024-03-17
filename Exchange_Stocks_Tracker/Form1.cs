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
        public Main()
        {
            InitializeComponent();
            LoadShareListFromFile();

        }

        //finance.yahoo // I pull share prices from the following site and this is the path in HTML
        private static string stockPriceXpath = "//div[@class='D(ib) Mend(20px)']//fin-streamer[@data-field='regularMarketPrice']";
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

                    label5.Text = stockName + ": " + stockPriceNode + " TL";

                    // ******* TO DO **********
                    //Hisse kar zarar fonksiyonu yap
                    

                    // Check if stock is already in the list
                    StockClass existingStock = allStocks.FirstOrDefault(s => s.stockName == stockName);

                    if (existingStock != null)
                    {
                        //Update existing stock price
                        existingStock.stockPrice = stockPriceDouble;
                        MessageBox.Show($"'{stockName}' updated now.");
                    }
                    else
                    {
                        // Add new stock to the list
                        int stockValue = Convert.ToInt32(txtBoxNumberOfStocks.Text);
                        allStocks.Add(new StockClass { stockName = stockName, stockPrice = stockPriceDouble, stockPurchasePrice = purchasePrice, stockValue = stockValue });
                    }                    
                    // Save updated list to "StocksJson.json"
                    SaveShareListToFile();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string stockName = txtBoxStockName.Text;
            DeleteHisseFromList(stockName);
        }

        ///  TO DO
        //Hisse kar zarar fonksiyonunu buraya yaz
        /* 
        public void stocksProfitAndLoss() {
            stocksProfitAndLoss    
            for each döngüsü ile tüm hisse değerlerini topla
            sonra alış fiyatlarını topla
            en son buraya yapıştır.
        }
        */
        public void stocksProfitAndLoss()
        {
            double totalSharePrice = 0;

            foreach (StockClass stock in allStocks)
            {
                totalSharePrice += stock.stockPrice * stock.stockValue;
            }

            string totalSharePriceStr = totalSharePrice.ToString();
            lblStocksProfitAndLoss.Text = $"{totalSharePriceStr} TL";
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
        private void SaveShareListToFile()
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(allStocks, Formatting.Indented);
                System.IO.File.WriteAllText("StocksJson.json", jsonString);
                stocksProfitAndLoss();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error in not being able to write to the share list file: {ex.Message}");
            }
        }

        // Delete from Json file
        private void DeleteHisseFromList(string stockName)
        {
            int index = allStocks.FindIndex(s => s.stockName == stockName);

            if (index != -1)
            {
                allStocks.RemoveAt(index);
                MessageBox.Show($"'{stockName}' share was successfully deleted.");
                SaveShareListToFile();
            }
            else
            {
                MessageBox.Show($"'{stockName}' share didn't find in the list.");
            }
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
            stocksProfitAndLoss();
        }

        private void sharesProfitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stocksProfitAndLoss();
        }

        /* 
        public void refleshAllShares() {
            refleshAllShares    
            for each döngüsü ile tüm hisse isimlerini al
            sonra hisselerin sadece fiyatlarını güncelle
            sonra dataGrid aç

        }
        */
        // ********** TO DO *********
        // update fonksiyonun adını güncelle
        // ve value of the share, amount of the share isimlerini kullan
        // This method updates the prices of all shares in the list.
        public void updateAllSharesFiyat()
        {
            foreach (StockClass share in allStocks)
            {                                
                takeTheValueOfShare(share); // Update the price of each share
            }
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
                    SaveShareListToFile();                    
                }
                else
                {
                    MessageBox.Show("No elements matching the specified XPath expression were found.");
                }
                // For example, you might want to update a DataGridView here
                stocksProfitAndLoss();
                // This code will open the ChartForm.
                ChartForm chartForm = new ChartForm();
                chartForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred while updating '{share.stockName}' stock price: {ex.Message}");
            }
        }
    }
}
