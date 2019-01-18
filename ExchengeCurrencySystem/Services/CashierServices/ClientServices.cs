using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Entities;
using System.Text.RegularExpressions;

namespace Services.CashierServices
{
    public class ClientServices
    {
        ClientRep clientRep = new ClientRep();

        public Client TryToFindClientInFile(string pasport)
        { 
            Client client = clientRep.SearchClientInFile(pasport);

            return client;
        }

        private string[] currencies = { "BYN", "RUB", "EUR", "USD", "JPU", "GBR", "CHF" };

        public void CreateClient(string name, string surname, string pasport)
        {
            Client client = new Client();
            client.Name = name;
            client.Surname = surname;
            client.Pasport = pasport;

            string defaultValue = "0";
            for (int i = 0; i < currencies.Length; i++)
            {
                client.SoldCurrency.Add(currencies[i], defaultValue);
                client.PurchasedCurrency.Add(currencies[i], defaultValue);
            }

            clientRep.AddClient(client);
        }

        public bool ToCheckClientInfForCorrect(string clientName, string clientSurname)
        {
            bool isDataCorrect = true;
            Regex regex = new Regex("[А-я0-9]");
            if (regex.IsMatch(clientName) || regex.IsMatch(clientSurname))
            {
                isDataCorrect = false;
            }
            return isDataCorrect;
        }

        public bool TryToFindClient(string clientPassport)
        {
            bool clientExist = false;
            if (clientRep.PassportExist(clientPassport))
            {
                clientExist = true;
            }
            return clientExist;
        }

        public bool ToUpdateClientInf(string passport, string currencyForSale, string valueForSale,
                                    string currencyForBuy, string valueForBuy)
        {
            bool clientInfIsUpdate = false;

            Client client = new Client();
            client = clientRep.SearchClientInFile(passport);

            double saleValue = Convert.ToDouble(valueForSale);
            double purchValue = Convert.ToDouble(valueForBuy);

            double originSale = Convert.ToDouble(client.SoldCurrency[currencyForSale]);
            double originPurch = Convert.ToDouble(client.PurchasedCurrency[currencyForBuy]);

            double updateSale = saleValue + originSale;
            double updatePurch = purchValue + originPurch;

            client.SoldCurrency[currencyForSale] = updateSale.ToString();
            client.PurchasedCurrency[currencyForBuy] = updatePurch.ToString();

            clientInfIsUpdate = clientRep.UpdateInf(client, currencyForSale, currencyForBuy);

            return clientInfIsUpdate;
        }
    }
}
