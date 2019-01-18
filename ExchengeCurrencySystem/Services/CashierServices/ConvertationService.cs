using System;
using Repositories;
using Entities;
//using ExcelLibrary.SpreadSheet;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Services.CashierServices
{
    public class ConvertationService
    {
        CurrencyCourseRep courseRep = new CurrencyCourseRep();
        CashiersRep cashiersRep = new CashiersRep();

        private string checkAddress = "D:\\MyPrograms\\курс 3\\MainProject\\ExchengeCurrencySystem\\Check.txt";
        private string historyAddress = "D:\\MyPrograms\\курс 3\\MainProject\\ExchengeCurrencySystem\\History.xlsx";

        //ICurrencyRep courseRep;

        public string ToConvertValueForBuy(string currencyForSale, string currencyForBuy, string valueStr)
        {
            double value = Convert.ToDouble(valueStr);
            double convertValue = 0;
            string convertValueStr = string.Empty;

            if (currencyForSale == "BYN")
            {
                convertValue = ConvertToBYN(currencyForBuy, value);
                convertValueStr = convertValue.ToString("0.00");
                return convertValueStr;
            }
            else
            {
                double valueInBYN = ConvertToBYN(currencyForBuy, value);
                convertValue = ConvertFromBYNTo(currencyForSale, valueInBYN);
                convertValueStr = convertValue.ToString("0.00");
                return convertValueStr;
            }
        }

        private double ConvertToBYN(string currencyForBuy, double value)
        {
            double coefficient = courseRep.GetSaleCourse(currencyForBuy);
            double result = value / coefficient;
            return result;
        }

        private double ConvertFromBYNTo(string currencyForSale, double value)
        {
            double coefficient = courseRep.GetPurchCourse(currencyForSale);
            double result = value * coefficient;
            return result;
        }

        public string ToConvertValueForSale(string currencyForSale, string currencyForBuy, string valueStr)
        {
            double value = Convert.ToDouble(valueStr);
            double convertValue = 0;
            string convertValueStr = string.Empty;

            if (currencyForSale == "BYN")
            {
                convertValue = ConvertTo(currencyForBuy, value);
                convertValueStr = convertValue.ToString("0.00");
                return convertValueStr;
            }
            else
            {
                double valueInBYN = ConvertToBYNForPurch(currencyForSale, value);
                convertValue = ConvertFromBYNForSale(currencyForBuy, valueInBYN);
                convertValueStr = convertValue.ToString("0.00");
                return convertValueStr;
            }
        }

        private double ConvertToBYNForPurch (string currencyForSale, double value)
        {
            double coef = courseRep.GetPurchCourse(currencyForSale);
            return value / coef;
        }

        private double ConvertFromBYNForSale(string currencyForBuy, double value)
        {
            double coef = courseRep.GetSaleCourse(currencyForBuy);
            return coef * value;
        }

        private double ConvertTo(string currencyForBuy, double value)
        {
            double coef = courseRep.GetSaleCourse(currencyForBuy);
            return value * coef;
        }

        public void ToMakeNoteInHistory( string name, string surname, string passport, string currencyForSale,
                                  string valueForSale, string currencyForBuy, string valueForBuy)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;

            CashierModel workingCashier = cashiersRep.GetWorkingCashier();

            Excel.Application xlApp = new Excel.Application();
            //xlApp.Visible = true;
            Excel.Workbook xlWb = xlApp.Workbooks.Open( historyAddress, 
                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                        Type.Missing, Type.Missing);

            Excel.Worksheet xlSht = xlWb.Sheets[1];
            int num = xlSht.Cells.Find("*", Type.Missing, Excel.XlFindLookIn.xlValues, 
                Excel.XlLookAt.xlWhole, Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious, 
                false, false, Type.Missing).Row;

            xlSht.Cells[num + 1, "A"] = num;
            xlSht.Cells[num + 1, "B"] = workingCashier.Name + " " + workingCashier.Surname;
            xlSht.Cells[num + 1, "C"] = name +" " + surname;
            xlSht.Cells[num + 1, "D"] = passport;
            xlSht.Cells[num + 1, "E"] = valueForSale + " " + currencyForSale;
            xlSht.Cells[num + 1, "F"] = valueForBuy + " " + currencyForBuy;
            xlSht.Cells[num + 1, "G"] = time;

            xlWb.Save();
            xlWb.Close(true, Type.Missing, Type.Missing); //закрыть и сохранить книгу
            xlApp.Quit();
        }

        public void ToMakeCheck(string name, string surname, string passport, string currencyForSale,
                                  string valueForSale, string currencyForBuy, string valueForBuy)
        {
            CashierModel workingCashier = cashiersRep.GetWorkingCashier();
            string[] check = new string[9]; //System.IO.File.ReadAllLines(checkAddress, Encoding.Default);
            check[0] = "        Чек";
            check[1] = "Обменный пункт №7";
            check[2] = "ул.Курчатова,3";
            check[3] = "Клиент: " + surname + " " + name;
            check[4] = "Куплено: " + valueForBuy + " " + currencyForBuy;
            check[5] = "Продано: " + valueForSale + " " + currencyForSale;
            check[6] = "Кассир: " + workingCashier.Surname + " " + workingCashier.Name;
            check[7] = "    " + DateTime.Now;
            check[8] = "    Хорошего дня!";

            using (StreamWriter sw = new StreamWriter(checkAddress, false, System.Text.Encoding.Default))
            {
                foreach(string str in check)
                {
                    sw.WriteLine(str);
                }
            }
        }
    }
}
