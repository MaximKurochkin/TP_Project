using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Services.AdminServices;
using Entities;

namespace Presenters.AdminPresenters
{
    public class AdminPresenter
    {
        RatesService ratesService = new RatesService();
        RestrictionsService restrictionsService = new RestrictionsService();
        CashierService cashierService = new CashierService();
        FinishDayService finishDayService = new FinishDayService();

        public Dictionary<string, string> GetSaleRates()
        {
            Dictionary<string, string> salesRates = ratesService.ToGetSaleRates();
            return salesRates;
        }

        public Dictionary<string, string> GetPurchRates()
        {
            Dictionary<string, string> purchRates = ratesService.ToGetPurchRates();
            return purchRates;
        }

        public void SaveSaleRates(Dictionary<string, string> saleRates)
        {
            ratesService.ToSaveSaleRates(saleRates);
        }

        public void SavePurchRates(Dictionary<string, string> purchRates)
        {
            ratesService.ToSavePurchRates(purchRates);
        }

        public Dictionary<string, string> GetRestrictions()
        {
            Dictionary<string, string> restrictions = restrictionsService.ToGetRestrictions();
            return restrictions;
        }

        public void SaveRestrictions(Dictionary<string, string> restrictions)
        {
            restrictionsService.SetRestrictions(restrictions);
        }

        public List<CashierModel> GetCashiers()
        {
            List<CashierModel> cashiers = cashierService.GetListOfCashiers();
            return cashiers;
        }

        public CashierModel GetWorkingCashier()
        {
            CashierModel workingCashier = cashierService.ToGetWorkingCashier();
            return workingCashier;
        }

        public void SetCashier(string nameSurnameCashier, CashierModel workingCashier)
        {
            cashierService.SetCashierAsCurrentWorker(nameSurnameCashier, workingCashier);
        }

        public bool ToTransferCashierInfForCorrect(string name, string surname)
        {
            return cashierService.ToCheckCashierInfForCorrect(name, surname);
        }

        public void CreateNoteAboutNewCashier(string name, string surname, string passport)
        {
            cashierService.CreateCashier(name, surname, passport);
        }

        public void DeleteCashier(string nameSurnameCashier)
        {
            cashierService.ToDelete(nameSurnameCashier);
        }

        public void ToFinishDay()
        {
            finishDayService.ToFinish();
        }
    }
}
