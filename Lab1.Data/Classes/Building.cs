using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class Building : Base<Building>
    {
        //public class Restaurant : Base<Restaurant>

        public string Street { get; set; }
        public int Number { get; set; }


        private string street;
        int number;
        public Building()
        {
            //Street = street;
            //Number = number;  
        }

        public Building(string street, int number)
        {
            Street = street;
            Number = number;
        }

        public List<Apartment> Apartments
        {
            get
            {
                return Apartment.Items.Where(a => a.Building == this).ToList();
            }
        }

        public List<Entrance> Entrances
        {
            get
            {
                return Entrance.Items.Where(a => a.Building == this).ToList();
            }
        }


        public override string ToString()
        {
            //return this.Street + " " + this.Number;
            return this.Number.ToString();
        }

    }
}
