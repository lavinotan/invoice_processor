using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "InoviceProcessor Demo";

            string path;

            if (args.Length > 0)
            {
                path = args[0];           
            }
            else
            {
                // location of the data file
                ConsolePrinter.PrintFilePath();
                return;
            }          

            DataProcessor.DataProcess(path);
        }
    }
}
