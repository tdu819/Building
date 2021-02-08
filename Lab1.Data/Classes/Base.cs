using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class Base<T> where T : Base<T>
    {
        public static List<T> Items = new List<T>();
        //public string Name { get; set; }

        public Guid Id { get; private set; }
        //public Guid id;


        //public Kniga(string name, string author, string tema, int year, string publisher, string lang, int pages, double price) : base(name, year, tema, lang, pages, price)
        //{
        //    Author = author;
        //    Publisher = publisher;
        //}
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Base(Guid id)
        {
            Id = Guid.NewGuid();
            Items.Add((T)this);
        }
    }
}
