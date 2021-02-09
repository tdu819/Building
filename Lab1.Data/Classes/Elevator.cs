using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class Elevator : Base<Elevator>
    {
        public string Name { get; set; }

        public Elevator() { }

        //and 1 - 1 entrance to Elevator
        private Guid _entranceId;
        public Entrance Entrance
        {
            get { return Entrance.Items.Where(b => b.Id == _entranceId).FirstOrDefault(); }
            set { _entranceId = value.Id; }
        }



    }
}
