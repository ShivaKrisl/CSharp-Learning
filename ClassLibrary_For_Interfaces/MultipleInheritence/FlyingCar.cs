using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces.MultipleInheritence
{
    public class FlyingCar : IRoadVechile, IAirVehicle
    {
        public int NoOfWheels { get; set; }
        public int NoOfWings { get; set; }

        public void Fly()
        {
            Console.WriteLine("FlyingCar is Flying");
        }

        public void Land()
        {
            Console.WriteLine("FlyingCar is Landing");
        }

        public void Drive()
        {
            Console.WriteLine("FlyingCar is Driving");
        }

        public void Stop()
        {
            Console.WriteLine("FlyingCar is Stopping");
        }

        void IRoadVechile.Move()
        {
            Console.WriteLine("FlyingCar is Moving on Road");
        }

        void IAirVehicle.Move()
        {
            Console.WriteLine("FlyingCar is Moving in Air");
        }
    }
}
