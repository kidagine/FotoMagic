using FotoMagic.BE;
using FotoMagic.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static MainWindow mainWindow;
        private const string FILEPATH = @"C:\Users\Kiddo\Desktop\Code\C#\Fotomagic\FotoMagic\FotoMagic\Resources\CustomersList.txt";
        private const string PlaceholderSearch = "Search customer";
        private MainModel model;


        public MainWindow()
        {
            InitializeComponent();
            model = MainModel.CreateInstance();
            mainWindow = this;
            LoadCustomerList();
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
                    Customer customer = new Customer(lines[0], lines[1], int.Parse(lines[2]));
                    lstCustomers.Items.Add(customer);
                    model.LoadCustomer(customer);
                }
            }
        }

        public void LoadCustomer(Customer customer)
        {
            using (StreamReader sr = new StreamReader(FILEPATH))
            {
                lstCustomers.Items.Add(customer);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            rctDarken.Visibility = Visibility.Visible;
            AddCustomerWindow addCustomerWindow = new AddCustomerWindow();
            addCustomerWindow.Owner = this;
            addCustomerWindow.Show();
        }

        private void RctDarken_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HideDarkenRectangle();
            foreach (Window ownedWindow in this.OwnedWindows)
            {
                if (ownedWindow != null)
                {
                    ownedWindow.Close();
                }
            }
        }

        public void HideDarkenRectangle()
        {
            rctDarken.Visibility = Visibility.Hidden;
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstCustomers.SelectedItems.Count > 0)
            {
                Customer customer = (Customer)lstCustomers.SelectedItems[0];
                string lineToRemove = customer.FirstName + " " + customer.LastName + " " + customer.OwedMoney;
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!txtSearch.Text.Equals(PlaceholderSearch))
            {
                lstCustomers.Items.Clear();
                foreach (Customer c in model.GetCustomersList())
                {
                    if (c.FirstName.ToLower().Contains(txtSearch.Text.ToLower()) || c.LastName.ToLower().Contains(txtSearch.Text.ToLower()) || c.OwedMoney.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        Customer customer = new Customer(c.FirstName, c.LastName, c.OwedMoney);
                        lstCustomers.Items.Add(customer);
                    }
                }
            }
        }

        private void TxtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text.Equals(PlaceholderSearch))
            {
                txtSearch.Text = "";
            }
        }

        private void TxtSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                txtSearch.Text = PlaceholderSearch;
            }
        }

        private void LstCustomers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstCustomers.SelectedItems.Count > 0)
            {
                rctDarken.Visibility = Visibility.Visible;
                Customer customer = (Customer)lstCustomers.SelectedItems[0];
                CustomerDetailsWindow customerDetailsWindow = new CustomerDetailsWindow(customer);
                customerDetailsWindow.Owner = this;
                customerDetailsWindow.Show();
            }
        }
    }
}
