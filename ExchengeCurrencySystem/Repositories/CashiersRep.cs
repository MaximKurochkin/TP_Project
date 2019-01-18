using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Entities;

namespace Repositories
{
    public class CashiersRep
    {
        string XMLaddress = "D:\\MyPrograms\\курс 3\\MainProject\\ExchengeCurrencySystem\\Cashiers.xml";

        public List<CashierModel> GetCashiers()
        {
            List<CashierModel> cashiers = new List<CashierModel>();
            string name = String.Empty, surname = String.Empty;
            string pasport = String.Empty, onWork = String.Empty;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "FirstName")
                        name = childnode.InnerText;

                    if (childnode.Name == "LastName")
                        surname = childnode.InnerText;

                    if (childnode.Name == "Pasport")
                        pasport = childnode.InnerText;

                    if (childnode.Name == "OnWork")
                        onWork = childnode.InnerText;
                }
                CashierModel cashier = new CashierModel(name, surname, pasport, onWork);
                cashiers.Add(cashier);
                name = string.Empty;
                surname = string.Empty;
                pasport = string.Empty;
                onWork = string.Empty;
            }
            return cashiers;
        }

        public void SetCashierWorking (CashierModel cashier)
        {
            CashierModel workingCashier = cashier;
            string name = String.Empty, surname = String.Empty;
            string pasport = String.Empty, onWork = String.Empty;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            bool isNameCoincidence = false;
            bool isSurnameCoincidence = false;
            bool needExit = false;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "FirstName")
                    {
                        if (childnode.InnerText == workingCashier.Name)
                        {
                            isNameCoincidence = true;
                        }
                    }
                    if (childnode.Name == "LastName")
                    {
                        if (childnode.InnerText == workingCashier.Surname)
                        {
                            isSurnameCoincidence = true;
                        }
                    }
                    if (childnode.Name == "OnWork")
                    {
                        if(isNameCoincidence && isSurnameCoincidence)
                        {
                            childnode.InnerText = "Yes";
                            needExit = true;
                        }
                    }
                }
                if (needExit)
                {
                    break;
                }
            }
            xDoc.Save(XMLaddress);
        }

        public CashierModel GetWorkingCashier()
        {
            CashierModel workingCashier = new CashierModel(null, null, null, null);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            bool needToExit = false;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "OnWork")
                    {
                        if(childnode.InnerText == "Yes")
                        {
                            foreach(XmlNode innerNode in xnode.ChildNodes)
                            {
                                if (innerNode.Name == "FirstName")
                                    workingCashier.Name = innerNode.InnerText;

                                if (innerNode.Name == "LastName")
                                {
                                    workingCashier.Surname = innerNode.InnerText;
                                }
                                if(innerNode.Name == "Pasport")
                                {
                                    workingCashier.Pasport = innerNode.InnerText;
                                    needToExit = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (needToExit) break;
                }
                if (needToExit) break;
            }
            return workingCashier;
        }

        public void ToMackCashierUnwork(CashierModel cashier)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            bool needToExit = false;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if(childnode.Name == "Pasport")
                    {
                        if(childnode.InnerText == cashier.Pasport)
                        {
                            foreach (XmlNode innerNode in xnode.ChildNodes)
                            { 
                                if (innerNode.Name == "OnWork")
                                {
                                    innerNode.InnerText = "No";
                                    needToExit = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (needToExit)
                {
                    break;
                }
            }
            xDoc.Save(XMLaddress);
        }

        public void AddCashier(CashierModel cashier)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент user
            XmlElement userElem = xDoc.CreateElement("Cashier");
            // создаем атрибут name
            XmlElement nameElem = xDoc.CreateElement("FirstName");
            // создаем элементы surname и pasport
            XmlElement surnameElem = xDoc.CreateElement("LastName");
            XmlElement pasportElem = xDoc.CreateElement("Pasport");
            XmlElement onWorkElem = xDoc.CreateElement("OnWork");

            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode(cashier.Name);
            XmlText surnameText = xDoc.CreateTextNode(cashier.Surname);
            XmlText pasportText = xDoc.CreateTextNode(cashier.Pasport);
            XmlText onWorkText = xDoc.CreateTextNode(cashier.OnWork);

            //добавляем узлы
            nameElem.AppendChild(nameText);
            surnameElem.AppendChild(surnameText);
            pasportElem.AppendChild(pasportText);
            onWorkElem.AppendChild(onWorkText);

            userElem.AppendChild(nameElem);
            userElem.AppendChild(surnameElem);
            userElem.AppendChild(pasportElem);
            userElem.AppendChild(onWorkElem);

            xRoot.AppendChild(userElem);
            xDoc.Save(XMLaddress);
        }

        public void DeleteCashier(CashierModel cashier)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLaddress);
            XmlElement xRoot = xDoc.DocumentElement;

            bool isNameCoincidence = false;
            bool isSurnameCoincidence = false;
            bool needExit = false;

            foreach (XmlElement xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "FirstName")
                    {
                        if (childnode.InnerText == cashier.Name)
                        {
                            isNameCoincidence = true;
                        }
                    }
                    if (childnode.Name == "LastName")
                    {
                        if (childnode.InnerText == cashier.Surname)
                        {
                            isSurnameCoincidence = true;
                        }
                    }
                    if (childnode.Name == "OnWork")
                    {
                        if (isNameCoincidence && isSurnameCoincidence)
                        {
                            xnode.RemoveAll();
                            needExit = true;
                        }
                    }
                }
                if (needExit)
                {
                    break;
                }

            }
            xDoc.Save(XMLaddress);
        }
    }
}
