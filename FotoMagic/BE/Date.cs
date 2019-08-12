using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMagic.BE
{
    public class Date
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OwedDate { get; set; }
        public string OwedMoney { get; set; }

        public Date(string firstName, string lastName,string owedDate, string owedMoney)
        {
            FirstName = firstName;
            LastName = lastName;
            OwedDate = owedDate;
            OwedMoney = owedMoney;
        }

    }
}
