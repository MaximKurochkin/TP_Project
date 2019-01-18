using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pasport { get; set; }
        public Dictionary<string,string> SoldCurrency = new Dictionary<string, string>();
        public Dictionary<string, string> PurchasedCurrency = new Dictionary<string, string>();
    }
}
