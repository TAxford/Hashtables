using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {   
        // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            Console.WriteLine("Hello World!");
        }
    }

    class Student
    {
        //property called id
        public int Id { get; set; }
        //property called Name
        public string Name { get; set; }
        //property called GPA
        public float GPA { get; set; }
        //simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
