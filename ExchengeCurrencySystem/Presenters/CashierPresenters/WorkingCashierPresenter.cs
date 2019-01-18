using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.CashierServices;

namespace Presenters.CashierPresenters
{
    public class WorkingCashierPresenter
    {
        public CashierLoginService cashierLoginService;

        public WorkingCashierPresenter()
        {
            cashierLoginService = new CashierLoginService();
        }

        public CashierLoginService CashierLoginService
        {
            get
            {
                return cashierLoginService;
            }
        }

        public void EnterAsCashier(string nameSurnameCashier)
        {
            CashierLoginService.SetCashierAsCurrentWorker (nameSurnameCashier);
        }
    }
}
