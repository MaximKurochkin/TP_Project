using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services.AdminServices
{
    public class CashierService
    {
        CashiersRep cashiersRep = new CashiersRep();

        public List<CashierModel> GetListOfCashiers()
        {
            List<CashierModel> cashiers = cashiersRep.GetCashiers();
            return cashiers;
        }

        public CashierModel ToGetWorkingCashier()
        {
            return cashiersRep.GetWorkingCashier();
        }

        public void SetCashierAsCurrentWorker(string nameSurnameCashier, CashierModel workingCashier)
        {
            string cashierName = GetCashierName(nameSurnameCashier);
            string cashierSurname = GetCashierSurname(nameSurnameCashier);

            CashierModel cashier = new CashierModel(cashierName, cashierSurname, string.Empty, string.Empty);
            cashiersRep.ToMackCashierUnwork(workingCashier);
            cashiersRep.SetCashierWorking(cashier);
        }

        private string GetCashierName(string nameSurnameCashier)
        {
            StringBuilder cashierName = new StringBuilder();

            int startIndOfName = nameSurnameCashier.IndexOf(' ') + 1;
            for (int i = startIndOfName; i < nameSurnameCashier.Length; i++)
            {
                cashierName.Append(nameSurnameCashier[i]);
            }
            return cashierName.ToString();
        }

        private string GetCashierSurname(string nameSurnameCashier)
        {
            StringBuilder cashierSurname = new StringBuilder();

            for (int i = 0; nameSurnameCashier[i] != ' '; i++)
            {
                cashierSurname.Append(nameSurnameCashier[i]);
            }
            return cashierSurname.ToString();
        }

        public bool ToCheckCashierInfForCorrect(string name, string surname)
        {
            bool isDataCorrect = true;
            Regex regex = new Regex("[A-z0-9]");
            if (regex.IsMatch(name) || regex.IsMatch(surname))
            {
                isDataCorrect = false;
            }
            return isDataCorrect;
        }

        public void CreateCashier(string name, string surname, string passport)
        {
            CashierModel cashier = new CashierModel(name, surname,passport, "No");
            cashiersRep.AddCashier(cashier);
        }

        public void ToDelete(string nameSurnameCashier)
        {
            string name = GetCashierName(nameSurnameCashier);
            string surname = GetCashierSurname(nameSurnameCashier);
            CashierModel cashier = new CashierModel(name, surname, null, null);
            cashiersRep.DeleteCashier(cashier);
        }
    }
}
