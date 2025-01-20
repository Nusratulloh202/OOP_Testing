using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohirdev_OOP_Testing.Classes
{
    internal class Cars
    {
        private List<Cars> carsList = new List<Cars>();
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public decimal Speed { get; set; }
        public decimal CurrentPrice { get; set; }

        public Cars(string model = "", int year = 2025, decimal price = 0, decimal speed = 0, decimal currentPrice=0)
        {
            Model = model;
            Year = year;
            Price = price;
            Speed = speed;
            CurrentPrice = currentPrice;

        }

        private string selection;
        public void InputCars()
        {
            do
            {
                do
                {
                    Console.Write("Mashina Modelini kiriting:");
                    Model = Console.ReadLine();
                    Console.Write("Moshina ishlab chiqazilgan yilni kiriting:");
                    Year = int.Parse(Console.ReadLine());
                    Console.Write("Mashina narxini kiriting:");
                    Price = decimal.Parse(Console.ReadLine());
                    Console.Write("Mashina maximal tezligini kiriting:");
                    Speed = decimal.Parse(Console.ReadLine());
                    CurrentPrice = CalculateDepreciation(Year);
                    if (CurrentPrice <= 0)
                    {
                        CurrentPrice = 0;
                    }
                    carsList.Add(new Cars(Model, Year, Price, Speed, CurrentPrice));
                    Console.WriteLine("Yana kiritasizmi (ha/yoq)");
                    selection = Console.ReadLine().ToLower();
                
                }
                while (selection=="ha");

                while (selection == "yoq")
                {

                    GetCarInfo();
                }
                Console.WriteLine("Boshqa buyruq kiritdingiz.");

            }
            while (selection!="ha" && selection!="yoq");

            
        }
        public void GetCarInfo()
            
        {
            Console.WriteLine("Model     |Year     |Price  |Speed  |Current Price");
            foreach(var car in carsList)
            Console.WriteLine($"{car.Model,-10}, {car.Year,-6}, {car.Price,-8}, {car.Speed,-4}, {car.CurrentPrice,-8}.");
            Console.ReadLine();
        }
        public decimal CalculateDepreciation(int years)
        {
            decimal differencePrice = Price;
            int differenceYear = 2025 - years;
            for (int i = 0; i < differenceYear; i++)
            {
                differencePrice -= differencePrice / 10;
            }
            
            return differencePrice;
        }

    }
    
}
