using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Inheritence_Demo
{
    public interface Doctor_Multiple
    {
    }

    public interface Physician_Multiple
    {

    }

    public class Physiotherapist : Doctor_Multiple , Physician_Multiple
    {

    }
}
