using System;
using System.Collections.Generic;

namespace Mohirdev_OOP_Testing.Classes
{
    internal class Car
    {
        // Xususiyatlar
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        // Konstruktor
        public Car(string name, string brand, decimal price)
        {
            Name = name;
            Brand = brand;
            Price = price;
        }
    }

    internal class CarManager
    {
        // Avtomobillarni saqlash uchun ro'yxat
        private List<Car> cars = new List<Car>();

        // Avtomobillar ro'yxatini dastlab to'ldirish
        public CarManager()
        {
            cars.Add(new Car("Camry", "Toyota", 30000));
            cars.Add(new Car("Civic", "Honda", 25000));
            cars.Add(new Car("Sonata", "Hyundai", 27000));
            cars.Add(new Car("Model 3", "Tesla", 40000));
            cars.Add(new Car("Altima", "Nissan", 28000));
        }

        // Foydalanuvchi kiritgan narx oralig'iga mos avtomobillarni chiqarish
        public void GetCarsByPriceRange()
        {
            Console.Write("Birinchi narxni kiriting: ");
            decimal price1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ikkinchi narxni kiriting: ");
            decimal price2 = decimal.Parse(Console.ReadLine());

            // Narxlarni tartiblash (kichigi birinchi bo'lishi uchun)
            decimal minPrice = Math.Min(price1, price2);
            decimal maxPrice = Math.Max(price1, price2);

            // Filtirlash va natijalarni chiqarish
            var filteredCars = cars.FindAll(car => car.Price >= minPrice && car.Price <= maxPrice);

            if (filteredCars.Count > 0)
            {
                Console.WriteLine($"\nNarxi {minPrice:C} va {maxPrice:C} oralig'idagi avtomobillar:");
                foreach (var car in filteredCars)
                {
                    Console.WriteLine($"Model: {car.Name}, Marka: {car.Brand}, Narx: {car.Price:C}");
                }
            }
            else
            {
                Console.WriteLine($"\nNarxi {minPrice:C} va {maxPrice:C} oralig'idagi avtomobillar topilmadi.");
            }
        }
    }
}
