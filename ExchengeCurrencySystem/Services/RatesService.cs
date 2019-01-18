using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class RatesService
    {
        CurrencyCourseRep courseRep = new CurrencyCourseRep();

        public Dictionary<string, string> ToGetSaleRates(string currency)
        {
            Dictionary<string, string> saleRates = new Dictionary<string, string>();
            saleRates.Add("BYN", ToConvertValueForSale(currency,"BYN"));
            saleRates.Add("RUB", ToConvertValueForSale(currency, "RUB"));
            saleRates.Add("EUR", ToConvertValueForSale(currency, "EUR"));
            saleRates.Add("USD", ToConvertValueForSale(currency, "USD"));
            saleRates.Add("JPU", ToConvertValueForSale(currency, "JPU"));
            saleRates.Add("GBR", ToConvertValueForSale(currency, "GBR"));
            saleRates.Add("CHF", ToConvertValueForSale(currency, "CHF"));
            return saleRates;
        }

        public Dictionary<string, string> ToGetPurchRates(string currency)
        {
            Dictionary<string, string> saleRates = new Dictionary<string, string>();
            saleRates.Add("BYN", ToConvertValueForBuy(currency, "BYN"));
            saleRates.Add("RUB", ToConvertValueForBuy(currency, "RUB"));
            saleRates.Add("EUR", ToConvertValueForBuy(currency, "EUR"));
            saleRates.Add("USD", ToConvertValueForBuy(currency, "USD"));
            saleRates.Add("JPU", ToConvertValueForBuy(currency, "JPU"));
            saleRates.Add("GBR", ToConvertValueForBuy(currency, "GBR"));
            saleRates.Add("CHF", ToConvertValueForBuy(currency, "CHF"));
            return saleRates;
        }

        public string ToConvertValueForBuy(string currencyForSale, string currencyForBuy)
        {
            double value = 1;
            double convertValue = 0;
            string convertValueStr = string.Empty;

            if (currencyForSale == "BYN")
            {
                convertValue = ConvertToBYN(currencyForBuy, value);
                convertValueStr = convertValue.ToString("0.0000");
                //convertValueStr = convertValue.ToString();
                return convertValueStr;
            }
            else
            {
                double valueInBYN = ConvertToBYN(currencyForBuy, value);
                convertValue = ConvertFromBYNTo(currencyForSale, valueInBYN);
                convertValueStr = convertValue.ToString("0.0000");
                //convertValueStr = convertValue.ToString();
                return convertValueStr;
            }
        }

        private double ConvertToBYN(string currencyForBuy, double value)
        {
            double coefficient = courseRep.GetPurchCourse(currencyForBuy);
            double result = value / coefficient;
            return result;
        }

        private double ConvertFromBYNTo(string currencyForSale, double value)
        {
            double coefficient = courseRep.GetPurchCourse(currencyForSale);
            double result = value * coefficient;
            return result;
        }

        public string ToConvertValueForSale(string currencyForSale, string currencyForBuy)
        {
            double value = 1;
            double convertValue = 0;
            string convertValueStr = string.Empty;

            if (currencyForSale == "BYN")
            {
                convertValue = ConvertTo(currencyForBuy, value);
                convertValueStr = convertValue.ToString("0.0000");
                //convertValueStr = convertValue.ToString();
                return convertValueStr;
            }
            else
            {
                double valueInBYN = ConvertToBYNForPurch(currencyForSale, value);
                convertValue = ConvertFromBYNForSale(currencyForBuy, valueInBYN);
                convertValueStr = convertValue.ToString("0.0000");
                //convertValueStr = convertValue.ToString();
                return convertValueStr;
            }
        }

        private double ConvertToBYNForPurch(string currencyForSale, double value)
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

        public Dictionary<string, string> ToGetSaleRates()
        {
            Dictionary<string, string> saleRates = new Dictionary<string, string>();
            saleRates.Add("BYN", courseRep.GetSaleCourse("BYN").ToString());
            saleRates.Add("RUB", courseRep.GetSaleCourse("RUB").ToString());
            saleRates.Add("EUR", courseRep.GetSaleCourse("EUR").ToString());
            saleRates.Add("USD", courseRep.GetSaleCourse("USD").ToString());
            saleRates.Add("JPU", courseRep.GetSaleCourse("JPU").ToString());
            saleRates.Add("GBR", courseRep.GetSaleCourse("GBR").ToString());
            saleRates.Add("CHF", courseRep.GetSaleCourse("CHF").ToString());
            return saleRates;
        }

        public Dictionary<string, string> ToGetPurchRates()
        {
            Dictionary<string, string> saleRates = new Dictionary<string, string>();
            saleRates.Add("BYN", courseRep.GetPurchCourse("BYN").ToString());
            saleRates.Add("RUB", courseRep.GetPurchCourse("RUB").ToString());
            saleRates.Add("EUR", courseRep.GetPurchCourse("EUR").ToString());
            saleRates.Add("USD", courseRep.GetPurchCourse("USD").ToString());
            saleRates.Add("JPU", courseRep.GetPurchCourse("JPU").ToString());
            saleRates.Add("GBR", courseRep.GetPurchCourse("GBR").ToString());
            saleRates.Add("CHF", courseRep.GetPurchCourse("CHF").ToString());
            return saleRates;
        }

        public void ToSaveSaleRates(Dictionary<string, string> saleRates)
        {
            courseRep.SaveSaleRates(saleRates);
        }

        public void ToSavePurchRates(Dictionary<string, string> purchRates)
        {
            courseRep.SavePurchRates(purchRates);
        }
    }
}
