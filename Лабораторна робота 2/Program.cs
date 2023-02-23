
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program1
{
//    static void Main(string[] args)
//    {
//        string filePath = "students.txt";

//        if (!File.Exists(filePath))
//        {
//            Console.WriteLine("File does not exist.");
//            return;
//        }

//        string[] lines = File.ReadAllLines(filePath);
//        var students = lines.Select(line =>
//        {
//            string[] parts = line.Split(',');
//            return new Student
//            {
//                Name = parts[0],
//                Grade = int.Parse(parts[1])
//            };
//        });

//        var goodStudents = students.Where(s => s.Grade >= 80);

//        Console.WriteLine("Good Students:");
//        foreach (var student in goodStudents)
//        {
//            Console.WriteLine(student.Name + " - " + student.Grade);
//        }
//    }

//    class Student
//    {
//        public string Name { get; set; }
//        public int Grade { get; set; }
//    }
}

class Employee2
{
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//    public int YearsOfExperience { get; set; }
//}

//class Program2
//{
//    static void Main(string[] args)
//    {
//        var lines = File.ReadAllLines("employees.csv");

//        var employees = new List<Employee2>();

//        foreach (var line in lines)
//        {
//            var parts = line.Split(',');
//            var employee = new Employee2
//            {
//                Name = parts[0],
//                Salary = decimal.Parse(parts[1]),
//                YearsOfExperience = int.Parse(parts[2])
//            };
//            employees.Add(employee);
//        }

//        employees = employees.OrderByDescending(e => e.Salary).ToList();
      
//        foreach (var employee in employees)
//        {
//            Console.WriteLine("{0}: {1:C}", employee.Name, employee.Salary);
//        }
//    }
}

class Product3
{
//    public string Name { get; set; }
//    public string Category { get; set; }
//    public decimal Price { get; set; }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Product3> products = File.ReadAllLines("products.txt")
//            .Select(line => line.Split(','))
//            .Select(fields => new Product3
//            {
//                Name = fields[0],
//                Category = fields[1],
//                Price = decimal.Parse(fields[2])
//            })
//            .ToList();

//        var groupedProducts = products.GroupBy(p => p.Category);

//        foreach (var group in groupedProducts)
//        {
//            Console.WriteLine(group.Key + ":");
//            foreach (var product in group)
//            {
//                Console.WriteLine(" - " + product.Name + " - " + product.Price);
//            }
//        }
//    }
}

class Program4
{
    delegate int StringLength(string s);

    static void Main(string[] args)
    {
        List<string> strings = new List<string>() { "hello", "ukraine", "this", "is", "a", "dog" };

        StringLength lengthDelegate = s => s.Length;

        foreach (string s in strings)
        {
            int length = lengthDelegate(s);
            Console.WriteLine("Length of \"{0}\": {1}", s, length);
        }
    }
}