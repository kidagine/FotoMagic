using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FotoMagic.GUI;
using System.Diagnostics;

namespace FotoMagic
{
    public partial class MainForm : Form
    {

        private const string FILEPATH = @"C:\Users\Kiddo\Desktop\Code\C#\Fotomagic\FotoMagic\FotoMagic\Resources\CustomersList.txt";
        private MainModel model;


        public MainForm()
        {
            InitializeComponent();
            model = MainModel.CreateInstance();
            LoadCustomerList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void LoadCustomerList()
        {
            lstCustomers.Items.Clear();
            using (StreamReader sr = new StreamReader(FILEPATH))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lines = line.Split(' ');
                    var rowCustomers = new ListViewItem(lines);
                    lstCustomers.Items.Add(rowCustomers);

                    Customer customer = new Customer(lines[0], lines[1], int.Parse(lines[2]));
                    model.LoadCustomer(customer);
                }
            }
        }

        public void LoadCustomer(Customer customer)
        {
            using (StreamReader sr = new StreamReader(FILEPATH))
            {
                string line = (customer.FirstName + " " + customer.LastName + " " + customer.OwedMoney);
                string[] lines = line.Split(' ');
                var rowCustomers = new ListViewItem(lines);
                lstCustomers.Items.Add(rowCustomers);
            }
        }

        private void BtnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems != null)
            {
                string firstName = lstCustomers.SelectedItems[0].SubItems[0].Text;
                string lastName = lstCustomers.SelectedItems[0].SubItems[1].Text;
                string owedMoney = lstCustomers.SelectedItems[0].SubItems[2].Text;
                string lineToRemove = firstName + " " + lastName + " " + owedMoney;
                lstCustomers.Items.Remove(lstCustomers.SelectedItems[0]);
                model.RemoveCustomer(lineToRemove);
                RemoveCustomer(lineToRemove);
            }
        }

        private void RemoveCustomer(string lineToRemove)
        {
            using (StreamReader sr = new StreamReader(FILEPATH))
            using (StreamWriter sw = new StreamWriter("tempFile.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != lineToRemove)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            File.Delete(FILEPATH);
            File.Move("tempFile.txt", FILEPATH);
        }

        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            lstCustomers.Items.Clear();
            foreach  (Customer c in model.GetCustomersList())
            {
                if (c.FirstName.ToLower().Contains(txbSearch.Text.ToLower()) || c.LastName.ToLower().Contains(txbSearch.Text.ToLower()) || c.OwedMoney.ToString().ToLower().Contains(txbSearch.Text.ToLower()))
                {
                    string line = (c.FirstName + " " + c.LastName + " " + c.OwedMoney);
                    string[] lines = line.Split(' ');
                    var rowCustomers = new ListViewItem(lines);
                    lstCustomers.Items.Add(rowCustomers);
                }
            }
        }
    }
}
