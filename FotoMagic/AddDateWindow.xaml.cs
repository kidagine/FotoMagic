using FotoMagic.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddDateWindow.xaml
    /// </summary>
    public partial class AddDateWindow : Window
    {

        private const string PlaceholderMoneyText = "Γράψε το κόστος του προιόντος";
        private const string PlaceholderProductText = "Γράψε το όνομα του προιόντος";
        private const string PlaceholderDateText = "dd/mm/yyyy";
        private const string ErrorEmptyTextBox = "Συμπληρώστε και τα δύο κουτία";
        private MainModel mainModel;


        public AddDateWindow()
        {
            InitializeComponent();
            mainModel = MainModel.CreateInstance();
            txtProduct.Focus();
        }

        private void BtnAddDate_Click(object sender, RoutedEventArgs e)
        {
            ConfirmDate();
        }

        private void ConfirmDate()
        {
            string date;
            string moneyAmount;
            if (!txtMoney.Text.Equals("") && (!txtMoney.Text.Equals(PlaceholderMoneyText)) && (!txtProduct.Text.Equals("") && (!txtProduct.Text.Equals(PlaceholderProductText))))
            {
                if (!txtMoney.Text.Contains('.'))
                {
                    moneyAmount = txtMoney.Text.Substring(0, (txtMoney.Text.Length - 1)) + ".00";
                }
                else
                {
                    moneyAmount = txtMoney.Text.Substring(0, (txtMoney.Text.Length - 1));
                }
                if (txtDate.Text.Equals("") || txtDate.Text.Equals(PlaceholderDateText) || txtDate.Text.Length < 9)
                {
                    date = DateTime.Today.ToString("dd/MM/yyyy");
                }
                else
                {
                    date = txtDate.Text;
                }
                Debug.WriteLine(moneyAmount);
                string firstName = CustomerDetailsWindow.customerDetailsWindow.customerFirstName;
                string lastName = CustomerDetailsWindow.customerDetailsWindow.customerLastName;
                mainModel.CreateDate(mainModel.GetLastDateId()+1, firstName, lastName, date, txtProduct.Text, moneyAmount);
                CustomerDetailsWindow.customerDetailsWindow.HideDarkenRectangle();
                this.Close();
            }
            else
            {
                lblError.Visibility = Visibility.Visible;
                lblError.Content = ErrorEmptyTextBox;
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            CustomerDetailsWindow.customerDetailsWindow.HideDarkenRectangle();
            this.Close();
        }

        private void TxtMoney_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtMoney.Text.Equals(PlaceholderMoneyText))
            {
                txtMoney.Text = "";
                txtMoney.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void TxtMoney_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtMoney.Text.Equals(""))
            {
                txtMoney.Text = PlaceholderMoneyText;
                txtMoney.Foreground = new SolidColorBrush(Color.FromRgb(126, 126, 126));
            }
        }

        private void TxtProduct_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtProduct.Text.Equals(PlaceholderProductText))
            {
                txtProduct.Text = "";
                txtProduct.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void TxtProduct_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtProduct.Text.Equals(""))
            {
                txtProduct.Text = PlaceholderProductText;
                txtProduct.Foreground = new SolidColorBrush(Color.FromRgb(126, 126, 126));
            }
        }

        private void TxtDate_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtDate.Text.Equals(PlaceholderDateText))
            {
                txtDate.Text = "";
                txtDate.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void TxtDate_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtDate.Text.Equals(""))
            {
                txtDate.Text = PlaceholderDateText;
                txtDate.Foreground = new SolidColorBrush(Color.FromRgb(126, 126, 126));
            }
        }

        private void TxtMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtMoney.Text.Equals("") || (txtMoney.Text.Equals(PlaceholderMoneyText)))
                {
                    txtMoney.Focus();
                    lblError.Visibility = Visibility.Visible;
                    lblError.Content = ErrorEmptyTextBox;
                    rctMoney.Fill = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                    rctMoney.Stroke = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                }
                if (txtProduct.Text.Equals("") || (txtProduct.Text.Equals(PlaceholderProductText)))
                {
                    txtProduct.Focus();
                    lblError.Visibility = Visibility.Visible;
                    lblError.Content = ErrorEmptyTextBox;
                    rctProduct.Fill = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                    rctProduct.Stroke = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                }
                else
                {
                    ConfirmDate();
                }
            }
        }

        private void TxtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtMoney.Focus();
            }
        }

        private void TxtMoney_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!txtMoney.Text.Equals(PlaceholderMoneyText))
            {
                if (!txtMoney.Text.Equals(""))
                {
                    lblError.Visibility = Visibility.Visible;
                    lblError.Content = "";
                    rctMoney.Fill = new SolidColorBrush(Color.FromRgb(29, 155, 243));
                    rctMoney.Stroke = new SolidColorBrush(Color.FromRgb(29, 155, 243));
                }
            }
        }

        private void TxtProduct_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxToProperCase(txtProduct);
            Regex regex = new Regex(@"^[a-zA-Z 0-9\p{IsGreek} ']*$");
            if (!txtProduct.Text.Equals(PlaceholderProductText))
            {
                if (!regex.IsMatch(txtProduct.Text))
                {
                    lblError.Visibility = Visibility.Visible;
                    lblError.Content = "Το όνομα του προιόντος δεν μπορεί να περιέχει σύμβολα";
                    rctProduct.Fill = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                    rctProduct.Stroke = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                }
                else
                {
                    lblError.Visibility = Visibility.Hidden;
                    lblError.Content = "";
                    rctProduct.Fill = new SolidColorBrush(Color.FromRgb(29, 155, 243));
                    rctProduct.Stroke = new SolidColorBrush(Color.FromRgb(29, 155, 243));
                }
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

        private void TxtMoney_PreviewInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 .]");
            if (regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }   
        }

        private void TxtDate_PreviewInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 .]");
            if (regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void TxtProduct_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                if (txtProduct.Text.Length > 0)
                {
                    char lastCharacter = txtProduct.Text[txtProduct.Text.Length - 1];
                    if (Char.IsWhiteSpace(lastCharacter))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtMoney_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
            if (txtMoney.Text.Contains('.'))
            {
                if (e.Key == Key.OemPeriod)
                {
                    e.Handled = true;
                }
            }
            if (e.Key != Key.Back)
            {
                if (txtMoney.Text.Equals("") || txtMoney.Text.Equals(PlaceholderMoneyText))
                {
                    if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9))
                    {
                        txtMoney.Text += txtMoney.Text + "€";
                    }
                }
            }
            else
            {
                if (txtMoney.Text.Length <= 2)
                {
                    txtMoney.Text = "";
                }
            }
        }

        private void TxtDate_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
            else if (txtDate.Text.Length > 9 && e.Key != Key.Back)
            {
                e.Handled = true;
            }
        }

        private void BtnDate_Click(object sender, RoutedEventArgs e)
        {
            if (txtDate.Visibility == Visibility.Hidden)
            {
                txtDate.Visibility = Visibility.Visible;
                btnDate.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
            else
            {
                txtDate.Visibility = Visibility.Hidden;
                btnDate.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            }
        }

        private void TxtDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Back)
            {
                if (txtDate.Text.Length == 2 || txtDate.Text.Length == 5)
                {
                    txtDate.Text += "/";
                    txtDate.SelectionStart = txtDate.Text.Length;
                }
            }

            if (txtDate.Text.Length < 9)
            {
                if (txtDate.Text.Length == 2 && e.Key == Key.Back || txtDate.Text.Length == 5 && e.Key == Key.Back)
                {
                    txtDate.Text = txtDate.Text.Remove(txtDate.Text.Length - 1);
                    txtDate.SelectionStart = txtDate.Text.Length;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
