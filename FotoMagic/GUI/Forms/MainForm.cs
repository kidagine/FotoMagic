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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LineShape1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LsbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCustomerList(Customer customer)
        {
            lstCustomers.Items.Add(customer.FirstName);
        }
    }
}
