using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Entities;

namespace Presenters.CashierPresenters
{
    public class RestrictionsPresenter
    {
        RestrictionsService restrictionsService = new RestrictionsService();

        public Dictionary<string,string> GetRestrictions()
        {
            Dictionary<string, string> restrictions = restrictionsService.ToGetRestrictions();
            return restrictions;
        }
    }
}
