using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForMethods
{
    public class EncapsulationClassLib
    {
        private int Id;

        private string Name;

        private double Price;

        private int Quantity;

        private readonly DateTime PurchasedDate;


        /// <summary>
        /// Constructor
        /// </summary>
        public EncapsulationClassLib()
        {
            this.PurchasedDate = DateTime.Now;
        }

        /// <summary>
        /// Set Method for Id
        /// </summary>
        /// <param name="id"></param>
        public void SetProductID(int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Get Method for ID
        /// </summary>
        /// <returns>Id</returns>
        public int GetProductID() { 
            return this.Id; 
        }

        /// <summary>
        /// Set Name
        /// </summary>
        /// <param name="name"></param>
        public void SetProductName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Get Name
        /// </summary>
        /// <returns>name</returns>
        public string GetName()
        {
            return this.Name;
        }


        /// <summary>
        /// Set Price
        /// </summary>
        /// <param name="price"></param>
        public void SetProductPrice(double price)
        {
            this.Price = price;
        }

        /// <summary>
        /// Get Price
        /// </summary>
        /// <returns>Price</returns>
        public double GetPrice()
        {
            return this.Price;
        }


        /// <summary>
        /// Set Quantity
        /// </summary>
        /// <param name="quantity"></param>
        public void SetProductQuantity(int quantity)
        {
            this.Quantity = quantity;
        }

        /// <summary>
        /// Get Quantity
        /// </summary>
        /// <returns>quantity</returns>
        public int GetQuantity()
        {
            return this.Quantity;
        }

        /// <summary>
        /// Get DateOfPurchase
        /// </summary>
        /// <returns>PurchasedDate</returns>
        public DateTime GetPurchasedDate()
        {
            return this.PurchasedDate;
        }

    }
}
