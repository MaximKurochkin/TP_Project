using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Entities;

namespace Repositories
{
    public class ClientRep
    {
        private string XMLaddress = "D:\\MyPrograms\\курс 3\\MainProject\\ExchengeCurrencySystem\\Clients.xml";

        public Client SearchClientInFile(string pasport)
        {
            Client client = new Client();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Pasport")
                    {
                        if (childnode.InnerText == pasport)
                        {
                            client = GetDataAboutClient(xnode);
                            return client;
                        }
                    }
                }
            }
            return client;
        }

        private Client GetDataAboutClient(XmlElement xnode)
        {
            Client client = new Client();
            foreach (XmlNode childnode in xnode.ChildNodes)
            {
                if (childnode.Name == "FirstName")
                {
                    client.Name = childnode.InnerText;
                }
                if (childnode.Name == "LastName")
                {
                    client.Surname = childnode.InnerText;
                }
                if (childnode.Name == "Pasport")
                {
                    client.Pasport = childnode.InnerText;
                }
                if  (childnode.Name == "Sales")
                {
                    foreach (XmlNode innerNode in childnode.ChildNodes)
                    {
                        client.SoldCurrency.Add(innerNode.Name, innerNode.InnerText);
                    }
                }
                if(childnode.Name == "Purchased")
                {
                    foreach (XmlNode innerNode in childnode.ChildNodes)
                    {
                        client.PurchasedCurrency.Add(innerNode.Name, innerNode.InnerText);
                    }
                }
            }
            return client;
        }

        public void AddClient(Client newClient)
        {
            string defaultValue = "0";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент user
            XmlElement userElem = xDoc.CreateElement("Client");
            // создаем атрибут name
            XmlElement nameElem = xDoc.CreateElement("FirstName");
            // создаем элементы surname и pasport
            XmlElement surnameElem = xDoc.CreateElement("LastName");
            XmlElement pasportElem = xDoc.CreateElement("Pasport");
            XmlElement salesElem = xDoc.CreateElement("Sales");
            XmlElement purchElem = xDoc.CreateElement("Purchased");

            XmlElement BYNSalesElem = xDoc.CreateElement("BYN");
            XmlElement RUBSalesElem = xDoc.CreateElement("RUB");
            XmlElement EURSalesElem = xDoc.CreateElement("EUR");
            XmlElement USDSalesElem = xDoc.CreateElement("USD");
            XmlElement JPUSalesElem = xDoc.CreateElement("JPU");
            XmlElement GBRSalesElem = xDoc.CreateElement("GBR");
            XmlElement CHFSalesElem = xDoc.CreateElement("CHF");

            XmlElement BYNPurchElem = xDoc.CreateElement("BYN");
            XmlElement RUBPurchElem = xDoc.CreateElement("RUB");
            XmlElement EURPurchElem = xDoc.CreateElement("EUR");
            XmlElement USDPurchElem = xDoc.CreateElement("USD");
            XmlElement JPUPurchElem = xDoc.CreateElement("JPU");
            XmlElement GBRPurchElem = xDoc.CreateElement("GBR");
            XmlElement CHFPurchElem = xDoc.CreateElement("CHF");
            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode(newClient.Name);
            XmlText surnameText = xDoc.CreateTextNode(newClient.Surname);
            XmlText pasportText = xDoc.CreateTextNode(newClient.Pasport);

            XmlText BYNSalesText = xDoc.CreateTextNode(defaultValue);
            XmlText RUBSalesText = xDoc.CreateTextNode(defaultValue);
            XmlText EURSalesText = xDoc.CreateTextNode(defaultValue);
            XmlText USDSalesText = xDoc.CreateTextNode(defaultValue);
            XmlText JPUSalesText = xDoc.CreateTextNode(defaultValue);
            XmlText GBRSalesText = xDoc.CreateTextNode(defaultValue);
            XmlText CHFSalesText = xDoc.CreateTextNode(defaultValue);

            XmlText BYNPurchText = xDoc.CreateTextNode(defaultValue);
            XmlText RUBPurchText = xDoc.CreateTextNode(defaultValue);
            XmlText EURPurchText = xDoc.CreateTextNode(defaultValue);
            XmlText USDPurchText = xDoc.CreateTextNode(defaultValue);
            XmlText JPUPurchText = xDoc.CreateTextNode(defaultValue);
            XmlText GBRPurchText = xDoc.CreateTextNode(defaultValue);
            XmlText CHFPurchText = xDoc.CreateTextNode(defaultValue);
            //добавляем узлы
            nameElem.AppendChild(nameText);
            surnameElem.AppendChild(surnameText);
            pasportElem.AppendChild(pasportText);

            BYNSalesElem.AppendChild(BYNSalesText);
            RUBSalesElem.AppendChild(RUBSalesText);
            EURSalesElem.AppendChild(EURSalesText);
            USDSalesElem.AppendChild(USDSalesText);
            JPUSalesElem.AppendChild(JPUSalesText);
            GBRSalesElem.AppendChild(GBRSalesText);
            CHFSalesElem.AppendChild(CHFSalesText);

            BYNPurchElem.AppendChild(BYNPurchText);
            RUBPurchElem.AppendChild(RUBPurchText);
            EURPurchElem.AppendChild(EURPurchText);
            USDPurchElem.AppendChild(USDPurchText);
            JPUPurchElem.AppendChild(JPUPurchText);
            GBRPurchElem.AppendChild(GBRPurchText);
            CHFPurchElem.AppendChild(CHFPurchText);


            salesElem.AppendChild(BYNSalesElem);
            salesElem.AppendChild(RUBSalesElem);
            salesElem.AppendChild(EURSalesElem);
            salesElem.AppendChild(USDSalesElem);
            salesElem.AppendChild(JPUSalesElem);
            salesElem.AppendChild(GBRSalesElem);
            salesElem.AppendChild(CHFSalesElem);

            purchElem.AppendChild(BYNPurchElem);
            purchElem.AppendChild(RUBPurchElem);
            purchElem.AppendChild(EURPurchElem);
            purchElem.AppendChild(USDPurchElem);
            purchElem.AppendChild(JPUPurchElem);
            purchElem.AppendChild(GBRPurchElem);
            purchElem.AppendChild(CHFPurchElem);


            userElem.AppendChild(nameElem);
            userElem.AppendChild(surnameElem);
            userElem.AppendChild(pasportElem);
            userElem.AppendChild(salesElem);
            userElem.AppendChild(purchElem);

            xRoot.AppendChild(userElem);
            xDoc.Save(XMLaddress);
        }

        public bool PassportExist(string clientPassport)
        {
            bool isPassportExist = false;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Pasport")
                    {
                        if (childnode.InnerText == clientPassport)
                        {
                            isPassportExist = true;
                            return isPassportExist;
                        }
                    }
                }
            }
            return isPassportExist;
        }

        public bool UpdateInf(Client client, string currencyForSale, string currencyForBuy)
        {
            bool dataIsUpdate = false;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Pasport")
                    {
                        if (childnode.InnerText == client.Pasport)
                        {
                            //dataIsUpdate = UpdatePurchSaleInf(xnode, client, currencyForSale, currencyForBuy);
                            foreach(XmlNode innerNode in xnode.ChildNodes)
                            {
                                if(innerNode.Name == "Sales")
                                {
                                    foreach (XmlNode innerSaleNode in innerNode.ChildNodes)
                                    {
                                        if(innerSaleNode.Name == currencyForSale)
                                        {
                                            innerSaleNode.InnerText = client.SoldCurrency[currencyForSale];
                                            break;
                                        }
                                    }
                                }
                                if (innerNode.Name == "Purchased")
                                {
                                    foreach (XmlNode innerPurchNode in innerNode.ChildNodes)
                                    {
                                        if (innerPurchNode.Name == currencyForBuy)
                                        {
                                            innerPurchNode.InnerText = client.PurchasedCurrency[currencyForBuy];
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            xDoc.Save(XMLaddress);
            dataIsUpdate = true;
            return dataIsUpdate;
        }

        public void ToZeroValues()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Sales")
                    {
                        foreach (XmlNode innerNode in childnode.ChildNodes)
                        {
                            innerNode.InnerText = "0";
                        }
                    }
                    if (childnode.Name == "Purchased")
                    {
                        foreach (XmlNode innerNode in childnode.ChildNodes)
                        {
                            innerNode.InnerText = "0";
                        }
                    }
                }
            }
            xDoc.Save(XMLaddress);
        }
    }
}
