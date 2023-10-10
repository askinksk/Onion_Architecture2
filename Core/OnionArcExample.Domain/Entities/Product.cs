using OnionArcExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArcExample.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16 UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
