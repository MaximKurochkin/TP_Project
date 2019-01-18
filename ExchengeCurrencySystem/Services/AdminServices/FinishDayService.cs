using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services.AdminServices
{
    public class FinishDayService
    {
        ClientRep clientRep = new ClientRep();

        public void ToFinish()
        {
            clientRep.ToZeroValues();
        }
    }
}
