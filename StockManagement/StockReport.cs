using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class StockReport
    {
        public List<Stock> stock;
      
    }
    public class Stock
    {
        public string stockName;
        public int stockPrice;
        public int totalShare;
    }
}
