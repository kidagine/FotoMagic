using FotoMagic.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FotoMagic
{
    /// <summary>
    /// Interaction logic for CustomerDetailsWindow.xaml
    /// </summary>
    public partial class CustomerDetailsWindow : Window
    {

        public static CustomerDetailsWindow customerDetailsWindow;


        public CustomerDetailsWindow(Customer customer)
        {
            InitializeComponent();
            LoadCustomer(customer);
            customerDetailsWindow = this;
        }

        public void LoadDate(Date date)
        {
            lstDates.Items.Add(date);
        }

        private void LoadCustomer(Customer customer)
        {
            lblCustomerName.Content = customer.FirstName + " " + customer.LastName;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddDateWindow addDateWindow = new AddDateWindow();
            addDateWindow.Owner = this;
            addDateWindow.Show();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstDates.SelectedItems.Count > 0)
            {
                Date date = (Date)lstDates.SelectedItems[0];
                string lineToRemove = date.OwedDate + " " + date.OwedMoney;
                lstDates.Items.Remove(lstDates.SelectedItems[0]);
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            string[] customerName = lblCustomerName.Content.ToString().Split(' ');
            Customer customer = new Customer(customerName[0], customerName[1], GetTotalOwedMoney());
        }

        private float GetTotalOwedMoney()
        {
            float totalOwedMoney = 0.0f;
            foreach (ListItem item in lstDates.Items)
            {
               
                //totalOwedMoney += lstDates.Items
            }
            return totalOwedMoney;
        }
    }
}
