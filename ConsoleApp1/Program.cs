using System;
using ConsoleApp1.Services;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Class1.GetName();
            var age = Class1.GetAge();
            Console.WriteLine("Name:{0}\nAge: {1}", name, age);
            Console.WriteLine("My name is {0}, and I am {1} years old", name, age);
        }
         
    }

}


