using System;
using System.Collections.Generic;

namespace Mohirdev_OOP_Testing.Classes
{
    internal class Student
    {
        // Xususiyatlar
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public int Class { get; set; }
        public Grade Baho { get; set; }

        // Enum
        public enum Grade
        {
            besh = 5,
            tort = 4,
            uch = 3,
            ikki = 2
        }

        // Konstruktor
        public Student(Guid id, string name, string sureName, int @class, Grade baho)
        {
            Id = id;
            Name = name;
            SureName = sureName;
            Class = @class;
            Baho = baho;
        }
    }

    internal class StudentManager
    {
        // O'quvchilarni saqlash uchun ro'yxat
        private List<Student> students = new List<Student>();

        // O'quvchi qo'shish
        public void AddStudent()
        {
            Console.Write("O'quvchi ismini kiriting: ");
            string name = Console.ReadLine();

            Console.Write("O'quvchi familiyasini kiriting: ");
            string sureName = Console.ReadLine();

            Console.Write("O'quvchi sinfini kiriting: ");
            int @class = int.Parse(Console.ReadLine());

            Console.WriteLine("Iltimos, bahoning raqamli qiymatini kiriting (5, 4, 3, 2):");
            int userInputBaho = int.Parse(Console.ReadLine());

            if (Enum.IsDefined(typeof(Student.Grade), userInputBaho))
            {
                Student.Grade baho = (Student.Grade)userInputBaho;

                // Ro'yxatga yangi o'quvchini qo'shish
                students.Add(new Student(Guid.NewGuid(), name, sureName, @class, baho));

                Console.WriteLine("\nO'quvchi muvaffaqiyatli qo'shildi!");
            }
            else
            {
                Console.WriteLine("Xato: Baho noto‘g‘ri kiritilgan.");
            }
        }

        // Ma'lum bir bahoga ega o'quvchilarni chiqarish
        public void GetStudentsByGrade()
        {
            Console.WriteLine("Qaysi bahoga ega o'quvchilarni ko'rmoqchisiz? (5, 4, 3, 2): ");
            int userInputBaho = int.Parse(Console.ReadLine());

            if (Enum.IsDefined(typeof(Student.Grade), userInputBaho))
            {
                Student.Grade searchGrade = (Student.Grade)userInputBaho;

                // Filtirlash va natijani chiqarish
                var filteredStudents = students.FindAll(student => student.Baho == searchGrade);

                if (filteredStudents.Count > 0)
                {
                    Console.WriteLine("\nUshbu bahoga ega o'quvchilar:");
                    foreach (var student in filteredStudents)
                    {
                        Console.WriteLine($"ID: {student.Id}, Ism: {student.Name}, Familya: {student.SureName}, Sinf: {student.Class}, Baho: {student.Baho}");
                    }
                }
                else
                {
                    Console.WriteLine("Bunday bahoga ega o'quvchi topilmadi.");
                }
            }
            else
            {
                Console.WriteLine("Xato: Noto'g'ri baho kiritildi.");
            }
        }
    }
}
