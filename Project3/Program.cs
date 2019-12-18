using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {

            Soda[] sodaArray = {
                new Soda() { Name = "Coca-Cola", Manufacturer = "The Coca-Cola Company", Quantity = 210 },
                new Soda() { Name = "Pepsi", Manufacturer = "PepsiCo", Quantity = 210 },
                new Soda() { Name = "Mountain Dew", Manufacturer = "PepsiCo", Quantity = 120 },
                new Soda() { Name = "Dr Pepper", Manufacturer = "Keurig Dr Pepper", Quantity = 12},
                new Soda() { Name = "Sprite", Manufacturer = "The Coca-Cola Company", Quantity = 73},
                new Soda() { Name = "A&W Root Beer", Manufacturer = "Keurig Dr Pepper", Quantity = 145},
                new Soda() { Name = "Barq's", Manufacturer = "The Coca-Cola Company", Quantity = 145},
                new Soda() { Name = "Crush", Manufacturer = "Keurig Dr Pepper", Quantity = 21},
                new Soda() { Name = "Fanta", Manufacturer = "The Coca-Cola Company", Quantity = 16},
                new Soda() { Name = "7Up", Manufacturer = "Keurig Dr Pepper", Quantity = 37},
                new Soda() { Name = "Jarritos", Manufacturer = "Novamex", Quantity = 120},
                new Soda() { Name = "Mug Root Beer", Manufacturer = "PepsiCo", Quantity = 96},
                new Soda() { Name = "Mello Yello", Manufacturer = "The Coca-Cola Company", Quantity = 44},
                new Soda() { Name = "Squirt", Manufacturer = "Keurig Dr Pepper", Quantity = 55},
                new Soda() { Name = "Seirra Mist", Manufacturer = "PepsiCo", Quantity = 61},
            };
            Console.WriteLine("Query 1 - Order by quantity\n");

            var quantities = from s in sodaArray
                             orderby s.Quantity
                             select s;

            foreach(var soda in quantities)
            {
                Console.WriteLine($"There are {soda.Quantity} {soda.Name}");
            }

            var manufacturers = from s in sodaArray
                                group s by s.Manufacturer;

            Console.WriteLine("\n--------------------------------------------------------\n");
            Console.WriteLine("Query 2 - Group by manufacturer\n");

            foreach(var soda in manufacturers)
            {
                Console.WriteLine("********************* \nManufacturer: {0}", soda.Key);
                foreach (Soda s in soda)
                {
                    Console.WriteLine("Soda name: {0}", s.Name);
                }
            }

            Console.WriteLine("\n--------------------------------------------------------\n");
            Console.WriteLine("Query 3 - Where quantity is less than 50\n");

            var lowerquan = from s in sodaArray
                            where s.Quantity < 50
                            select s;

            foreach(var soda in lowerquan)
            {
                Console.WriteLine($"{soda.Name} quantity{soda.Quantity} is less than 50");
            }

        }
    }//end class Program

    class Soda
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }
    }//end class Soda

}
