using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Data;

namespace Lab1
{
    class Program
    {
        static void CreateAppartments(Building b, byte max_Apartments_in_Building)
        {
            Random Rand = new Random();
            for (int i = 0; i < max_Apartments_in_Building; i++)
            {
                Apartment.Items.Add(new Apartment() { Number = i + 1, Area_size = Rand.Next(50, 100), Building = b });
            }
        }

        static void Main(string[] args)
        {
            Random Rand = new Random();
            byte max_Apartments_in_Building = 150;
            int a = Rand.Next(50, 100);

            //int max_Apartments_in_Building = 150;
            

            byte buildings_count = 4;

            int square_price = 10; //10 грн за квадратный метр.

            //Console.WriteLine(a + "\n");


            //Console.WriteLine(max_Apartments_in_Building);
            //Console.WriteLine();

            //string street = "Street";
            //for (int i = 0; i < buildings_count; i++)
            //{
            //    Building.Items.Add(new Building(street, i + 1));
            //}

            //foreach (var item in Building.Items)
            //{
            //    Console.WriteLine(item.Id);
            //}
            Building b1 = new Building("Street", 1);
            Building b2 = new Building("Street", 2);
            Building b3 = new Building("Street", 3);
            Building b4 = new Building("Street", 4);
            //Building b2 = new Building() { Street = "sdf", Number = 1 };
            //Console.WriteLine(b2);

            //creating apartments 150
            CreateAppartments(b1, max_Apartments_in_Building);
            CreateAppartments(b2, max_Apartments_in_Building);
            CreateAppartments(b3, max_Apartments_in_Building);
            CreateAppartments(b4, max_Apartments_in_Building);

            Person p1 = new Person() { Name = "Name1", PhoneNumber = 671234561, Apartment = Apartment.Items[0] };
            Person p2 = new Person() { Name = "Name2", PhoneNumber = 671234562, Apartment = Apartment.Items[1] };

            Person.Items.Add(p1);
            Person.Items.Add(p2);

            int result = p1.Apartment.Area_size * square_price;
            
            Console.WriteLine(Apartment.Items[0].Area_size);
            Console.WriteLine(result);
            Console.WriteLine();


            Console.WriteLine("Type name:");
            string s = Console.ReadLine();

            foreach (var item in Person.Items)
            {
                if (item.Name == s)
                {
                    Console.WriteLine(item.Apartment.Area_size * square_price);
                }
            }


            Console.ReadLine(); 
        }
    }
}


