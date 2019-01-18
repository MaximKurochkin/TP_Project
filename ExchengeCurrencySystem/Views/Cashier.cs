using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.CashierPresenters;
using Entities;

namespace WindowsFormsApp
{
    public partial class Cashier : Form
    {
        CashierWorkPresenter presenter = new CashierWorkPresenter();
        Restrictions restrictions = new Restrictions();

        public Cashier()
        {
            InitializeComponent();
            grpBoxCurrencyExchangeView.Hide();
            btnCreateNoteView.Hide();
            btnMakeAnExchangeView.Hide();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxClientSurname(object sender, EventArgs e)
        {

        }

        private void txtBoxClientName(object sender, EventArgs e)
        {

        }

        private void txtBoxClientPasport(object sender, EventArgs e)
        {

        }

        private void txtBoxConsole(object sender, EventArgs e)
        {

        }

        private void grpBoxCurrencyExchange(object sender, EventArgs e)
        {
            
        }

        private void btnToConvert(object sender, EventArgs e)
        {
            txtBoxConsoleView.Clear();
            string currencyForSale = CurrencyForSaleUpdownView.Text;
            string currencyForBuy = CurrencyToBuyUpdownView.Text;
            string valueForSale = txtBoxCurrencyForSaleView.Text;
            string valueForBuy = txtBoxCurrencyToBuyView.Text;
            if(valueForBuy != string.Empty && Convert.ToDouble(valueForBuy) < 0)
            {
                txtBoxConsoleView.Text = "Ошибка! Введены невалидные данные";
            }
            if (valueForSale != string.Empty && Convert.ToDouble(valueForSale) < 0)
            {
                txtBoxConsoleView.Text = "Ошибка! Введены невалидные данные";
            }
            if (valueForBuy != string.Empty && Convert.ToDouble(valueForBuy) >= 0)
            {
                bool CanPurch = presenter.PurchLimit(txtBoxClientPasportView.Text, valueForBuy, currencyForBuy);
                bool CanSale = false;
                if (CanPurch)
                {
                    string convertValue = presenter.ConvertationForBuy(currencyForSale, currencyForBuy, valueForBuy).ToString();
                    CanSale = presenter.SaleLimit(txtBoxClientPasportView.Text, convertValue, currencyForSale);
                    if (CanSale)
                    {
                        txtBoxCurrencyForSaleView.Text = convertValue;
                        txtBoxConsoleView.Text = "Обмен возможен";
                        btnMakeAnExchangeView.Show();
                    }
                    else
                    {
                        txtBoxConsoleView.Text = "Обмен невозможен!/n";
                        txtBoxConsoleView.Text = "Достигнут лимит продажи данной валюты";
                    }
                }
                else
                {
                    txtBoxConsoleView.Text = "Достигнут лимит покупки по данной валюте";
                }
            }
            else if(valueForSale != string.Empty && valueForBuy == string.Empty && Convert.ToDouble(valueForSale) >= 0)
            {
                bool CanSale = presenter.SaleLimit(txtBoxClientPasportView.Text, valueForSale, currencyForSale);
                bool CanPurch = false;
                if (CanSale)
                {
                    string convertValue = presenter.ConvertationForSale(currencyForSale, currencyForBuy, valueForSale).ToString();
                    CanPurch = presenter.PurchLimit(txtBoxClientPasportView.Text, convertValue, currencyForBuy);
                    if (CanSale)
                    {
                        txtBoxCurrencyToBuyView.Text = convertValue;
                        txtBoxConsoleView.Text = "Обмен возможен";
                        btnMakeAnExchangeView.Show();
                    }
                    else
                    {
                        txtBoxConsoleView.Text = "Обмен невозможен!/n";
                        txtBoxConsoleView.Text = "Достигнут лимит продажи по данной валюте";
                    }
                }
                else
                {
                    txtBoxConsoleView.Text = "Достигнут лимит продажи данной валюты";
                }
            }
        }

        //private void label4_Click(object sender, EventArgs e)
        //{

        //}

        private void CurrencyForSaleUpdown(object sender, EventArgs e)
        {

        }

        private void CurrencyToBuyUpdown(object sender, EventArgs e)
        {

        }

        private void btnCheckClientInf(object sender, EventArgs e)
        {
            bool clientExist = false;
            txtBoxConsoleView.Clear();
            if(txtBoxClientPasportView.Text != String.Empty)
            {
                clientExist = presenter.CheckClientPassport(txtBoxClientPasportView.Text);
            }
            else
            {
                txtBoxConsoleView.Text = "Введите номер паспорта!";
            }

            if (clientExist)
            {
                Client client = presenter.ToGetInfAboutClient(txtBoxClientPasportView.Text);
                txtBoxClientNameView.Text = client.Name;
                txtBoxClientSurnameView.Text = client.Surname;
                ToShowClientInf();
                grpBoxCurrencyExchangeView.Show();
            }
            else
            {
                txtBoxConsoleView.Text = "Клиент не найден\n";
                txtBoxConsoleView.AppendText("Введите имя и фамилию, чтобы создать запись о новом клиенте");
                btnCreateNoteView.Show();
            }
        }

        private void btnCreateNote(object sender, EventArgs e)
        {
            txtBoxConsoleView.Clear();
            if (txtBoxClientNameView.Text != string.Empty && txtBoxClientSurnameView.Text != string.Empty)
            {
                bool isDataCorrect = presenter.ToTransferClientInfForCorrect(txtBoxClientNameView.Text, txtBoxClientSurnameView.Text);
                if (isDataCorrect)
                {
                    grpBoxCurrencyExchangeView.Show();
                    presenter.CreateNoteAboutNewClient(txtBoxClientNameView.Text, txtBoxClientSurnameView.Text, txtBoxClientPasportView.Text);
                    txtBoxConsoleView.AppendText("Создана новая запись о клиенте\n");

                    ToShowClientInf();
                }
                else
                {
                    txtBoxConsoleView.Text = "Внимание! Некоректный ввод данных клиента";
                    grpBoxCurrencyExchangeView.Show();
                    grpBoxCurrencyExchangeView.Hide();
                }
            }
            else
            {
                txtBoxConsoleView.Text = "Введите имя и фамилию!";
            }
        }

        private void ToShowClientInf()
        {
            Client client = presenter.ToGetInfAboutClient(txtBoxClientPasportView.Text);
            if (client.Name != null)
            {
                txtBoxConsoleView.AppendText("Имя: " + client.Name + "\n");
                txtBoxConsoleView.AppendText("Фамилия: " + client.Surname + "\n");
                txtBoxConsoleView.AppendText("Номер паспорта: " + client.Pasport + "\n");
                txtBoxConsoleView.AppendText("Продано валюты\n");
                foreach (KeyValuePair<string, string> soldCurrency in client.SoldCurrency)
                {
                    if (soldCurrency.Value != "0")
                    {
                        txtBoxConsoleView.AppendText(soldCurrency.Key + ": " + soldCurrency.Value + "\n");
                    }
                }
                txtBoxConsoleView.AppendText("Куплено валюты\n");
                foreach (KeyValuePair<string, string> purchasedCurrency in client.PurchasedCurrency)
                {
                    if (purchasedCurrency.Value != "0")
                    {
                        txtBoxConsoleView.AppendText(purchasedCurrency.Key + ": " + purchasedCurrency.Value + "\n");
                    }
                }
            }
        }

        private void btnToComplete(object sender, EventArgs e)
        {
            grpBoxCurrencyExchangeView.Hide();
            txtBoxClientPasportView.Clear();
            txtBoxClientSurnameView.Clear();
            txtBoxClientNameView.Clear();
            txtBoxConsoleView.Clear();
            txtBoxCurrencyForSaleView.Clear();
            txtBoxCurrencyToBuyView.Clear();
            btnCreateNoteView.Hide();
            
        }

        private void txtBoxCurrencyForSale(object sender, EventArgs e)
        {
            //Regex regex = new Regex("[А-я]");
            //Regex regexNum = new Regex("[0-9]");
            //if (regex.IsMatch(txtBoxCurrencyForSaleView.Text))
            //{
               // txtBoxConsoleView.Text = "Внимание! Некоректный ввод суммы продажи";
               // btnToConvertView.Enabled = false;
               // btnMakeAnExchangeView.Enabled = false;
            //}
           // else
            //{
              //  txtBoxConsoleView.Clear();
             //   btnToConvertView.Enabled = true;
             //   btnMakeAnExchangeView.Enabled = true;
            //}
        }

        private void btnMakeAnExchange(object sender, EventArgs e)
        {
            string currencyForSale = CurrencyForSaleUpdownView.Text;
            string currencyForBuy = CurrencyToBuyUpdownView.Text;
            string valueForSale = txtBoxCurrencyForSaleView.Text;
            string valueForBuy = txtBoxCurrencyToBuyView.Text;

            string name = txtBoxClientNameView.Text;
            string surname = txtBoxClientSurnameView.Text;
            string passport = txtBoxClientPasportView.Text;

            if (presenter.UpdateClientInf(passport, currencyForSale, valueForSale,
                currencyForBuy, valueForBuy))
            {
                txtBoxConsoleView.Text = "Информация о клиенте обновлена\n";
            }
            else
            {
                txtBoxConsoleView.Text = "Ошибка! Ведуться технические работы - информация о клиенте не была обнавлена!\n";
            }

            presenter.XmlNoteMaker(name, surname, passport, currencyForSale, valueForSale,
                                   currencyForBuy, valueForBuy);
            txtBoxConsoleView.AppendText("Создана запись в истории\n");
            presenter.CheckMaker(name, surname, passport, currencyForSale, valueForSale,
                                   currencyForBuy, valueForBuy);
            txtBoxConsoleView.AppendText("Пожалуйста, заберите чек\n");
        }

        private void btnToExit(object sender, EventArgs e)
        {
            btnToComplete(null, null);
            presenter.WorkFinish();
            restrictions.Close();
            Hide();
            Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnToKnowRestrictions(object sender, EventArgs e)
        {
            restrictions.Show();
        }

        private void btnToKnowExchangeRates(object sender, EventArgs e)
        {
            ExchangeRates exchangeRates = new ExchangeRates();
            exchangeRates.Show();
        }

        private void grpBoxClientInf(object sender, EventArgs e)
        {

        }

        private void lblClientNameView_Click(object sender, EventArgs e)
        {

        }

        private void lblClientSurnameView_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxCheckClientInfView_Enter(object sender, EventArgs e)
        {

        }

        private void grpBoxConsoleView_Enter(object sender, EventArgs e)
        {

        }

        private void tblLayoutCurrencyExchangeView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxCurrencyToBuy(object sender, EventArgs e)
        {
            Regex regex = new Regex("[А-я]");
            Regex regexNum = new Regex("[0-9]");
            if (regex.IsMatch(txtBoxCurrencyToBuyView.Text))
            {
                txtBoxConsoleView.Text = "Внимание! Некоректный ввод суммы продажи";
                btnToConvertView.Enabled = false;
                btnMakeAnExchangeView.Enabled = false;
            }
            else
            {
                txtBoxConsoleView.Clear();
                btnToConvertView.Enabled = true;
                btnMakeAnExchangeView.Enabled = true;
            }
        }

        private void panelOptions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
