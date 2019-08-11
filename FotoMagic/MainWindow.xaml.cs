using FotoMagic.BE;
using FotoMagic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private const string FILEPATHCUSTOMERS = @"C:\Users\Kiddo\Desktop\Code\C#\Fotomagic\FotoMagic\FotoMagic\Resources\CustomersList.txt";
        private const string FILEPATHDATES = @"C:\Users\Kiddo\Desktop\Code\C#\Fotomagic\FotoMagic\FotoMagic\Resources\DatesList.txt";
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
            using (StreamReader srDates = new StreamReader(FILEPATHDATES))
            {
                string dateLine = "";
                while ((dateLine = srDates.ReadLine()) != null)
                {
                    string[] dateLines = dateLine.Split(' ');
                    Date date = new Date(dateLines[0], dateLines[1], dateLines[2], float.Parse(dateLines[3])); ;
                    model.LoadDate(date);
                }
            }
            using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERS))
            {
                string lineCustomer = "";
                while ((lineCustomer = sr.ReadLine()) != null)
                {
                    string[] linesCustomer = lineCustomer.Split(' ');
                    LoadCorrectCustomerData(linesCustomer);
                }
            }
            SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
            lstCustomers.Items.SortDescriptions.Add(sortDescription);
        }

        private void LoadCorrectCustomerData(string[] linesCustomer)
        {
            bool wasAdded = false;
            float totalOwedMoney = 0.0f;
            for (int i = 0; i < model.GetDatesList().Count; i++)
            {
                if (!wasAdded)
                {
                    if (model.GetDatesList()[i].FirstName.Equals(linesCustomer[0]))
                    {
                        totalOwedMoney += model.GetDatesList()[i].OwedMoney;
                    }
                }
            }
            if (totalOwedMoney > 0.0f)
            {
                Customer customer = new Customer(linesCustomer[0], linesCustomer[1], totalOwedMoney.ToString());
                lstCustomers.Items.Add(customer);
                model.LoadCustomer(customer);
                wasAdded = true;
            }
            if (!wasAdded)
            {
                Customer customer = new Customer(linesCustomer[0], linesCustomer[1], linesCustomer[2]);
                lstCustomers.Items.Add(customer);
                model.LoadCustomer(customer);
            }
        }

        public void LoadCustomer(Customer customer)
        {
            using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERS))
            {
                for (int i = 0; i < lstCustomers.Items.Count; i++)
                {
                    Customer customerToCheck = (Customer)lstCustomers.Items[i];
                    string customerFullName = customerToCheck.FirstName + " " + customerToCheck.LastName;
                    if (customerFullName.Equals(customer.FirstName + " " + customer.LastName))
                    {
                        lstCustomers.Items.RemoveAt(i);
                    }
                }
                lstCustomers.Items.Add(customer);
                SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
                lstCustomers.Items.SortDescriptions.Add(sortDescription);
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
                SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
                lstCustomers.Items.SortDescriptions.Add(sortDescription);
            }
        }

        private void RemoveCustomer(string lineToRemove)
        {
            using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERS))
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
            File.Delete(FILEPATHCUSTOMERS);
            File.Move("tempFile.txt", FILEPATHCUSTOMERS);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxToProperCase(txtSearch);
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
            SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
            lstCustomers.Items.SortDescriptions.Add(sortDescription);
            }
        }

        private void TextBoxToProperCase(TextBox textBox)
        {
            if (!textBox.Text.Equals(""))
            {
                char[] v = textBox.Text.ToCharArray();
                string s = v[0].ToString().ToUpper();
                for (int b = 1; b < v.Length; b++)
                    s += v[b].ToString().ToLower();
                textBox.Text = s;
                textBox.Select(textBox.Text.Length, 0);
            }
        }

        private void TxtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text.Equals(PlaceholderSearch))
            {
                txtSearch.Text = "";
                txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void TxtSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                txtSearch.Text = PlaceholderSearch;
                txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(126, 126, 126));
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
