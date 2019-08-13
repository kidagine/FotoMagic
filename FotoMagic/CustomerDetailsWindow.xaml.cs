using FotoMagic.BE;
using FotoMagic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FotoMagic
{
    /// <summary>
    /// Interaction logic for CustomerDetailsWindow.xaml
    /// </summary>
    public partial class CustomerDetailsWindow : Window
    {

        private const string FILEPATH = @"C:\Users\Kiddo\Desktop\Code\C#\Fotomagic\FotoMagic\FotoMagic\Resources\DatesList.txt";
        private const string PlaceholderSearch = "Search date";
        public static CustomerDetailsWindow customerDetailsWindow;
        public string customerFirstName;
        public string customerLastName;
        private MainModel model;
        private List<Date> datesList = new List<Date>();


        public CustomerDetailsWindow(Customer customer)
        {
            InitializeComponent();
            model = MainModel.CreateInstance();
            LoadCustomer(customer);
            customerDetailsWindow = this;
        }

        public void LoadDate(Date date)
        {
            Date dateToAdd = new Date(model.GetLastId(), date.FirstName, date.LastName, date.OwedDate, date.OwedProduct, float.Parse(date.OwedMoney).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
            lstDates.Items.Add(dateToAdd);
            datesList.Add(dateToAdd);
            SortDescription sortDescription = new SortDescription("OwedDate", ListSortDirection.Ascending);
            lstDates.Items.SortDescriptions.Add(sortDescription);
        }

        private void LoadCustomer(Customer customer)
        {
            customerFirstName = customer.FirstName;
            customerLastName = customer.LastName;
            lblCustomerName.Content = customer.FirstName + " " + customer.LastName;
            LoadDates(customerFirstName, customerLastName);
        }

        private void LoadDates(string firstName, string lastName)
        {
            using (StreamReader sr = new StreamReader(FILEPATH))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lines = line.Split('|');
                    if (lines[1].Equals(firstName))
                    {
                        float money = float.Parse(lines[5]);
                        Date date = new Date(int.Parse(lines[0]), lines[1], lines[2], lines[3], lines[4], money.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
                        lstDates.Items.Add(date);
                        datesList.Add(date);
                    }
                }
            }
            SortDescription sortDescription = new SortDescription("OwedDate", ListSortDirection.Ascending);
            lstDates.Items.SortDescriptions.Add(sortDescription);
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            rctDarken.Visibility = Visibility.Visible;
            AddDateWindow addDateWindow = new AddDateWindow();
            addDateWindow.Owner = this;
            addDateWindow.Show();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstDates.SelectedItems.Count > 0)
            {
                Date date = (Date)lstDates.SelectedItems[0];
                lstDates.Items.Remove(lstDates.SelectedItems[0]);
                model.RemoveDate(date.Id.ToString());
                RemoveDate(date.Id.ToString());
                SortDescription sortDescription = new SortDescription("OwedDate", ListSortDirection.Ascending);
                lstDates.Items.SortDescriptions.Add(sortDescription);
            }
        }


        private void RemoveDate(string lineToRemoveId)
        {
            using (StreamReader sr = new StreamReader(FILEPATH))
            using (StreamWriter sw = new StreamWriter("tempFile.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lines = line.Split('|');
                    Debug.WriteLine("id: " + lines[0] + "otherId: " + lineToRemoveId);
                    if (lines[0] != lineToRemoveId)
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
            TextBoxToProperCase(txtSearch);
            if (!txtSearch.Text.Equals(PlaceholderSearch))
            {
                lstDates.Items.Clear();
                foreach (Date d in datesList)
                {
                    if (d.OwedDate.ToLower().Contains(txtSearch.Text.ToLower()) || d.OwedMoney.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        Date date = new Date(d.Id, d.FirstName, d.LastName, d.OwedDate, d.OwedProduct, d.OwedMoney);
                        lstDates.Items.Add(date);
                    }
                }
                SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
                lstDates.Items.SortDescriptions.Add(sortDescription);
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

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.HideDarkenRectangle();
            this.Close();
            MainWindow.mainWindow.LoadCustomerData();
        }
    }
}
