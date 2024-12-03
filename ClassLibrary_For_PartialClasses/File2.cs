using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_PartialClasses
{
    public partial class Product
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        private partial void GetTotalPrice(out double total)
        {
            double totalPrice = this.Price + this.CalculateTax();
            total = totalPrice;
        }
    }
}
