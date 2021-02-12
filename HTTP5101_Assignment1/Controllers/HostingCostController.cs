using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HostingCostController : ApiController
    {
        // GET api/hostingcost/id
        public IEnumerable<string> Get(int id)
        {
            double fortnights;
            double daysFortnight = 14;
            fortnights = (id % 365) / daysFortnight;
            double finalFornights = Math.Round(fortnights, 2);
            double accomodation = 5.5 * fortnights;
            double hst = 0.13 * accomodation;
            double subTotal = accomodation + hst;
            double finalAcc = Math.Round(accomodation, 2);
            double finalhst = Math.Round(hst, 2);
            double total = Math.Round(subTotal, 2);

            return new string[] { finalFornights + " fortnights at $5.50/FN = $" + finalAcc + " CAD", "HST 13% = $" + finalhst + " CAD", "Total = $" + total + " CAD" };
        }
    }
}