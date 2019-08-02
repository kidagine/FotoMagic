using FotoMagic.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoMagic
{
    public partial class AddCustomerForm : Form
    {
        private MainModel model;


        public AddCustomerForm()
        {
            InitializeComponent();
            model = MainModel.CreateInstance();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
                
        }

        private void TxbCustomerFirstName_Enter(object sender, EventArgs e)
        {
            if (txbCustomerFirstName.Text.Equals("Enter the customer's first name"))
            {
                txbCustomerFirstName.Text = " ";
            }
        }

        private void TxbCustomerLastName_Enter(object sender, EventArgs e)
        {
            if (txbCustomerLastName.Text.Equals("Enter the customer's last name"))
            {
                txbCustomerLastName.Text = " ";
            }
        }

        private void TxbCustomerFirstName_Leave(object sender, EventArgs e)
        {
            if (txbCustomerFirstName.Text.Equals(" "))
            {
                txbCustomerFirstName.Text = "Enter the customer's first name";
            }
        }

        private void TxbCustomerLastName_Leave(object sender, EventArgs e)
        {
            if (txbCustomerLastName.Text.Equals(" "))
            {
                txbCustomerLastName.Text = "Enter the customer's last name";
            }
        }

        private void TxbCustomerFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbCustomerLastName.Focus();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string firstName = txbCustomerFirstName.Text.Trim();
            string lastName = txbCustomerLastName.Text.Trim();
            float owedMoney = 0.0f;
            model.CreateCustomer(firstName, lastName, owedMoney);
            this.Hide();
        }
    }

}
