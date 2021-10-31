using System;
using System.Linq;
using System.Collections.Generic;

namespace FuncExamplePoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindOne(a => a.Age == 18).Name);
        }

        static Student FindOne(Func<Student, bool> a)
        {
            var students = new List<Student>()
            {
                new Student("Nicolle",13),
                new Student("Gustavo",14),
                new Student("Silene",15),
                new Student("Melissa",16),
                new Student("Chancha",17),
                new Student("Fabão",18)
            };

            return students.FirstOrDefault(a);
        }
    }

    class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
