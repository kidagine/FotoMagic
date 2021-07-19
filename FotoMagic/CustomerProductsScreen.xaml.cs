using Fotomagic.Entities;
using Fotomagic.Model;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using Path = System.IO.Path;

namespace Fotomagic
{
	/// <summary>
	/// Interaction logic for CustomerProductsScreen.xaml
	/// </summary>
	public partial class CustomerProductsScreen : Window
	{
		private readonly string FILEPATHPRODUCTS = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\Products.txt";
		private readonly string FILEPATHCUSTOMERRECEIPTS = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\CustomerReceipts.txt";
		private readonly MainModel model;
		public static CustomerProductsScreen customerProductsScreen;

		public CustomerProductsScreen(Customer customer)
		{
			InitializeComponent();
			model = MainModel.CreateInstance();
			customerProductsScreen = this;
			lblCustomer.Content = customer.FirstName + " " + customer.LastName;
			LoadComboBox();
		}

		public void LoadAllData()
		{
			lstProducts.Items.Clear();
			//model.ClearCustomersList();
			using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERRECEIPTS))
			{
				string lineCustomer = "";
				while ((lineCustomer = sr.ReadLine()) != null)
				{
					string[] linesCustomer = lineCustomer.Split('|');
					LoadCorrectProductData(linesCustomer);
				}
			}
			SortDescription sortDescription = new SortDescription("Name", ListSortDirection.Ascending);
			lstProducts.Items.SortDescriptions.Add(sortDescription);
		}

		public void LoadCorrectProductData(string[] linesCustomer)
		{
			CustomerReceipt customerReceipt = new CustomerReceipt(int.Parse(linesCustomer[0]), linesCustomer[1], linesCustomer[2], linesCustomer[3], linesCustomer[4]);
			CustomerReceipt customerReceiptToAdd = new CustomerReceipt(int.Parse(linesCustomer[0]), linesCustomer[1], linesCustomer[2], linesCustomer[3], linesCustomer[4]);
			lstProducts.Items.Add(customerReceipt);
			model.LoadCustomerReceipt(customerReceiptToAdd);
		}

		private void LoadComboBox()
		{
			using (StreamReader sr = new StreamReader(FILEPATHPRODUCTS))
			{
				string lineCustomer = "";
				while ((lineCustomer = sr.ReadLine()) != null)
				{
					string[] linesCustomer = lineCustomer.Split('|');
					cmbProducts.Items.Add(linesCustomer[1]);
				}
			}
		}

		private void BtnConfirm_Click(object sender, RoutedEventArgs e)
		{
			string name = (string)cmbProducts.SelectedItem;
			string amount = "a";
			string cost = "1";
			string date = "11/11/1999";
			model.CreateCustomerReceipt(0, name, amount, cost, date);
			//lstProducts.Items.Add("a");
		}

		public void LoadCustomerReceipt(CustomerReceipt customerReceipt)
		{
			using (StreamReader sr = new StreamReader(FILEPATHCUSTOMERRECEIPTS))
			{
				CustomerReceipt customerReceiptToAdd = new CustomerReceipt(customerReceipt.Id, customerReceipt.Name, customerReceipt.Amount, customerReceipt.Cost, customerReceipt.Date);
				lstProducts.Items.Add(customerReceiptToAdd);
				SortDescription sortDescription = new SortDescription("Name", ListSortDirection.Ascending);
				lstProducts.Items.SortDescriptions.Add(sortDescription);
			}
		}

		private void BtnExit_Click(object sender, RoutedEventArgs e)
		{
			CustomersScreen.customersScreen.HideDarkenRectangle();
			this.Close();
		}
	}
}
