using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Repositories
{
    public class CurrencyCourseRep //: ICurrencyRep
    {
        private string XMLAddress = "D:\\MyPrograms\\курс 3\\MainProject\\ExchengeCurrencySystem\\Exchange_Rates.xml";

        public double GetSaleCourse(string currency)
        {
            double course = 0;
            bool needExit = false;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLAddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "Sale")
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == currency)
                        {
                            course = Convert.ToDouble(childnode.InnerText);
                            needExit = true;
                            break;
                        }
                    }
                }
                if (needExit) break;
            }
            return course;
        }

        public double GetPurchCourse(string currency)
        {
            double course = 0;
            bool needExit = false;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLAddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "Purchase")
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == currency)
                        {
                            course = Convert.ToDouble(childnode.InnerText);
                            needExit = true;
                            break;
                        }
                    }
                }
                if (needExit) break;
            }
            return course;
        }

        public void SaveSaleRates(Dictionary<string, string> saleRates)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLAddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "Sale")
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "BYN")
                        {
                            childnode.InnerText = saleRates["BYN"];
                            continue;
                        }
                        if (childnode.Name == "RUB")
                        {
                            childnode.InnerText = saleRates["RUB"];
                            continue;
                        }
                        if (childnode.Name == "EUR")
                        {
                            childnode.InnerText = saleRates["EUR"];
                            continue;
                        }
                        if (childnode.Name == "USD")
                        {
                            childnode.InnerText = saleRates["USD"];
                            continue;
                        }
                        if (childnode.Name == "JPU")
                        {
                            childnode.InnerText = saleRates["JPU"];
                            continue;
                        }
                        if (childnode.Name == "GBR")
                        {
                            childnode.InnerText = saleRates["GBR"];
                            continue;
                        }
                        if (childnode.Name == "CHF")
                        {
                            childnode.InnerText = saleRates["CHF"];
                            continue;
                        }
                    }
                }
            }
            xDoc.Save(XMLAddress);
        }

        public void SavePurchRates(Dictionary<string, string> purchRates)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLAddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "Purchase")
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "BYN")
                        {
                            childnode.InnerText = purchRates["BYN"];
                            continue;
                        }
                        if (childnode.Name == "RUB")
                        {
                            childnode.InnerText = purchRates["RUB"];
                            continue;
                        }
                        if (childnode.Name == "EUR")
                        {
                            childnode.InnerText = purchRates["EUR"];
                            continue;
                        }
                        if (childnode.Name == "USD")
                        {
                            childnode.InnerText = purchRates["USD"];
                            continue;
                        }
                        if (childnode.Name == "JPU")
                        {
                            childnode.InnerText = purchRates["JPU"];
                            continue;
                        }
                        if (childnode.Name == "GBR")
                        {
                            childnode.InnerText = purchRates["GBR"];
                            continue;
                        }
                        if (childnode.Name == "CHF")
                        {
                            childnode.InnerText = purchRates["CHF"];
                            continue;
                        }
                    }
                }
            }
            xDoc.Save(XMLAddress);
        }
    }
}
