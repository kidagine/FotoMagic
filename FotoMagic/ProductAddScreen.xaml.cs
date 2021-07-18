using Fotomagic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fotomagic
{
	/// <summary>
	/// Interaction logic for ProductAddScreen.xaml
	/// </summary>
	public partial class ProductAddScreen : Window
    {
        private readonly MainModel model;
        private const string PlaceholderName = "Γράψε το όνομα του προϊόντος";
        private const string PlaceholderPrice = "Γράψε την τιμή του προϊόντος";
        private const string ErrorEmptyTextBox = "Συμπληρώστε και τα δύο κουτία";
        private bool canAddCustomer;

        public ProductAddScreen()
		{
			InitializeComponent();
            model = MainModel.CreateInstance();
            txtFirstName.Focus();
        }

        private void TxtFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtFirstName.Text.Equals(PlaceholderName))
            {
                txtFirstName.Text = "";
                txtFirstName.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void TxtFirstName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtFirstName.Text.Equals(""))
            {
                txtFirstName.Text = PlaceholderName;
                txtFirstName.Foreground = new SolidColorBrush(Color.FromRgb(126, 126, 126));
            }
        }

        private void TxtLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtLastName.Text.Equals(PlaceholderPrice))
            {
                txtLastName.Text = "";
                txtLastName.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void TxtLastName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtLastName.Text.Equals(""))
            {
                txtLastName.Text = PlaceholderPrice;
                txtLastName.Foreground = new SolidColorBrush(Color.FromRgb(126, 126, 126));
            }
        }

        private void TxtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtLastName.Focus();
            }
        }

        private void TxtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtFirstName.Text.Equals("") || (txtFirstName.Text.Equals(PlaceholderName)))
                {
                    txtFirstName.Focus();
                    lblError.Visibility = Visibility.Visible;
                    lblError.Content = ErrorEmptyTextBox;
                    rctFirstName.Fill = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                    rctFirstName.Stroke = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                }
                if (txtLastName.Text.Equals("") || (txtLastName.Text.Equals(PlaceholderPrice)))
                {
                    txtLastName.Focus();
                    lblError.Visibility = Visibility.Visible;
                    lblError.Content = ErrorEmptyTextBox;
                    rctLastName.Fill = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                    rctLastName.Stroke = new SolidColorBrush(Color.FromRgb(255, 81, 48));
                }
                else
                {
                    Regex regex = new Regex("^[a-zA-Z ']*$");
                    if (!regex.IsMatch(txtFirstName.Text))
                    {
                        txtFirstName.Focus();
                    }
                    else if (!regex.IsMatch(txtLastName.Text))
                    {
                        txtLastName.Focus();
                    }
                    else
                    {
                        ConfirmCustomer();
                    }
                }
            }
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (txtFirstName.Text.Equals("") || txtFirstName.Text.Equals(PlaceholderName) || txtLastName.Text.Equals("") || txtLastName.Text.Equals(PlaceholderPrice))
            {
                lblError.Visibility = Visibility.Visible;
                lblError.Content = ErrorEmptyTextBox;
            }
            else
            {
                ConfirmCustomer();
            }
        }

        private void ConfirmCustomer()
        {
            if (true)
            {
                if (!txtFirstName.Text.Equals("") && !txtLastName.Text.Equals(""))
                {
                    string name = txtFirstName.Text;
                    string price = txtLastName.Text;
                    model.CreateProduct(model.GetLastProductId() + 1, name, price);
                    ProductsScreen.productsScreen.HideDarkenRectangle();
                    this.Hide();
                }
                else
                {
                    if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || txtFirstName.Text.Equals(PlaceholderName) || txtLastName.Text.Equals(PlaceholderPrice))
                    {
                        lblError.Visibility = Visibility.Visible;
                        lblError.Content = ErrorEmptyTextBox;
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ProductsScreen.productsScreen.HideDarkenRectangle();
            this.Close();
        }

        private void TxtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxToProperCase(txtFirstName);
            //Regex regex = new Regex(@"^[a-zA-Z\p{IsGreek} ']*$");
            //if (!txtFirstName.Text.Equals(PlaceholderName))
            //{
            //    if (!regex.IsMatch(txtFirstName.Text))
            //    {
            //        canAddCustomer = false;
            //        lblError.Visibility = Visibility.Visible;
            //        lblError.Content = "Το όνομα δεν μπορει να έχει νούμερα ή σύμβολα.";
            //        rctFirstName.Fill = new SolidColorBrush(Color.FromRgb(255, 81, 48));
            //        rctFirstName.Stroke = new SolidColorBrush(Color.FromRgb(255, 81, 48));
            //    }
            //    else
            //    {
            //        rctFirstName.Fill = new SolidColorBrush(Color.FromRgb(29, 155, 243));
            //        rctFirstName.Stroke = new SolidColorBrush(Color.FromRgb(29, 155, 243));
            //        if (lblError.Content.Equals(ErrorEmptyTextBox))
            //        {
            //            lblError.Content = "Το όνομα δεν μπορει να έχει νούμερα ή σύμβολα.";
            //        }
            //        if (regex.IsMatch(txtLastName.Text))
            //        {
            //            canAddCustomer = true;
            //            lblError.Visibility = Visibility.Visible;
            //            lblError.Content = "";
            //        }
            //    }
            //}
        }

        private void TxtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxToProperCase(txtLastName);
            //Regex regex = new Regex(@"^[a-zA-Z\p{IsGreek} ']*$");
            //if (!txtLastName.Text.Equals(PlaceholderPrice))
            //{
            //    if (!regex.IsMatch(txtLastName.Text))
            //    {
            //        canAddCustomer = false;
            //        lblError.Visibility = Visibility.Visible;
            //        lblError.Content = "Το όνομα δεν μπορει να έχει νούμερα ή σύμβολα.";
            //        rctLastName.Fill = new SolidColorBrush(Color.FromRgb(255, 81, 48));
            //        rctLastName.Stroke = new SolidColorBrush(Color.FromRgb(255, 81, 48));
            //    }
            //    else
            //    {
            //        rctLastName.Fill = new SolidColorBrush(Color.FromRgb(29, 155, 243));
            //        rctLastName.Stroke = new SolidColorBrush(Color.FromRgb(29, 155, 243));
            //        if (lblError.Content.Equals(ErrorEmptyTextBox))
            //        {
            //            lblError.Content = "Το όνομα δεν μπορει να έχει νούμερα ή σύμβολα.";
            //        }
            //        if (regex.IsMatch(txtFirstName.Text))
            //        {
            //            canAddCustomer = true;
            //            lblError.Visibility = Visibility.Visible;
            //            lblError.Content = "";
            //        }
            //    }
            //}
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

        private void TxtFirstName_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void TxtPrice_PreviewInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 .]");
            if (regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void TxtLastName_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
