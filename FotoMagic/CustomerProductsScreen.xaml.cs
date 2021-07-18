using Fotomagic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
	/// Interaction logic for CustomerProductsScreen.xaml
	/// </summary>
	public partial class CustomerProductsScreen : Window
	{
		public CustomerProductsScreen(Customer customer)
		{
			InitializeComponent();
			lblCustomer.Content = customer.FirstName + " " + customer.LastName;
		}

		private void BtnExit_Click(object sender, RoutedEventArgs e)
		{
			CustomersScreen.customersScreen.HideDarkenRectangle();
			this.Close();
		}
	}
}
