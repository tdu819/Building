using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class Person : Base<Person>
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsOwner { get; set; }

        public Person() { }


        private Guid _apartmentId;
        public Apartment Apartment
        {
            get { return Apartment.Items.Where(b => b.Id == _apartmentId).FirstOrDefault(); }
            set { _apartmentId = value.Id; }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
