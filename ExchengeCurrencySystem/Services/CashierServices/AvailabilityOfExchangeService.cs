using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Entities;
namespace Services.CashierServices
{
    public class AvailabilityOfExchangeService
    {
        public bool CanBuy(string passport, string valueForBuy, string currencyForBuy)
        {
            RestrictionsRep restrictions = new RestrictionsRep();
            ClientRep clientRep = new ClientRep();
            Client client = new Client();

            double currencyRestriction = restrictions.GetCurrencyRestriction(currencyForBuy);

            client = clientRep.SearchClientInFile(passport);
            double purchCurrency = Convert.ToDouble(client.PurchasedCurrency[currencyForBuy]);
            double value = Convert.ToDouble(valueForBuy);

            double valueAfterPurch = value + purchCurrency;

            double availableValue = currencyRestriction - valueAfterPurch;
            if ( availableValue > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanSale(string passport, string valueForSale, string currencyForSale)
        {
            RestrictionsRep restrictions = new RestrictionsRep();
            ClientRep clientRep = new ClientRep();
            Client client = new Client();

            double currencyRestriction = restrictions.GetCurrencyRestriction(currencyForSale);
           
            client = clientRep.SearchClientInFile(passport);
            double saleCurrency = Convert.ToDouble(client.SoldCurrency[currencyForSale]);
            double value = Convert.ToDouble(valueForSale);

            double valueAfterSale = value + saleCurrency;

            double availableValue = currencyRestriction - valueAfterSale;
            if (availableValue > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
