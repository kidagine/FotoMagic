using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMagic
{
    public class Customer
    {

        public Customer(string firstName, string lastName, float owedMoney)
        {
            FirstName = firstName;
            LastName = lastName;
            OwedMoney = owedMoney;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float OwedMoney { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {OwedMoney}";
        }

    }
}
