# Invoice Processor
This is a simple demonstration of file reading and writing by C#/.NET programming to process virutal invoices of purchased items with the practice of abstract class, sorting, and List.

## Instructions
1. Download as a whole or clone.
2. Run InvoiceProcessor.exe items.csv in \InvoiceProcessor\bin\Debug folder.

## Requirements & Technologies
* Implementation of software design pattern with layered architecture design, object-oriented programming, and code seperation.
* Application of C# file reading/writing (I/O) manipulation, abstract class, data validation, and data process with collection sorting practices.

## Sample Output

    Natural Order:
    Item                                      Price   Expries
    ------------------------------------------------------------------
    4L Milk                                    3.87   Mon Oct 14, 2019
    500g Cottage Cheese                        4.28   Sat Nov 09, 2019
    1 Tin Mushroom Soup                        0.99   <Never>
    SuperValu QuickWash                      499.99   <N/A>
    15kg Dog Food                             29.99   Fri Feb 19, 2021
    RayMag Crystal Clean Dishwasher          649.99   <N/A>
    RayMag Crystal Clean Dishwasher (Sale)   449.99   <N/A>
    ------------------------------------------------------------------
    Total:                                 1,639.10


    Sorted Order: [Price Descending]
    Item                                      Price   Expries
    ------------------------------------------------------------------
    RayMag Crystal Clean Dishwasher          649.99   <N/A>
    SuperValu QuickWash                      499.99   <N/A>
    RayMag Crystal Clean Dishwasher (Sale)   449.99   <N/A>
    15kg Dog Food                             29.99   Fri Feb 19, 2021
    500g Cottage Cheese                        4.28   Sat Nov 09, 2019
    4L Milk                                    3.87   Mon Oct 14, 2019
    1 Tin Mushroom Soup                        0.99   <Never>
    ------------------------------------------------------------------
    Total:                                 1,639.10

## Miscellaneous
All rights reserved for the author. Do not use this code for any course assignments/labs. 
