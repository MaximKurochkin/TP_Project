using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.CashierServices;
using Entities;

namespace Presenters.CashierPresenters
{
    public class LoginPresenter
    {
        public CashierDownloaderService downloaderService;

        public LoginPresenter()
        {
            downloaderService = new CashierDownloaderService();
        }

        public CashierDownloaderService DownloaderService
        {
            get
            {
                return downloaderService;
            }
        }

        public void GetCashiersFromXML()
        {
            downloaderService.GetListOfCashiers();
        }
        
    }
}
