using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessor
{
    class ConsolePrinter
    {
        public static void PrintInvoices(ItemList items, string title)
        {
            if (items is null)
            {
                Console.WriteLine("Item List cannot be null");
                return;
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Nothing to Print");
                return;
            }

            PrintItems(items, title);
        }

        private static void PrintItems(ItemList items, string title) {
            DateTime maxDate = DateTime.MaxValue;

            string divider = new String('-', 66);

            Console.WriteLine(title);
            Console.WriteLine($"{"Item",-40}{"Price",7:N02}   {"Expries",-20}");
            Console.WriteLine(divider);

            foreach (Item item in items)
            {
                if (item is GroceryItem)
                {
                    if (((GroceryItem)item).ExpirationDate == maxDate)
                    {
                        Console.WriteLine($"{item.Description,-40}{item.Price,7:N02}   {"<Never>",-20}");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Description,-40}{item.Price,7:N02}   {((GroceryItem)item).ExpirationDate.ToString("ddd MMM dd, yyyy"),-20}");
                    }
                }
                else
                {
                    Console.WriteLine($"{item.Description,-40}{item.Price,7:N02}   {"<N/A>",-20}");
                }
            }
            Console.WriteLine(divider);
            Console.WriteLine($"{"Total:",-39}{items.TotalPrice(),7:N02}\n\n");
        }

        public static void PrintFilePath()
        {
            // location of the data file
            Console.WriteLine("Usage: InvoiceProcessor.exe items.csv");
        }
    }
}
