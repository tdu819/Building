using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class Apartment : Base<Apartment>
    {
        public int Number {get; set;}
        public int Area_size { get; set; }
        public bool IsOwn { get; set; }
        //public class Building : Base<Building>
        public Apartment() { }

        private Guid _buildingId;


        private int _buildingnumber;
        //public Building Building
        //{
        //    get { return Building.Items.Where(b => b.Number == _buildingnumber).FirstOrDefault(); }
        //    set { _buildingnumber = value.Number; }
        //}

        public Building Building
        {
            get { return Building.Items.Where(b => b.Id == _buildingId).FirstOrDefault(); }
            set { _buildingId = value.Id; }
        }



        private Guid _personId;
        public Person Person
        {
            get { return Person.Items.Where(b => b.Id == _personId).FirstOrDefault(); }
            set { _personId = value.Id; }
        }

    }
}
