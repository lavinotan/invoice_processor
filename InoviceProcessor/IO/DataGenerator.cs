using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace InvoiceProcessor
{
    class DataGenerator
    {
        public static ItemList itemGenerator(StreamReader streamReader)
        {
            // Default value for groceries without expiration date            
            DateTime maxDate = DateTime.MaxValue;

            ItemList items = new ItemList();            
            string lineDate;
            ApplianceType applianceType;           

            while ((lineDate = streamReader.ReadLine()) != null)
            {
                string[] itemStrings = lineDate.Split(',');
                string[] itemElements = new string[4]; // Each item should have 4 elements
                Array.Copy(itemStrings, itemElements, itemStrings.Length);                

                // Check item category and populate them into groceries or appliances
                if (Enum.TryParse<ApplianceType>(itemElements[3], out applianceType))
                {
                    items.Add(new ApplianceItem(
                            itemElements[0],
                            int.Parse(itemElements[1]),
                            decimal.Parse(itemElements[2]),
                            applianceType                        
                        ));           
                }
                else
                {
                    // If expiration date is empty, set the date to max by default
                    DateTime date = String.IsNullOrEmpty(itemElements[3]) ? maxDate : DateTime.Parse(itemElements[3]);            

                    items.Add(new GroceryItem(
                            itemElements[0],
                            int.Parse(itemElements[1]),
                            decimal.Parse(itemElements[2]),
                            date
                        ));
                }      
            }

            return items;
        }
        
    }
}
