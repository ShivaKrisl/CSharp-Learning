using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_PartialClasses
{
    public partial class Product
    {
        public double CalculateTax()
        {
            double tax = 0;
            tax = this.Price * 0.18;
            return tax;
        }

        public double GetTotalPriceOfProduct()
        {
            double total = 0;
            this.GetTotalPrice(out total);
           return total;
        }
    }
}
