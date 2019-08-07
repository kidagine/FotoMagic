using FotoMagic.Model;
using System;
using System.Collections.Generic;
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
            if (!txtMoney.Text.Equals("") || (!txtMoney.Text.Equals(PlaceholderMoneyText)) && (!dtpDate.Text.Equals("")))
            {
                mainModel.CreateDate(dtpDate.Text, float.Parse(txtMoney.Text));
                this.Hide();
            }
        }

        private void TxtMoney_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtMoney.Text.Equals(PlaceholderMoneyText))
            {
                txtMoney.Text = "";
            }
        }

        private void TxtMoney_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtMoney.Text.Equals(""))
            {
                txtMoney.Text = PlaceholderMoneyText;
            }
        }

        private void TxtMoney_TextChanged(object sender, TextChangedEventArgs e)
        {

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
        }
    }
}
