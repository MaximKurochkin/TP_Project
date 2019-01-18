using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Entities;

namespace Services.CashierServices
{
    public class CashierLoginService
    {
        CashiersRep cashiersRep = new CashiersRep();

        public void SetCashierAsCurrentWorker(string nameSurnameCashier)
        {
            string cashierName = GetCashierName(nameSurnameCashier);
            string cashierSurname = GetCashierSurname(nameSurnameCashier);

            CashierModel cashier = new CashierModel(cashierName, cashierSurname, string.Empty, string.Empty);

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

        public void ToFinishWork()
        {
            CashierModel cashier = cashiersRep.GetWorkingCashier();
            cashier.OnWork = "No";
            cashiersRep.ToMackCashierUnwork(cashier);
        }
    }
}
