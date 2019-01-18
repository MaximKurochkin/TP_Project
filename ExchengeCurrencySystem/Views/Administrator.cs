using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.AdminPresenters;
using Entities;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp
{
    public partial class Administrator : Form
    {
        AdminPresenter presenter = new AdminPresenter();
        List<RadioButton> rbtnList = new List<RadioButton>();

        public Administrator()
        {
            InitializeComponent();
            groupBox2.Hide();
            groupBox5.Hide();
            grpBoxCashiersView.Hide();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void panelCashierList(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateCourse(object sender, EventArgs e)
        {
            
            groupBox2.Show();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveCourses(object sender, EventArgs e)
        {
            txtBoxMassageView.Clear();
            if (rbtnSaleRatesView.Checked)
            {
                Dictionary<string, string> saleRates = new Dictionary<string, string>();
                saleRates.Add("BYN", txtBoxBYNCourseView.Text);
                saleRates.Add("RUB", txtBoxRUBCourseView.Text);
                saleRates.Add("EUR", txtBoxEURCourseView.Text);
                saleRates.Add("USD", txtBoxUSDCourseView.Text);
                saleRates.Add("JPU", txtBoxJPUCourseView.Text);
                saleRates.Add("GBR", txtBoxGBRCourseView.Text);
                saleRates.Add("CHF", txtBoxCHFCourseView.Text);
                presenter.SaveSaleRates(saleRates);
            }
            else
            {
                Dictionary<string, string> purchRates = new Dictionary<string, string>();
                purchRates.Add("BYN", txtBoxBYNCourseView.Text);
                purchRates.Add("RUB", txtBoxRUBCourseView.Text);
                purchRates.Add("EUR", txtBoxEURCourseView.Text);
                purchRates.Add("USD", txtBoxUSDCourseView.Text);
                purchRates.Add("JPU", txtBoxJPUCourseView.Text);
                purchRates.Add("GBR", txtBoxGBRCourseView.Text);
                purchRates.Add("CHF", txtBoxCHFCourseView.Text);
                presenter.SavePurchRates(purchRates);
            }
            txtBoxMassageView.Text = "Курс успешно обнавлен";
            txtBoxBYNCourseView.Clear();
            txtBoxRUBCourseView.Clear();
            txtBoxEURCourseView.Clear();
            txtBoxUSDCourseView.Clear();
            txtBoxJPUCourseView.Clear();
            txtBoxGBRCourseView.Clear();
            txtBoxCHFCourseView.Clear();
            groupBox2.Hide(); 
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnSetRestrictions(object sender, EventArgs e)
        {
            txtBoxMassageView.Clear();
            Dictionary<string, string> restrictions = presenter.GetRestrictions();
            foreach (KeyValuePair<string, string> keyValuePair in restrictions)
            {
                if (keyValuePair.Key == "BYN")
                {
                    txtBoxRestricBYNView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "RUB")
                {
                    txtBoxRestricRUBView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "EUR")
                {
                    txtBoxRestricEURView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "USD")
                {
                    txtBoxRestricUSDView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "JPU")
                {
                    txtBoxRestricJPUView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "GBR")
                {
                    txtBoxRestricGBRView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "CHF")
                {
                    txtBoxRestricCHFView.Text = keyValuePair.Value;
                }
            }
            groupBox5.Show();
        }

        private void btnSaveRestric(object sender, EventArgs e)
        {
            Dictionary<string, string> restrictions = new Dictionary<string, string>();
            restrictions.Add("BYN", txtBoxRestricBYNView.Text);
            restrictions.Add("RUB", txtBoxRestricRUBView.Text);
            restrictions.Add("EUR", txtBoxRestricEURView.Text);
            restrictions.Add("USD", txtBoxRestricUSDView.Text);
            restrictions.Add("JPU", txtBoxRestricJPUView.Text);
            restrictions.Add("GBR", txtBoxRestricGBRView.Text);
            restrictions.Add("CHF", txtBoxRestricCHFView.Text);
            presenter.SaveRestrictions(restrictions);
            txtBoxMassageView.Text = "Ограничения сохранены";
            groupBox5.Hide();
        }

        private void grpBoxCashiers(object sender, EventArgs e)
        {
            grpBoxNewCashierView.Hide();
        }

        private void btnAddCashier(object sender, EventArgs e)
        {
            txtBoxMassageView.Clear();
            grpBoxCashiersView.Show();
            grpBoxNewCashierView.Hide();

            int x = 6;
            int y = 0;

            List<CashierModel> cashiers = presenter.GetCashiers();

            for (int i = 0; i < cashiers.Count(); i++)
            { 
                rbtnList.Add(new RadioButton());
                rbtnList[i].Text = cashiers[i].Surname + " " + cashiers[i].Name;
                rbtnList[i].Location = new Point(x, y);
                rbtnList[i].Width = 250;
                rbtnList[i].Height = 30;
                this.panelCashierListView.Controls.Add(rbtnList[i]);

                y += 34;
            }

        }

        private void btnSaveCashier(object sender, EventArgs e)
        {
            grpBoxCashiersView.Hide();
            grpBoxNewCashierView.Hide();

            txtBoxMassageView.Clear();

            if (txtBoxNameView.Text != string.Empty && txtBoxSurnameView.Text != string.Empty && 
                txtBoxPassportView.Text != string.Empty)
            {
                bool isDataCorrect = presenter.ToTransferCashierInfForCorrect(txtBoxNameView.Text, txtBoxSurnameView.Text);
                if (isDataCorrect)
                {
                    presenter.CreateNoteAboutNewCashier(txtBoxNameView.Text, txtBoxSurnameView.Text, txtBoxPassportView.Text);
                    txtBoxMassageView.AppendText("Создана новая запись о кассире\n");
                }
                else
                {
                    txtBoxMassageView.Text = "Внимание! Некоректный ввод данных кассира";
                }
            }
            else
            {
                txtBoxMassageView.Text = "Введите имя, фамилию и номер паспорта!";
            }
            //presenter.AddCashier(txtBoxNameView.Text, txtBoxSurnameView.Text, txtBoxPassportView.Text);
        }

        private void grpBoxNewCashier(object sender, EventArgs e)
        {

        }

        private void btnAddNewCashier(object sender, EventArgs e)
        {
            grpBoxNewCashierView.Show();
        }

        private void btnExit(object sender, EventArgs e)
        {
            txtBoxMassageView.Clear();
            txtBoxNameView.Clear();
            txtBoxSurnameView.Clear();
            txtBoxPassportView.Clear();
            presenter.ToFinishDay();
            Hide();
            Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void txtBoxMassage(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCHFCourse(object sender, EventArgs e)
        {

        }

        private void txtBoxGBRCourse(object sender, EventArgs e)
        {

        }

        private void txtBoxJPUCourse(object sender, EventArgs e)
        {

        }

        private void txtBoxUSDCourse(object sender, EventArgs e)
        {

        }

        private void txtBoxEURCourse(object sender, EventArgs e)
        {

        }

        private void txtBoxRUBCourse(object sender, EventArgs e)
        {

        }

        private void txtBoxBYNCourse(object sender, EventArgs e)
        {

        }

        private void rbtnSaleRates(object sender, EventArgs e)
        {
            Dictionary<string, string> saleRates = presenter.GetSaleRates();
            foreach (KeyValuePair<string, string> keyValuePair in saleRates)
            {
                if (keyValuePair.Key == "BYN")
                {
                    txtBoxBYNCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "RUB")
                {
                    txtBoxRUBCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "EUR")
                {
                    txtBoxEURCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "USD")
                {
                    txtBoxUSDCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "JPU")
                {
                    txtBoxJPUCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "GBR")
                {
                    txtBoxGBRCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "CHF")
                {
                    txtBoxCHFCourseView.Text = keyValuePair.Value;
                }
            }

        }

        private void rbtnPurchRates(object sender, EventArgs e)
        {
            Dictionary<string, string> purchRates = presenter.GetPurchRates();
            foreach (KeyValuePair<string, string> keyValuePair in purchRates)
            {
                if (keyValuePair.Key == "BYN")
                {
                    txtBoxBYNCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "RUB")
                {
                    txtBoxRUBCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "EUR")
                {
                    txtBoxEURCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "USD")
                {
                    txtBoxUSDCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "JPU")
                {
                    txtBoxJPUCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "GBR")
                {
                    txtBoxGBRCourseView.Text = keyValuePair.Value;
                }
                if (keyValuePair.Key == "CHF")
                {
                    txtBoxCHFCourseView.Text = keyValuePair.Value;
                }
            }
        }

        private void txtBoxRestricBYN(object sender, EventArgs e)
        {

        }

        private void btnSetCashier(object sender, EventArgs e)
        {
            CashierModel workingCashier = presenter.GetWorkingCashier();

            foreach(RadioButton rbtn in rbtnList)
            {
                if (rbtn.Checked)
                {
                    presenter.SetCashier(rbtn.Text, workingCashier);
                }
            }
            txtBoxMassageView.Text = "Кассир установлен как работающий";
        }

        private void txtBoxName(object sender, EventArgs e)
        {

        }

        private void txtBoxSurname(object sender, EventArgs e)
        {

        }

        private void txtBoxPassport(object sender, EventArgs e)
        {

        }

        private void btnStat(object sender, EventArgs e)
        {
            string historyAddress = "D:\\MyPrograms\\курс 3\\MainProject\\ExchengeCurrencySystem\\History.xlsx";
            Microsoft.Office.Interop.Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;
            Excel.Workbook xlWb = xlApp.Workbooks.Open(historyAddress,
                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                        Type.Missing, Type.Missing);
        }

        private void btnDeleteCashier(object sender, EventArgs e)
        {
            txtBoxMassageView.Clear();
            foreach(RadioButton rbtn in rbtnList)
            {
                if (rbtn.Checked)
                {
                    presenter.DeleteCashier(rbtn.Text);
                }
            }
            txtBoxMassageView.Text = "Запись о кассире удалена";
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
