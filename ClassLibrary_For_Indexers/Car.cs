using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Indexers
{
    public class Car
    {
        private string[] _cars = new string[] { "BMW", "Audi", "Lamborgini", "Ferrari", "Rolls Royce", "Tata", "Mahindra" };

        private string[] _orders = new string[] { "first", "second", "third", "fourth", "fifth", "sixth", "seventh" };

        public string this[int index]
        {
            set
            {
                this._cars[index] = value;
            }
            get
            {
                return this._cars[index];
            }
        }

        public string this[string order]
        {
            set
            {
                int index = Array.IndexOf(this._orders, order);
                if (index != -1)
                {
                    this._cars[index] = value;
                }
            }
            get
            {
                int index = Array.IndexOf(this._orders, order);
                if (index != -1)
                {
                    return this._cars[index];
                }
                return "Invalid Index supplied";
            }
        }

    }
}
