using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces.MultipleInheritence
{
    public interface IRoadVechile
    {
        int NoOfWheels { get; set; }

        void Drive();

        void Stop();

        void Move();
    }
}
