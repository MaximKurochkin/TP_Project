using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Presenters.CashierPresenters
{
    public class RatesPresenter
    {
        RatesService ratesService = new RatesService();

        public Dictionary<string, string> GetSaleRates(string currency)
        {
            Dictionary<string, string> rates = ratesService.ToGetSaleRates(currency);
            return rates;
        }

        public Dictionary<string, string> GetPurchRates(string currency)
        {
            Dictionary<string, string> rates = ratesService.ToGetPurchRates(currency);
            return rates;
        }

    }
}
