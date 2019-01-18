using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CashierModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pasport { get; set; }
        public string OnWork { get; set; }

        public CashierModel (string name, string surname, string pasport, string onWork)
        {
            Name = name;
            Surname = surname;
            Pasport = pasport;
            OnWork = onWork;
        }
    }
}
