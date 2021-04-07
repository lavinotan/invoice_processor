using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessor
{
    abstract class Item : IComparable<Item>
    {
        public string Description { get; set; }

        public int Sku { get; }
        public decimal Price { get; }
        
        public Item()
        { 
        }

        public Item(string description, int sku, decimal price) 
        {
            Description = description;
            Sku = sku;
            Price = price;
        }

        // Method to sort price in descending order 
        public int CompareTo(Item other)
        {
            int result = this.Price.CompareTo(other.Price);

            return -result;
        }
    }
}
