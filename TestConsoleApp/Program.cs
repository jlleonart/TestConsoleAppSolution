using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("To the C# World");

            int NumberOfStudents = 17;
            var TotalInClass = NumberOfStudents + 2;
            Console.WriteLine($"Number of Students is {NumberOfStudents}, total is {TotalInClass}");
            var myName = "Joel";
            Console.WriteLine($"{myName} is one of the {NumberOfStudents} students");
            Console.WriteLine($"{myName} is one of the {NumberOfStudents}students");
        }
    }
}
