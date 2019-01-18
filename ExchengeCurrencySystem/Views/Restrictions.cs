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
    public partial class Restrictions : Form
    {
        RestrictionsPresenter presenter = new RestrictionsPresenter();

        public Restrictions()
        {
            InitializeComponent();
            Dictionary<string, string> restrictions = presenter.GetRestrictions();
            foreach(KeyValuePair<string,string> keyValuePair in restrictions)
            {
                if(keyValuePair.Key == "BYN")
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

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}

        private void txtBoxBYN(object sender, EventArgs e)
        {

        }

        private void txtBoxRUB(object sender, EventArgs e)
        {

        }

        private void txtBoxEUR(object sender, EventArgs e)
        {

        }

        private void txtBoxUSD(object sender, EventArgs e)
        {

        }

        private void txtBoxJPU(object sender, EventArgs e)
        {

        }

        private void txtBoxGBR(object sender, EventArgs e)
        {

        }

        private void txtBoxCHF(object sender, EventArgs e)
        {

        }
    }
}
