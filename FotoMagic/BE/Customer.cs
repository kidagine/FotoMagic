using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMagic.BE
{
    public class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OwedMoney { get; set; }

        public Customer(int id, string firstName, string lastName, string owedMoney)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            OwedMoney = owedMoney;
        }
    }
}
