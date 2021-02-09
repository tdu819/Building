using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Data;

namespace Lab1
{
    public class Program
    {
        
        static void ShowApartments()
        {
            foreach (var item in Apartment.Items)
            {
                Console.WriteLine(item);
            }
        }


         //10 грн за квадратный метр.
        static void CreateAppartments(Building b, byte max_Apartments_in_Building, Person p0)
        {
            Random Rand = new Random();
            for (int i = 0; i < max_Apartments_in_Building; i++)
            {
                new Apartment() { Number = i + 1, Area_size = Rand.Next(50, 100), Building = b, IsOwn = false, Person = p0 }; //Developer = забудовник.
                //Console.WriteLine(Apartment.Items[i]);
            }
        }

        static void Main(string[] args)
        {
            Random Rand = new Random();
            byte max_Apartments_in_Building = 150;
            int a = Rand.Next(50, 100);

            //int max_Apartments_in_Building = 150;


            byte buildings_count = 4;



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
            //Building b1 = new Building("Street", 1);
            Building b1 = new Building() { Street = "Street", Number = 1 };

            Building b2 = new Building("Street", 2);
            Building b3 = new Building("Street", 3);
            Building b4 = new Building("Street", 4);
            //Building b2 = new Building() { Street = "sdf", Number = 1 };
            //Console.WriteLine(b2);

            
            Person p1 = new Person() { Name = "Name1", PhoneNumber = 670000001 };
            Person p2 = new Person() { Name = "Name2", PhoneNumber = 670000002 };

            //creating apartments 150
            CreateAppartments(b1, max_Apartments_in_Building, Person.p0);
            CreateAppartments(b2, max_Apartments_in_Building, Person.p0);
            CreateAppartments(b3, max_Apartments_in_Building, Person.p0);
            CreateAppartments(b4, max_Apartments_in_Building, Person.p0);

            

            Console.WriteLine();
            Apartment.Items[0].ChangeOwner(p1);
            Apartment.Items[2].ChangeOwner(p2);
            Apartment.Items[3].ChangeOwner(p1);

            //public void CreateEntrances ()
            //{

            //}
            Entrance entrance1_1 = new Entrance() { Name = "b1e1" };
            Entrance entrance1_2 = new Entrance() { Name = "b1e2" };
            Entrance entrance2_1 = new Entrance() { Name = "b2e1" };
            Entrance entrance2_2 = new Entrance() { Name = "b2e2" };
            Entrance entrance3_1 = new Entrance() { Name = "b3e1" };
            Entrance entrance3_2 = new Entrance() { Name = "b3e2" };
            Entrance entrance4_1 = new Entrance() { Name = "b4e1" };
            Entrance entrance4_2 = new Entrance() { Name = "b4e2" };

            int Apartment_Items_Count = Apartment.Items.Count;
            for (int i = 0; i < Apartment_Items_Count ; i++) 
            {
                if (i < 75)
                {
                    Apartment.Items[i].Entrance = entrance1_1;
                }
                else if (i < 150)
                {
                    Apartment.Items[i].Entrance = entrance1_2;
                }
                else if (i < 150 + 75)
                {
                    Apartment.Items[i].Entrance = entrance2_1;
                }
                else if (i < 150 + 150)
                {
                    Apartment.Items[i].Entrance = entrance2_2;
                }
                else if (i < 300 + 75)
                {
                    Apartment.Items[i].Entrance = entrance3_1;
                }
                else if (i < 300 + 150)
                {
                    Apartment.Items[i].Entrance = entrance3_2;
                }
                else if (i < 300 + 150 + 75)
                {
                    Apartment.Items[i].Entrance = entrance4_1;
                }
                else if (i < 300 + 150 + 150) 
                {
                    Apartment.Items[i].Entrance = entrance4_2;
                }

            }

            ShowApartments();

            //Person p1 = new Person() { Name = "Name1", PhoneNumber = 671234561, Apartment = Apartment.Items[0] };
            //Person p2 = new Person() { Name = "Name2", PhoneNumber = 671234562, Apartment = Apartment.Items[1] };







            //int result = p1.Apartments[0].Area_size * Apartment.square_price;

            //int home = p1.Apartment.Building.Number;
            //Console.WriteLine(home);
            //Console.WriteLine(p1.Apartment.Building.Street.ToString());
            //Console.WriteLine(p1.Apartment.Building.Number);

            //Console.WriteLine(Apartment.Items[0].Building);
            //Console.WriteLine(Apartment.Items[0]);

            //Console.WriteLine(Apartment.Items[0].Area_size);
            //Console.WriteLine(result);
            //Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("1. We will find price(to pay for apartment) for the person");
            Console.WriteLine("Type name:");
            string s = Console.ReadLine();

            foreach (var person in Person.Items)
            {
                if (person.Name == s)
                {
                    foreach (var apartment in person.Apartments)
                    {
                        Console.WriteLine(apartment.Area_size * Apartment.square_price);
                        //Console.WriteLine(item);
                    }
                }
            }

            Console.WriteLine();


            Console.WriteLine("2. We will find price using building number and apartment number ");
            Console.WriteLine("Type building number please: 1..4");
            int bnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type apartment number 1..150");
            int apartmentnumber = int.Parse(Console.ReadLine());

            foreach (var apartment in Apartment.Items)
            {
                if (apartment.Building.Number == bnumber && apartment.Number == apartmentnumber) 
                {
                    Console.WriteLine($"It will be {apartment.Area_size * Apartment.square_price}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("3. We will find all the apartments  that were saled  ");
            foreach (var apartment in Apartment.Items)
            {
                if (apartment.IsOwn == true)
                {
                    Console.WriteLine(apartment);
                }
            }

            Console.WriteLine();


            Console.WriteLine("4. We will find all the apartments  that were saled  ");
            foreach (var apartment in Apartment.Items)
            {
                if (apartment.IsOwn == true)
                {
                    Console.WriteLine(apartment);
                }
            }

            Console.WriteLine("5. We will find sum of price that pay for apartment were bought");
            Console.WriteLine("Type building number please: 1..4");
            int bnumber2 = int.Parse(Console.ReadLine());
            int sum = 0;;
            foreach (var building in Building.Items)
            {
                if (building.Number == bnumber2)
                {
                    foreach (var apartment in building.Apartments)
                    {
                        if (apartment.IsOwn == true)
                        {
                            sum += apartment.Area_size;
                        }
                    }
                }
            }
            sum = sum * Apartment.square_price;
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("6. We will change price for 1 square meter");
            
            Apartment.square_price = 100;
            Console.WriteLine("Now Apartment.square_price = 100");

            ShowApartments();
            Console.WriteLine();
            //Console.WriteLine(Apartment_Items_Count * buildings_count);
            Console.ReadLine(); 
        }
    }
}
