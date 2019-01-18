using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.CashierPresenters;

namespace WindowsFormsApp
{
    public partial class ExchangeRates : Form
    {
        RatesPresenter presenter = new RatesPresenter();

        public ExchangeRates()
        {
            InitializeComponent();

        }

        private void CurrecnyUpDown(object sender, EventArgs e)
        {
            
        }

        private void grpBoxRatesView_Enter(object sender, EventArgs e)
        {

        }

        private void rbtPurch(object sender, EventArgs e)
        {

        }

        private void rbtnSale(object sender, EventArgs e)
        {

        }

        private void btnToShowRates(object sender, EventArgs e)
        {
            if (rbtnSaleView.Checked)
            {
                Dictionary<string, string> rates = presenter.GetSaleRates(CurrecnyUpDownView.Text);
                foreach (KeyValuePair<string, string> keyValuePair in rates)
                {
                    if (keyValuePair.Key == "BYN")
                    {
                        txtBoxBYNView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "RUB")
                    {
                        txtBoxRUBView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "EUR")
                    {
                        txtBoxEURView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "USD")
                    {
                        txtBoxUSDView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "JPU")
                    {
                        txtBoxJPUView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "GBR")
                    {
                        txtBoxGBRView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "CHF")
                    {
                        txtBoxCHFView.Text = keyValuePair.Value;
                    }
                }
            }
            else
            {
                Dictionary<string, string> rates = presenter.GetPurchRates(CurrecnyUpDownView.Text);
                foreach (KeyValuePair<string, string> keyValuePair in rates)
                {
                    if (keyValuePair.Key == "BYN")
                    {
                        txtBoxBYNView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "RUB")
                    {
                        txtBoxRUBView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "EUR")
                    {
                        txtBoxEURView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "USD")
                    {
                        txtBoxUSDView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "JPU")
                    {
                        txtBoxJPUView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "GBR")
                    {
                        txtBoxGBRView.Text = keyValuePair.Value;
                    }
                    if (keyValuePair.Key == "CHF")
                    {
                        txtBoxCHFView.Text = keyValuePair.Value;
                    }
                }
            }
        }
    }
}
