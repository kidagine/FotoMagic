using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMagic.BE
{
    public class Customer
    {



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float OwedMoney { get; set; }

        public Customer(string firstName, string lastName, float owedMoney)
        {
            FirstName = firstName;
            LastName = lastName;
            OwedMoney = owedMoney;
        }
    }
}
