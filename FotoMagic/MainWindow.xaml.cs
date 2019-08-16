using FotoMagic.BE;
using FotoMagic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
using System.Windows.Media.Animation;
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
        private readonly string FILEPATHCUSTOMERS = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\CustomersList.txt";
        private readonly string FILEPATHDATES = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\DatesList.txt";
        private const string PlaceholderSearch = "Ψάξε τον πελάτη";
        private MainModel model;


        public MainWindow()
        {
            InitializeComponent();
            model = MainModel.CreateInstance();
            mainWindow = this;
            LoadAllData();
            StartAnimation();
        }

        public void StartAnimation()
        {
            grdMain.Opacity = 0;
            dseMain.Opacity = 0.5;
            DoubleAnimation animation = new DoubleAnimation(1, TimeSpan.FromSeconds(0.2f));
            animation.Completed += (s, a) =>
            {
                if (CustomerDetailsWindow.customerDetailsWindow != null)
                {
                    CustomerDetailsWindow.customerDetailsWindow.Hide();
                    this.Owner = null;
                }
            };
            grdMain.BeginAnimation(Grid.OpacityProperty, animation);
        }

        public void LoadAllData()
        {
            LoadDateData();
            LoadCustomerData();
        }

        private void LoadDateData()
        {
            using (StreamReader srDates = new StreamReader(FILEPATHDATES))
            {
                string dateLine = "";
                while ((dateLine = srDates.ReadLine()) != null)
                {
                    string[] dateLines = dateLine.Split('|');
                    Date date = new Date(int.Parse(dateLines[0]), dateLines[1], dateLines[2], dateLines[3], dateLines[4], dateLines[5]);
                    model.LoadDate(date);
                }
            }
        }

        public void LoadCustomerData()
        {
            lstCustomers.Items.Clear();
            model.ClearCustomersList();
            using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERS))
            {
                string lineCustomer = "";
                while ((lineCustomer = sr.ReadLine()) != null)
                {
                    string[] linesCustomer = lineCustomer.Split('|');
                    LoadCorrectCustomerData(linesCustomer);
                }
            }
            SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
            lstCustomers.Items.SortDescriptions.Add(sortDescription);
        }

        public void LoadCorrectCustomerData(string[] linesCustomer)
        {
            float totalOwedMoney = 0.0f;
            for (int i = 0; i < model.GetDatesList().Count; i++)
            {
                if (model.GetDatesList()[i].FirstName.Equals(linesCustomer[1]))
                {
                    totalOwedMoney += float.Parse(model.GetDatesList()[i].OwedMoney);
                }
            }
            Customer customer = new Customer(int.Parse(linesCustomer[0]), linesCustomer[1], linesCustomer[2], totalOwedMoney.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
            Customer customerToAdd = new Customer(int.Parse(linesCustomer[0]), linesCustomer[1], linesCustomer[2], totalOwedMoney.ToString());
            lstCustomers.Items.Add(customer);
            model.LoadCustomer(customerToAdd);
        }

        public void LoadCustomer(Customer customer)
        {
            using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERS))
            {
                Customer customerToAdd = new Customer(customer.Id, customer.FirstName, customer.LastName, float.Parse(customer.OwedMoney).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
                lstCustomers.Items.Add(customerToAdd);
                SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
                lstCustomers.Items.SortDescriptions.Add(sortDescription);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            rctDarken.Visibility = Visibility.Visible;
            rctDarken.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation(0.7, TimeSpan.FromSeconds(0.2f));
            rctDarken.BeginAnimation(Rectangle.OpacityProperty, animation);
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
            DoubleAnimation animation = new DoubleAnimation(0, TimeSpan.FromSeconds(0.2f));
            animation.Completed += (s, a) =>
            {
                rctDarken.Visibility = Visibility.Hidden;
            };
            rctDarken.BeginAnimation(Rectangle.OpacityProperty, animation);
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstCustomers.SelectedItems.Count > 0)
            {
                Customer customer = (Customer)lstCustomers.SelectedItems[0];
                lstCustomers.Items.Remove(lstCustomers.SelectedItems[0]);
                model.RemoveCustomer(customer.Id.ToString());
                RemoveCustomer(customer.Id.ToString());
                SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
                lstCustomers.Items.SortDescriptions.Add(sortDescription);
            }
        }

        private void RemoveCustomer(string lineToRemoveId)
        {
            using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERS))
            using (StreamWriter sw = new StreamWriter("tempFile.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lines = line.Split('|');
                    if (lines[0] != lineToRemoveId)
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
                        Customer customer = new Customer(c.Id, c.FirstName, c.LastName, float.Parse(c.OwedMoney).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
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
                dseMain.Opacity = 0;
                DoubleAnimation animation = new DoubleAnimation(0, TimeSpan.FromSeconds(0.2f));
                animation.Completed += (s, a) =>
                {
                    Customer customer = (Customer)lstCustomers.SelectedItems[0];
                    CustomerDetailsWindow customerDetailsWindow = new CustomerDetailsWindow(customer);
                    customerDetailsWindow.Owner = this;
                    customerDetailsWindow.Show();
                };
                grdMain.BeginAnimation(Grid.OpacityProperty, animation);
            }
        }
    }

}
