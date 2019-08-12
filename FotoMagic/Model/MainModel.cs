using FotoMagic.BE;
using System;
using System.Collections.Generic;
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
        private const string FILEPATHCUSTOMERS = @"C:\Users\Kiddo\Desktop\Code\C#\Fotomagic\FotoMagic\FotoMagic\Resources\CustomersList.txt";
        private const string FILEPATHDATES = @"C:\Users\Kiddo\Desktop\Code\C#\Fotomagic\FotoMagic\FotoMagic\Resources\DatesList.txt";
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

        public void RemoveCustomer(string customerToRemove)
        {
            customersList.RemoveAt(0);
            foreach (Customer c in customersList)
            {
                if (c.ToString().Equals(customerToRemove))
                {
                    customersList.Remove(c);
                    return;
                }
            }
        }

        public void RemoveDate(string dateToRemove)
        {
            datesList.RemoveAt(0);
            foreach (Date d in datesList)
            {
                if (d.ToString().Equals(dateToRemove))
                {
                    datesList.Remove(d);
                    return;
                }
            }
        }

        public void LoadCustomer(Customer customer)
        {
            customersList.Add(customer);
        }

        public void LoadDate(Date date)
        {
            datesList.Add(date);
        }

        public List<Customer> GetCustomersList()
        {
            return customersList;
        }

        public List<Date> GetDatesList()
        {
            return datesList;
        }

        public void CreateCustomer(String firstName, string lastName, float owedMoney)
        {
            Customer customer = new Customer(firstName, lastName, owedMoney.ToString());
            customersList.Add(customer);
            MainWindow.mainWindow.LoadCustomer(customer);
            WriteToTextFileCustomer();
        }

        public void CreateDate(string firstName, string lastName, string owedDate, float owedMoney)
        {
            Date date = new Date(firstName, lastName, owedDate, owedMoney.ToString());
            datesList.Add(date);
            CustomerDetailsWindow.customerDetailsWindow.LoadDate(date);
            WriteToTextFileDate();
        }

        private void WriteToTextFileCustomer()
        {
            using (TextWriter tw = new StreamWriter(FILEPATHCUSTOMERS))
            {
                foreach (Customer c in customersList)
                {
                    tw.WriteLine(c.FirstName + " " + c.LastName + " " + c.OwedMoney);
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
                    tw.WriteLine(d.FirstName + " " + d.LastName + " " + d.OwedDate + " " + d.OwedMoney);
                }
                tw.Close();
            }
        }
    }
}
