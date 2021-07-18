using Fotomagic.Entities;
using Fotomagic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fotomagic
{
	/// <summary>
	/// Interaction logic for CustomersScreen.xaml
	/// </summary>
	public partial class CustomersScreen : Window
	{
		public CustomersScreen()
		{
            InitializeComponent();
			InitializeComponent();
			model = MainModel.CreateInstance();
			customersScreen = this;
			LoadAllData();
		}

		private readonly MainModel model;
		public static CustomersScreen customersScreen;
		private readonly string FILEPATHCUSTOMERS = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\Customers.txt";
		private const string placeholderSearch = "Ψάξε πελάτη";
		private bool _isOnProductsPage = true;

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			Application.Current.Shutdown();
		}

		public void LoadAllData()
		{
			lstCustomers.Items.Clear();
			//model.ClearCustomersList();
			using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERS))
			{
				string lineCustomer = "";
				while ((lineCustomer = sr.ReadLine()) != null)
				{
					string[] linesCustomer = lineCustomer.Split('|');
					LoadCorrectProductData(linesCustomer);
				}
			}
			SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
			lstCustomers.Items.SortDescriptions.Add(sortDescription);
		}

		public void LoadCorrectProductData(string[] linesCustomer)
		{
			Customer customer = new Customer(int.Parse(linesCustomer[0]), linesCustomer[1], linesCustomer[2]);
			Customer customerToAdd = new Customer(int.Parse(linesCustomer[0]), linesCustomer[1], linesCustomer[2]);
			lstCustomers.Items.Add(customer);
			model.LoadCustomer(customerToAdd);
		}

		public void LoadCustomer(Customer customer)
		{
			using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERS))
			{
				Customer customerToAdd = new Customer(customer.Id, customer.FirstName, customer.LastName);
				lstCustomers.Items.Add(customerToAdd);
				SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
				lstCustomers.Items.SortDescriptions.Add(sortDescription);
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

		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{
			rctDarken.Visibility = Visibility.Visible;
			rctDarken.Opacity = 0;
			DoubleAnimation animation = new DoubleAnimation(0.7, TimeSpan.FromSeconds(0.2f));
			rctDarken.BeginAnimation(Rectangle.OpacityProperty, animation);
			CustomerAddScreen customerAddScreen = new CustomerAddScreen();
			customerAddScreen.Owner = this;
			customerAddScreen.Show();
		}

		private void RctDarken_MouseDown(object sender, MouseButtonEventArgs e)
		{

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

		private void BtnCustomers_Click(object sender, RoutedEventArgs e)
		{

		}

		private void BtnProducts_Click(object sender, RoutedEventArgs e)
		{
			ProductsScreen productsScreen = new ProductsScreen();
			productsScreen.Show();
			this.Hide();
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void TxtSearch_GotFocus(object sender, RoutedEventArgs e)
		{
			if (txtSearch.Text.Equals(placeholderSearch))
			{
				txtSearch.Text = "";
				txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
			}
		}

		private void TxtSearch_LostFocus(object sender, RoutedEventArgs e)
		{
			if (txtSearch.Text.Equals(""))
			{
				txtSearch.Text = placeholderSearch;
				txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(126, 126, 126));
			}
		}

		private void LstCustomers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (lstCustomers.SelectedItems.Count > 0)
			{
				Customer customer = (Customer)lstCustomers.SelectedItems[0];
				rctDarken.Visibility = Visibility.Visible;
				rctDarken.Opacity = 0;
				DoubleAnimation animation = new DoubleAnimation(0.7, TimeSpan.FromSeconds(0.2f));
				rctDarken.BeginAnimation(Rectangle.OpacityProperty, animation);
				CustomerProductsScreen customerProductsScreen = new CustomerProductsScreen(customer);
				customerProductsScreen.Owner = this;
				customerProductsScreen.Show();
			}
		}
	}
}
