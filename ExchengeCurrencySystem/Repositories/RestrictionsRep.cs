using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Repositories
{
    public class RestrictionsRep
    {
        private string XMLAddress = "D:\\MyPrograms\\курс 3\\MainProject\\ExchengeCurrencySystem\\Restrictions.xml";

        public double GetCurrencyRestriction(string currency)
        {
            double restriction = 0;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLAddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == currency)
                    {
                        restriction = Convert.ToDouble(childnode.InnerText);
                        return restriction;
                    }
                }
            }
            return restriction;
        }

        public Dictionary<string, string> GetRestrictions()
        {
            Dictionary<string, string> restrictions = new Dictionary<string, string>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLAddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    restrictions.Add(childnode.Name, childnode.InnerText);
                }
            }
            return restrictions;
        }

        public void SetNewRestrictions(Dictionary<string, string> restrictions)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLAddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "BYN")
                    {
                        childnode.InnerText = restrictions["BYN"];
                        continue;
                    }
                    if (childnode.Name == "RUB")
                    {
                        childnode.InnerText = restrictions["RUB"];
                        continue;
                    }
                    if (childnode.Name == "EUR")
                    {
                        childnode.InnerText = restrictions["EUR"];
                        continue;
                    }
                    if (childnode.Name == "USD")
                    {
                        childnode.InnerText = restrictions["USD"];
                        continue;
                    }
                    if (childnode.Name == "JPU")
                    {
                        childnode.InnerText = restrictions["JPU"];
                        continue;
                    }
                    if (childnode.Name == "GBR")
                    {
                        childnode.InnerText = restrictions["GBR"];
                        continue;
                    }
                    if (childnode.Name == "CHF")
                    {
                        childnode.InnerText = restrictions["CHF"];
                        continue;
                    }
                }
            }
            xDoc.Save(XMLAddress);
        }

    }
}
