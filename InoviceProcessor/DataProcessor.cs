using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessor
{
    class DataProcessor
    {
        public static void DataProcess(string path)
        {
            StreamReader streamReader = null;

            if (!File.Exists(path))
            {
                Console.WriteLine("\nFile not found.\n");
            }
            else
            {
                try
                {
                    // Attempt to open, process, and print the file. It will throw an exception if there is a problem within it.
                    using (streamReader = new StreamReader(path))
                    {
                        ItemList items = DataGenerator.itemGenerator(streamReader);
                        ConsolePrinter.PrintInvoices(items, "Natural Order:");
                        items.Sort();
                        ConsolePrinter.PrintInvoices(items, "Sorted Order: [Price Descending]");
                    }
                }

                // This block will execute if an exception is thrown in the try block.
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}\n");
                }
            }
        }
    }
}
