using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Stocks_Tracker
{
    public class StockClass
    {
        public string stockName { get; set; }
        public double stockPrice { get; set; } // Hissenin güncel değeri.
        public double stockPurchasePrice { get; set; }
        public int stockValue { get; set; } //Number of shares you own. 
    }
}


