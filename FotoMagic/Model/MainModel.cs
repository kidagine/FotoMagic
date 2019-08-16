using FotoMagic.BE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMagic.Model
{
    class MainModel
    {

        private static MainModel instance;
        private readonly string FILEPATHCUSTOMERS = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\CustomersList.txt";
        private readonly string FILEPATHDATES = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\TxtFiles\\DatesList.txt";
        private List<Customer> customersList = new List<Customer>();
        private List<Date> datesList = new List<Date>();


        public static MainModel CreateInstance()
        {
            if (instance == null)
            {
                instance = new MainModel();
            }
            return instance;
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

        public void RemoveDate(string dateToRemoveId)
        {
            foreach (Date d in datesList)
            {
                if (d.Id.ToString().Equals(dateToRemoveId))
                {
                    datesList.Remove(d);
                    return;
                }
            }
        }

        public void LoadCustomer(Customer customer)
        {
            foreach (Customer c in customersList)
            {
                if (c.Id.ToString().Equals(customer.Id))
                {
                    customersList.Remove(c);
                }
            }
            customersList.Add(customer);
        }

        public void LoadDate(Date date)
        {
            datesList.Add(date);
        }

        public void ClearCustomersList()
        {
            customersList.Clear();
        }

        public List<Customer> GetCustomersList()
        {
            return customersList;
        }

        public List<Date> GetDatesList()
        {
            return datesList;
        }

        public void CreateCustomer(int id, String firstName, string lastName, float owedMoney)
        {
            Customer customer = new Customer(id, firstName, lastName, owedMoney.ToString());
            customersList.Add(customer);
            MainWindow.mainWindow.LoadCustomer(customer);
            WriteToTextFileCustomer();
        }

        public void CreateDate(int id, string firstName, string lastName, string owedDate, string owedProduct, string owedMoney)
        {
            Date date = new Date(id, firstName, lastName, owedDate, owedProduct, owedMoney);
            datesList.Add(date);
            CustomerDetailsWindow.customerDetailsWindow.LoadDate(date);
            WriteToTextFileDate();
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

        public int GetLastDateId()
        {
            int id = 0;
            using (StreamReader srDates = new StreamReader(FILEPATHDATES))
            {
                string dateLine = "";
                while ((dateLine = srDates.ReadLine()) != null)
                {
                    string[] dateLines = dateLine.Split('|');
                    int dateId = int.Parse(dateLines[0]);
                    if (dateId >= id)
                    {
                        id = dateId;
                    }
                }
            }
            return id;
        }

        private void WriteToTextFileCustomer()
        {
            using (TextWriter tw = new StreamWriter(FILEPATHCUSTOMERS))
            {
                foreach (Customer c in customersList)
                {
                    tw.WriteLine(c.Id + "|" + c.FirstName + "|" + c.LastName + "|" + c.OwedMoney);
                }
                tw.Close();
            }
        }

        private void WriteToTextFileDate()
        {
            using (TextWriter tw = new StreamWriter(FILEPATHDATES))
            {
                foreach (Date d in datesList)
                {
                    tw.WriteLine(d.Id + "|" + d.FirstName + "|" + d.LastName + "|" + d.OwedDate + "|" + d.OwedProduct + "|" + d.OwedMoney);
                }
                tw.Close();
            }
        }
    }
}
