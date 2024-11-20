using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Inheritence_Demo
{
    public class BaseDemo
    {
        public int Id { get; set; }

        protected string Location { get; set; }

        public BaseDemo(int id)
        {
            this.Id = id;
        }
    }

    public class BaseChild : BaseDemo
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public BaseChild(int parentId, int childId) : base(parentId)
        {
            this.Id = childId;
        }

        public void SetLocation(string location)
        {
            base.Location = location;
        }

        public string DisplayDetails()
        {
            return $"Parent Id = {base.Id}, Child Id = {Id}, Location = {Location} and Name = {Name}";
        }
    }

}
