using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.CashierServices;
using Entities;

namespace Presenters.CashierPresenters
{
    public class CashierWorkPresenter
    {
        ClientServices clientService = new ClientServices();
        ConvertationService convertation = new ConvertationService();
        AvailabilityOfExchangeService availabilityOfExchange = new AvailabilityOfExchangeService();
        CashierLoginService loginService = new CashierLoginService();
        

        public bool ToTransferClientInfForCorrect(string clientName, string clientSurname)
        {
            return clientService.ToCheckClientInfForCorrect(clientName, clientSurname);
        }

        public Client ToGetInfAboutClient (string pasport)
        {
            Client client = clientService.TryToFindClientInFile(pasport);
            return client;
        }

        public void CreateNoteAboutNewClient(string name, string surname, string pasport)
        {
            clientService.CreateClient(name, surname, pasport);
        }

        public string ConvertationForBuy(string currencyForSale, string currencyForBuy, string value)
        {
            string convertValue = convertation.ToConvertValueForBuy(currencyForSale, currencyForBuy, value);
            return convertValue;
        }

        public string ConvertationForSale(string currencyForSale, string currencyForBuy, string value)
        {
            string convertValue = convertation.ToConvertValueForSale(currencyForSale, currencyForBuy, value);
            return convertValue;
        }

        public bool PurchLimit(string clientPasport, string valueForBuy, string currencyForBuy)
        {
            
            bool purchLimitIsNotReached = true;
            purchLimitIsNotReached = availabilityOfExchange.CanBuy(clientPasport, valueForBuy, currencyForBuy);
            return purchLimitIsNotReached;
        }

        public bool SaleLimit(string clientPasport, string valueForSale, string currencyForSale)
        {
            bool salelimitIsNotReached = false;
            salelimitIsNotReached = availabilityOfExchange.CanSale(clientPasport, valueForSale, currencyForSale);
            return salelimitIsNotReached;
        }

        public bool CheckClientPassport(string clientPassport)
        {
            bool clientExist = false;
            clientExist = clientService.TryToFindClient(clientPassport);
            return clientExist;
        }

        public bool UpdateClientInf(string passport, string currencyForSale, string valueForSale,
                                    string currencyForBuy, string valueForBuy)
        {
            return clientService.ToUpdateClientInf(passport, currencyForSale, valueForSale, currencyForBuy, valueForBuy);
        }

        public void XmlNoteMaker (string name, string surname, string passport, string currencyForSale, 
                                  string valueForSale, string currencyForBuy, string valueForBuy)
        {
            convertation.ToMakeNoteInHistory(name, surname, passport, currencyForSale,
                                  valueForSale, currencyForBuy, valueForBuy);
        }

        public void CheckMaker(string name, string surname, string passport, string currencyForSale,
                                  string valueForSale, string currencyForBuy, string valueForBuy)
        {
            convertation.ToMakeCheck(name, surname, passport, currencyForSale,
                                  valueForSale, currencyForBuy, valueForBuy);
        }

        public void WorkFinish()
        {
            loginService.ToFinishWork();
        }
    }
}
