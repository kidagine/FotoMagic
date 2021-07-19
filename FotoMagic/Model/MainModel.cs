using Fotomagic.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Fotomagic.Model
{
	class MainModel
    {
        private static MainModel instance;
        private readonly string FILEPATHPRODUCTS = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\Products.txt";
        private readonly string FILEPATHCUSTOMERS = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\Customers.txt";
        private readonly string FILEPATHCUSTOMERRECEIPTS = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\CustomerReceipts.txt";
        private List<Product> productsList = new List<Product>();
        private List<Customer> customersList = new List<Customer>();
        private List<CustomerReceipt> customerReceipts = new List<CustomerReceipt>();


        public static MainModel CreateInstance()
        {
            if (instance == null)
            {
                instance = new MainModel();
            }
            return instance;
        }

        public int GetLastProductId()
        {
            int id = 0;
            using (StreamReader srProducts = new StreamReader(FILEPATHPRODUCTS))
            {
                string productLine = "";
                while ((productLine = srProducts.ReadLine()) != null)
                {
                    string[] productLines = productLine.Split('|');
                    int productId = int.Parse(productLines[0]);
                    if (productId >= id)
                    {
                        id = productId;
                    }
                }
            }
            return id;
        }

        public int GetLastCustomerId()
        {
            int id = 0;
            using (StreamReader srCustomers = new StreamReader(FILEPATHCUSTOMERS))
            {
                string customerLine = "";
                while ((customerLine = srCustomers.ReadLine()) != null)
                {
                    string[] customerLines = customerLine.Split('|');
                    int customerId = int.Parse(customerLines[0]);
                    if (customerId >= id)
                    {
                        id = customerId;
                    }
                }
            }
            return id;
        }

        public void CreateProduct(int id, string name, string price)
        {
            Product product = new Product(id, name, price);
            productsList.Add(product);
            ProductsScreen.productsScreen.LoadProduct(product);
            WriteToTextFileProduct();
        }

        public void CreateCustomerReceipt(int id, string name, string amount, string cost, string date)
        {
            CustomerReceipt customerReceipt = new CustomerReceipt(id, name, amount, cost, date);
            customerReceipts.Add(customerReceipt);
            CustomerProductsScreen.customerProductsScreen.LoadCustomerReceipt(customerReceipt);
            WriteToTextFileCustomerReceipt();
        }

        public void CreateCustomer(int id, string firstName, string lastName)
        {
            Customer customer = new Customer(id, firstName, lastName);
            customersList.Add(customer);
            CustomersScreen.customersScreen.LoadCustomer(customer);
            WriteToTextFileCustomer();
        }

        public void RemoveProduct(string productToRemoveId)
        {
            foreach (Product c in productsList)
            {
                if (c.Id.ToString().Equals(productToRemoveId))
                {
                    productsList.Remove(c);
                    return;
                }
            }
        }

        public void RemoveCustomer(string customerToRemoveId)
        {
            foreach (Customer c in customersList)
            {
                if (c.Id.ToString().Equals(customerToRemoveId))
                {
                    customersList.Remove(c);
                    return;
                }
            }
        }

        public void LoadProduct(Product product)
        {
            foreach (Product p in productsList)
            {
                if (p.Id.ToString().Equals(p.Id))
                {
                    productsList.Remove(p);
                }
            }
            productsList.Add(product);
        }


        public void LoadCustomerReceipt(CustomerReceipt customerReceipt)
        {
            foreach (CustomerReceipt p in customerReceipts)
            {
                if (p.Id.ToString().Equals(p.Id))
                {
                    customerReceipts.Remove(p);
                }
            }
            customerReceipts.Add(customerReceipt);
        }

        public void LoadCustomer(Customer customer)
        {
            foreach (Customer c in customersList)
            {
                if (c.Id.ToString().Equals(c.Id))
                {
                    customersList.Remove(c);
                }
            }
            customersList.Add(customer);
        }

        private void WriteToTextFileProduct()
        {
            using (TextWriter tw = new StreamWriter(FILEPATHPRODUCTS))
            {
                foreach (Product product in productsList)
                {
                    tw.WriteLine(product.Id + "|" + product.Name + "|" + product.Price);
                }
                tw.Close();
            }
        }

        private void WriteToTextFileCustomer()
        {
            using (TextWriter tw = new StreamWriter(FILEPATHCUSTOMERS))
            {
                foreach (Customer customer in customersList)
                {
                    tw.WriteLine(customer.Id + "|" + customer.FirstName + "|" + customer.LastName);
                }
                tw.Close();
            }
        }

        private void WriteToTextFileCustomerReceipt()
        {
            using (TextWriter tw = new StreamWriter(FILEPATHCUSTOMERRECEIPTS))
            {
                foreach (CustomerReceipt customerReceipt in customerReceipts)
                {
                    tw.WriteLine(customerReceipt.Id + "|" + customerReceipt.Name + "|" + customerReceipt.Amount + "|" + customerReceipt.Cost + "|" + customerReceipt.Date);
                }
                tw.Close();
            }
        }
    }
}
