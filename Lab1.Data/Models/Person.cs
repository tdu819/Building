using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class Person : Base<Person>
    {
        public static Person p0 = new Person() { Name = "Developer", PhoneNumber = 670000000 };
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsOwner { get; set; }

        public Person() { }


        //private Guid _apartmentId;
        // 1 to 1. Person to apartments
        //public Apartment Apartment
        //{
        //    get { return Apartment.Items.Where(b => b.Id == _apartmentId).FirstOrDefault(); }
        //    set { _apartmentId = value.Id; }
        //}

        // 1 to M. Person to apartments
        private List<Apartment> _apartments;
        public List<Apartment> Apartments
        {
            get
            {
                return Apartment.Items.Where(a => a.Person == this).ToList();
            }
            //set
            //{
            //    Apartments = value.ToList();
            //}
        }


        public override string ToString()
        {
            return Name;
        }

    }
}
