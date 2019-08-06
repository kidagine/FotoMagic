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
            addDateWindow.Show();
        }
    }
}
