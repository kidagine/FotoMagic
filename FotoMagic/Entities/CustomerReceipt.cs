using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fotomagic.Entities
{
	public class CustomerReceipt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Cost { get; set; }
        public string Date { get; set; }

        public CustomerReceipt(int id, string name, string amount, string cost, string date)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Cost = cost;
            Date = date;
        }
    }
}
