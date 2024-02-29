using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InfoCarApi.Controllers
{
    public class CarInfoController : ApiController
    {
        [Route("api/GetInfo/{carName}")]
        public decimal GetInfo(string carName)
        {   // we create an instance of the dbContext
            using (ApiCarsInfoDBEntities db = new ApiCarsInfoDBEntities())
            {
                decimal returnThisToClient = (decimal)db.InfoCarTbls.FirstOrDefault(s => s.InfoCarName == carName).Price;
                return returnThisToClient;
            }           
        }
      //public InfoCarTbl Get()

    }
}
