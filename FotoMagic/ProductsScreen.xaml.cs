﻿using Fotomagic.Entities;
using Fotomagic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
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
	/// Interaction logic for ProductsScreen.xaml
	/// </summary>
	public partial class ProductsScreen : Window
	{
		private readonly MainModel model;
		public static ProductsScreen productsScreen;
		private readonly string FILEPATHPRODUCTS = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\Products.txt";
		private string placeholderSearch = "Ψάξε προϊόν";
		private bool _isOnProductsPage = true;

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			Application.Current.Shutdown();
		}

		public ProductsScreen()
		{
			InitializeComponent();
			model = MainModel.CreateInstance();
			productsScreen = this;
			LoadAllData();
		}

		public void LoadAllData()
		{
			lstCustomers.Items.Clear();
			//model.ClearCustomersList();
			using (StreamReader sr = new StreamReader(FILEPATHPRODUCTS))
			{
				string lineCustomer = "";
				while ((lineCustomer = sr.ReadLine()) != null)
				{
					string[] linesCustomer = lineCustomer.Split('|');
					LoadCorrectProductData(linesCustomer);
				}
			}
			SortDescription sortDescription = new SortDescription("Name", ListSortDirection.Ascending);
			lstCustomers.Items.SortDescriptions.Add(sortDescription);
		}

		public void LoadCorrectProductData(string[] linesCustomer)
		{
			Product product = new Product(int.Parse(linesCustomer[0]), linesCustomer[1], float.Parse(linesCustomer[2]).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
			Product productToAdd = new Product(int.Parse(linesCustomer[0]), linesCustomer[1], linesCustomer[2]);
			lstCustomers.Items.Add(product);
			model.LoadProduct(productToAdd);
		}

		public void LoadProduct(Product product)
		{
			using (StreamReader sr = new StreamReader(FILEPATHPRODUCTS))
			{
				Product productToAdd = new Product(product.Id, product.Name, float.Parse(product.Price).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")));
				lstCustomers.Items.Add(productToAdd);
				SortDescription sortDescription = new SortDescription("Name", ListSortDirection.Ascending);
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
			ProductAddScreen productAddScreen = new ProductAddScreen();
			productAddScreen.Owner = this;
			productAddScreen.Show();
		}

		private void RctDarken_MouseDown(object sender, MouseButtonEventArgs e)
		{

		}

		private void BtnRemove_Click(object sender, RoutedEventArgs e)
		{
			if (lstCustomers.SelectedItems.Count > 0)
			{
				Product product = (Product)lstCustomers.SelectedItems[0];
				lstCustomers.Items.Remove(lstCustomers.SelectedItems[0]);
				model.RemoveProduct(product.Id.ToString());
				RemoveProduct(product.Id.ToString());
				SortDescription sortDescription = new SortDescription("FirstName", ListSortDirection.Ascending);
				lstCustomers.Items.SortDescriptions.Add(sortDescription);
			}
		}

		private void RemoveProduct(string lineToRemoveId)
		{
			using (StreamReader sr = new StreamReader(FILEPATHPRODUCTS))
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
			File.Delete(FILEPATHPRODUCTS);
			File.Move("tempFile.txt", FILEPATHPRODUCTS);
		}

		private void BtnCustomers_Click(object sender, RoutedEventArgs e)
		{
			CustomersScreen customersScreen = new CustomersScreen();
			customersScreen.Show();
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

        }
    }
}
