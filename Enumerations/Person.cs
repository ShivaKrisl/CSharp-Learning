using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    internal class Person
    {
        public string PersonName { get; set; }

        public AgeGroup PersonAge { get; set; }

        public string Health { get; set; }

        public HealthStatus GetStatus()
        {
            if (this.Health.Equals("Cancer"))
            {
                return HealthStatus.Bad;
            }
            else if (this.Health.Equals("Fever"))
            {
                return HealthStatus.Good;
            }
            return HealthStatus.VeryGood;
        }

        public override string ToString()
        {
            return $"Person Name = {this.PersonName} and Person Age Group = {this.PersonAge}";
        }
    }

    internal enum AgeGroup : short
    {
        Child, Teenager, Adult, Senior
    }

    internal enum HealthStatus
    {
        Bad,Mild, Good, VeryGood, Excellent
    }


}
