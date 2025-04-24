using System;
using System.Collections.Generic;

namespace StudentManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Öğrenci Takip Sistemi");
                Console.WriteLine("1. Öğrenci Ekle");
                Console.WriteLine("2. Öğrencileri Listele");
                Console.WriteLine("3. Öğrenci Sil");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminizi yapın: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(students);
                        break;
                    case 2:
                        ListStudents(students);
                        break;
                    case 3:
                        DeleteStudent(students);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }
            }
        }

        static void AddStudent(List<Student> students)
        {
            Console.Write("Öğrencinin adını girin: ");
            string name = Console.ReadLine();
            Console.Write("Öğrencinin numarasını girin: ");
            string number = Console.ReadLine();

            students.Add(new Student(name, number));
            Console.WriteLine("Öğrenci başarıyla eklendi!");
            Console.ReadKey();
        }

        static void ListStudents(List<Student> students)
        {
            Console.WriteLine("Öğrenciler:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Number}");
            }
            Console.ReadKey();
        }

        static void DeleteStudent(List<Student> students)
        {
            Console.Write("Silmek istediğiniz öğrencinin numarasını girin: ");
            string number = Console.ReadLine();

            var student = students.Find(s => s.Number == number);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Öğrenci başarıyla silindi!");
            }
            else
            {
                Console.WriteLine("Öğrenci bulunamadı!");
            }
            Console.ReadKey();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Student(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}

