using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class RestrictionsService
    {
        RestrictionsRep restrictionsRep = new RestrictionsRep();

        public Dictionary<string, string> ToGetRestrictions()
        {
            Dictionary<string, string> restrictions = restrictionsRep.GetRestrictions();
            return restrictions;
        }

        public void SetRestrictions(Dictionary<string, string> restrictions)
        {
            restrictionsRep.SetNewRestrictions(restrictions);
        }
    }
}
