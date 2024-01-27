using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {

        Product Car = new Product();
        Car.Name = "Honda";
        Car.Model = "Civic";
        Car.Color = "White";
        Car.Price = 900000;

        Product Car2 = new Product();
        Car2.Name = "Mercedes";
        Car2.Model = "C200";
        Car2.Color = "Black";
        Car2.Price = 2100000;

        Product[] cars = new Product[] { Car, Car2 };

        Console.WriteLine("For Döngüsü");

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine("Name:" + cars[i].Name + "\nModel:" + cars[i].Model + "\nColor:" + cars[i].Color + "\nPrice: " + cars[i].Price);
        }

        Console.WriteLine("\nForeach Döngüsü");

        foreach (var ıtem in cars)
        {
            Console.WriteLine("Name:" + ıtem.Name + " Price:" + ıtem.Price);
        }

        Console.WriteLine("\nWhile Döngüsü");

        int j = 0;
        while (j < cars.Length)
        {
            Console.WriteLine("Name:" + cars[j].Name + " Model:" + cars[j].Model);
            j++;
        }
        Console.ReadKey();
    }
    class Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}