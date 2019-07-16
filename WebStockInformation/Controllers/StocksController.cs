using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebStockInformation.Models;
using System.Web.Http.Cors;

namespace WebStockInformation.Controllers
{
    public class StocksController : ApiController
    {
       
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        public HttpResponseMessage Get(int id)
        {
           
            
          string cTime = DateTime.Now.ToString();
            string sName = null;
            string sPrice = null;
            if (id== 1)
            {
               sName = "STOCK1";
                Random price = new Random();
                sPrice= price.Next(240, 270).ToString();
                                 
            }
            else if (id== 2)
            {
                sName = "STOCK2";
                Random price = new Random();
                sPrice = price.Next(180, 210).ToString();
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Ambiguous);
            }

            StockModel sM = new StockModel(sName, cTime, sPrice);
            ResponseModel rM = new ResponseModel(sM.getName(), sM.getTime(), sM.getPrice());
            return Request.CreateResponse(HttpStatusCode.OK, rM, "Application/Json");
        }

    }
}
