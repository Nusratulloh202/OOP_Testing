using Mohirdev_OOP_Testing.Classes;

Console.WriteLine("Assalomu Alaykum.");
Cars car = new Cars();
car.InputCars();
StudentManager studentManager = new StudentManager();

while (true)
{
    Console.WriteLine("\n1. O'quvchi qo'shish");
    Console.WriteLine("2. Bahoga ko'ra o'quvchilarni ko'rish");
    Console.WriteLine("3. Chiqish");
    Console.Write("Tanlang: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            studentManager.AddStudent();
            break;

        case "2":
            studentManager.GetStudentsByGrade();
            break;

        case "3":
            Console.WriteLine("Dastur tugatildi.");
            break;

        default:
            Console.WriteLine("Noto'g'ri tanlov.");
            break;
    }
    break;

}
CarManager carManager = new CarManager();

// Narx oralig'iga ko'ra avtomobillarni chiqarish methodini chaqirish
carManager.GetCarsByPriceRange();

