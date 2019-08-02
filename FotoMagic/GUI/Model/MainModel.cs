using System;
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
            
        public void CreateCustomer(String firstName, string lastName, float owedMoney)
        {
            Customer customer = new Customer(firstName, lastName, owedMoney);
            customersList.Add(customer);
            WriteToTextFile();
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
