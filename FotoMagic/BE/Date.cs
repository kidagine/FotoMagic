using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMagic.BE
{
    public class Date
    {

        public string OwedDate { get; set; }
        public float OwedMoney { get; set; }

        public Date(string owedDate, float owedMoney)
        {
            OwedDate = owedDate;
            OwedMoney = owedMoney;
        }

    }
}
