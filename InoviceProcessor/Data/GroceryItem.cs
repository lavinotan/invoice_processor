using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessor
{
    class GroceryItem : Item
    {
        public DateTime ExpirationDate { get; }

        public GroceryItem(string description, int sku, decimal price, DateTime expirationDate) : base(description, sku, price)
        {
            ExpirationDate = expirationDate;
        }
    }
}
