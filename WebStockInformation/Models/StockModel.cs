using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStockInformation.Models
{
    public class StockModel
    {
        private string _stockName;
        private string _currentTime;
        private string _stockPrice;


        public StockModel(string sName, string cTime, string sPrice)
        {
            this._stockName = sName;
            this._currentTime = cTime;
            this._stockPrice = sPrice;
        }

        public string getName() { return this._stockName; }
        public string getTime() { return this._currentTime; }
        public string getPrice() { return this._stockPrice; }
    }
    public class ResponseModel{

    public string stockName;
    public string currentTime;
    public string stockPrice;

        public ResponseModel(string sName, string cTime, string sPrice)
        {
            this.stockName = sName;
            this.currentTime = cTime;
            this.stockPrice = sPrice;
        }
    }
}