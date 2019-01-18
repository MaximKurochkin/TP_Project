using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Entities;
using System.Xml;

namespace Services.CashierServices
{
    public class CashierDownloaderService
    { 

        List<CashierModel> cashiers;

        public CashierModel[] Cashiers
        {
            get
            {
                return cashiers.ToArray();
            }
        }

        public CashierDownloaderService()
        {
            cashiers = new List<CashierModel>();
        }

        public void GetListOfCashiers()
        {
            CashiersRep cashiersRep = new CashiersRep();
            cashiers = cashiersRep.GetCashiers();
        }
    }
}
