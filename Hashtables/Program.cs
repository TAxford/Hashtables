﻿using System;

namespace Hashtables
{
    internal class Program
    {   
        // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
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
