using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters;
using Presenters.CashierPresenters;
using Entities;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        LoginPresenter presenter = new LoginPresenter();
        WorkingCashierPresenter workingPresenter = new WorkingCashierPresenter();
        List<RadioButton> rbtnList = new List<RadioButton>();

        public Login()
        {
            InitializeComponent();
            presenter.GetCashiersFromXML();

            int x = 6;
            int y = 30;

            for (int i = 0; i < presenter.downloaderService.Cashiers.Length; i++)
            {
                rbtnList.Add(new RadioButton());
                rbtnList[i].Text = presenter.downloaderService.Cashiers[i].Surname + " " + presenter.downloaderService.Cashiers[i].Name;
                rbtnList[i].Location = new Point(x, y);
                rbtnList[i].Width = 250;
                rbtnList[i].Height = 30; 
                this.grpBoxCashiersView.Controls.Add(rbtnList[i]);
                

                y += 34;
                //rb[i].Hide();
            }
            grpBoxCashiersView.Hide();
        }

        private void btnEnter(object sender, EventArgs e)
        {
            if (rbtnAdminView.Checked)
            {
                Hide();
                Administrator administrator = new Administrator();
                administrator.ShowDialog();
                Close();
            }
            foreach (RadioButton rbtn in rbtnList)
            {
                if (rbtn.Checked)
                {
                    Hide();
                    Cashier cashier = new Cashier();
                    workingPresenter.EnterAsCashier(rbtn.Text);
                    cashier.ShowDialog();
                    Close();
                }
            }
        }

        private void rbtnAdmin(object sender, EventArgs e)
        {
            grpBoxCashiersView.Hide();
        }

        private void rbtnCashier(object sender, EventArgs e)
        {
            grpBoxCashiersView.Show();
        }

        private void grpBoxCashiers(object sender, EventArgs e)
        {

        }

        private void grpBoxRoles(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
