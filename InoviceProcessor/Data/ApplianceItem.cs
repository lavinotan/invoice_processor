using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessor
{
    public enum ApplianceType
    {
        Washer,
        Dryer,
        Dishwasher,
        Oven,
        Range,
        Refrigerator
    }
    class ApplianceItem : Item
    {
        public ApplianceType ApplianceType { get; }

        public ApplianceItem(string description, int sku, decimal price, ApplianceType applianceType) : base(description, sku, price)
        {
            ApplianceType = applianceType;
        }


    }
}
