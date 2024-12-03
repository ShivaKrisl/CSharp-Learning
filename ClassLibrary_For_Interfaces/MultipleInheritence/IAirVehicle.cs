using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces.MultipleInheritence
{
    public interface IAirVehicle
    {
        int NoOfWings { get; set; }

        void Fly();

        void Land();

        void Move();
    }
}
