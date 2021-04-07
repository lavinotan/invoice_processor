using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessor
{
    class ItemList : List<Item>
    {
        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            foreach (Item item in this)
            {
                totalPrice += item.Price;
            }

            return totalPrice;
        }
    }
}
