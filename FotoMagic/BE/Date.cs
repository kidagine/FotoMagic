using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMagic.BE
{
    public class Date
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OwedDate { get; set; }
        public string OwedProduct { get; set; }
        public string OwedMoney { get; set; }

        public Date(int id, string firstName, string lastName, string owedDate, string owedProduct, string owedMoney)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            OwedDate = owedDate;
            OwedProduct = owedProduct;
            OwedMoney = owedMoney;
        }
    }
}
