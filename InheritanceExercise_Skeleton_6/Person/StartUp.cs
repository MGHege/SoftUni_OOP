﻿using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());
            if (age<=15)
            {
                var child = new Child(name, age);

                Console.WriteLine(child);
            }
            else
            {
                var person = new Person(name, age);

                Console.WriteLine(person);
            }
            
        }
    }
}