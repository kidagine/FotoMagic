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
        private MainModel mainModel;

        public AddDateWindow()
        {
            InitializeComponent();
            mainModel = MainModel.CreateInstance();
        }

        private void BtnAddDate_Click(object sender, RoutedEventArgs e)
        {
            if (!txtMoney.Text.Equals("") && (!txtMoney.Text.Equals(PlaceholderMoneyText)) && (!dtpDate.Text.Equals("")))
            {
                string firstName = CustomerDetailsWindow.customerDetailsWindow.customerFirstName;
                string lastName = CustomerDetailsWindow.customerDetailsWindow.customerLastName;
                mainModel.CreateDate(firstName, lastName, dtpDate.Text, float.Parse(txtMoney.Text.Substring(0, (txtMoney.Text.Length - 1))));
                CustomerDetailsWindow.customerDetailsWindow.HideDarkenRectangle();
                this.Close();
            }
            else
            {
                lblError.Visibility = Visibility.Visible;
                lblError.Content = "Both fields have to be filled";
            }
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

        private void TxtMoney_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!txtMoney.Text.Equals(PlaceholderMoneyText))
            {
                if (!txtMoney.Text.Equals("") && !dtpDate.Text.Equals(""))
                {
                    lblError.Visibility = Visibility.Visible;
                    lblError.Content = "";
                }
            }
        }

        private void TxtMoney_PreviewInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            if (regex.IsMatch(e.Text))
            {
                e.Handled = true;
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
                    txtMoney.Text += txtMoney.Text + "€";
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
