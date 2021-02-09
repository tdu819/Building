using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class Entrance : Base<Entrance>
    {
        public string Name { get; set; }

        public Entrance() { }

        //and 1 - 1. entrance to apartments
        private Guid _apartmentId;
        public Apartment Apartment
        {
            get { return Apartment.Items.Where(b => b.Id == _apartmentId).FirstOrDefault(); }
            set { _apartmentId = value.Id; }
        }


        //and 1 to m. building tot entrances
        private Guid _buildingId;
        public Building Building
        {
            get { return Building.Items.Where(b => b.Id == _buildingId).FirstOrDefault(); }
            set
            {
                //Console.WriteLine("Building properties");
                _buildingId = value.Id;

            }
        }



        // and 1 to 1. entrance to elevator
        private Guid _elevatorId;
        public Elevator Elevator
        {
            get { return Elevator.Items.Where(b => b.Id == _elevatorId).FirstOrDefault(); }
            set { _elevatorId = value.Id; }
        }

        

    }
}
