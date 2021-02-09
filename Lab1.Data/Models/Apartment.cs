using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class Apartment : Base<Apartment>
    {
        public static int square_price = 10; // 10 грн за квадратный метр.
        public int Number { get; set; }
        public int Area_size { get; set; }
        public bool IsOwn { get; set; }
        public string OwnerName { get; set; }
        //public class Building : Base<Building>
        public Apartment() { }

        private Guid _buildingId;


        //private int _buildingnumber;
        //public Building Building
        //{
        //    get { return Building.Items.Where(b => b.Number == _buildingnumber).FirstOrDefault(); }
        //    set { _buildingnumber = value.Number; }
        //}

        public Building Building
        {
            get { return Building.Items.Where(b => b.Id == _buildingId).FirstOrDefault(); }
            set
            {
                //Console.WriteLine("Building properties");
                _buildingId = value.Id;

            }
        }

        private Guid _personId;
        public Person Person
        {
            get { return Person.Items.Where(b => b.Id == _personId).FirstOrDefault(); }
            set { _personId = value.Id; }
        }

        private Guid _entranceId;
        public Entrance Entrance
        {
            get { return Entrance.Items.Where(b => b.Id == _entranceId).FirstOrDefault(); }
            set { _entranceId = value.Id; }
        }


        public void ChangeOwner(Person p)
        {
            this.Person = p;
            if (p != Person.p0)
            {
                this.IsOwn = true;
            }
            else
            {
                this.IsOwn = false;
            }
            this.Person.OrderDate = DateTime.Now;
        }
        
        public override string ToString()
        {
            return "Building number: " + Building.Number + ". " + "Entrance name: " + this.Entrance + ". " +
                "Apartment number: " + this.Number + ". " +
                "Area_size: " + this.Area_size + ". Payment for Appartment = " + this.Area_size * square_price + " " + ". Appartment owner = " + this.Person + ". Has Owner = " + this.IsOwn;
        }
    }
}
