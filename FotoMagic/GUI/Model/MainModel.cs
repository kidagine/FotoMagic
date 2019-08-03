﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace FotoMagic.GUI
{
    class MainModel
    {

        private static MainModel instance;
        private const string FILEPATH = @"C:\Users\Kiddo\Desktop\Code\C#\Fotomagic\FotoMagic\FotoMagic\Resources\CustomersList.txt";
        private List<Customer> customersList = new List<Customer>();


        public static MainModel CreateInstance()
        {
            if (instance == null)
            {
                instance = new MainModel();
            }
            return instance;
        }

        public List<Customer> GetCustomersList()
        {
            return customersList;
        }

        public void RemoveCustomer(string customerToRemove)
        {
            customersList.RemoveAt(0);
            foreach (Customer c in customersList)
            {
                if (c.ToString().Equals(customerToRemove))
                {
                    Debug.WriteLine("yes");
                    customersList.Remove(c);
                    return;
                }
            }

        }
        

        public void LoadCustomer(Customer customer)
        {
            customersList.Add(customer);
        }
            
        public void CreateCustomer(String firstName, string lastName, float owedMoney)
        {
            Customer customer = new Customer(firstName, lastName, owedMoney);
            customersList.Add(customer);
            WriteToTextFile();
            (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).LoadCustomer(customer);
        }

        private void WriteToTextFile()
        {
            using (TextWriter tw = new StreamWriter(FILEPATH))
            {
                foreach (Customer c in customersList)
                {
                    tw.WriteLine(c);
                }
                tw.Close();
            }
        }

    }
}
