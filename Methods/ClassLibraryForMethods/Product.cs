using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForMethods
{
    public class Product
    {
        public int Id;

        public string Name;

        public double Price;

        public double Tax;

        public int Quantity;


        private int pid;


        public Product(int id, string name, double price, int quantity) { 
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void setPid(int id)
        {
            this.pid = id;
        }


        public override string ToString()
        {
            return $"Product Id = {this.Id} \n Product Name = {this.Name} \n Product Cost = {this.Price} \n Product Tax = {this.Tax} \n Product Quantity = {this.Quantity}\n";
        }

        public void CalculateTax()
        {
            double tax = 0;
            if (this.Price <= 20000)
            {
                tax = this.Price * (10.0 / 100.0);
            }
            else if (this.Price > 20000 && this.Price <=40000)
            {
                tax = this.Price * (12.5 / 100.0);
            }
            else
            {
                tax = this.Price * (20.0 / 100.0);
            }
            this.Tax = tax;
        }
    }


}
