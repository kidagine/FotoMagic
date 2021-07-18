using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fotomagic.Entities
{
	public class Product
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public Product(int id, string name, string price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
