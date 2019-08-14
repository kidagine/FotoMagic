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

        private const string PlaceholderMoneyText = "Enter the money amount";
        private const string PlaceholderProductText = "Enter the product's name";
        private const string ErrorEmptyTextBox = "You have to fill both fields";
        private MainModel mainModel;
        private string owedDate;

        public AddDateWindow()
        {
            InitializeComponent();
            mainModel = MainModel.CreateInstance();
            owedDate = DateTime.Today.ToString("dd/MM/yyyy");
            txtProduct.Focus();
        }

        private void BtnAddDate_Click(object sender, RoutedEventArgs e)
        {
            ConfirmDate();
        }

        private void ConfirmDate()
        {
            string moneyAmount;

            if (!txtMoney.Text.Equals("") && (!txtMoney.Text.Equals(PlaceholderMoneyText)) && (!txtProduct.Text.Equals("") && (!txtProduct.Text.Equals(PlaceholderProductText))))
            {
                if (!txtMoney.Text.Contains('.'))
                {
                    moneyAmount = txtMoney.Text.Substring(0, (txtMoney.Text.Length - 1)) + ".00";
                }
                else
                {
                    moneyAmount = txtMoney.Text;
                }
                string firstName = CustomerDetailsWindow.customerDetailsWindow.customerFirstName;
                string lastName = CustomerDetailsWindow.customerDetailsWindow.customerLastName;
                mainModel.CreateDate(mainModel.GetLastDateId()+1, firstName, lastName, owedDate, txtProduct.Text, moneyAmount);
                CustomerDetailsWindow.customerDetailsWindow.HideDarkenRectangle();
                this.Close();
            }
            else
            {
                lblError.Visibility = Visibility.Visible;
                lblError.Content = "Both fields have to be filled";
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
            Regex regex = new Regex("^[a-zA-Z 0-9 ']*$");
            if (!txtProduct.Text.Equals(PlaceholderProductText))
            {
                if (!regex.IsMatch(txtProduct.Text))
                {
                    lblError.Visibility = Visibility.Visible;
                    lblError.Content = "The product name cannot contain symbols.";
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
    }
}
