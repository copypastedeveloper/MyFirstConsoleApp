using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            //get data from a user
            Console.WriteLine("Please enter your name...");
            name = Console.ReadLine();

            //this will not work because static types
            //name = 7;

            //csharp has a lot of specificty around numbers
            //32 bit signed number
            int favoriteNumber = -6;
            
            //64 bit signed numbers
            long reallyBigNumber = 9_223_372_036_854_775_806;

            //16 bit signed numbers
            short smallerNumbers = 32_000;

            //stuff with decimals
            double accountBalance = 0.57;
            //decimal accountBalance = 0.57m;

            //var is a shorthand for the real type
            //type inference
            var myStuff = 5 * 5;
            //this still won't work
            //myStuff = "";

            //bool is for boolean
            var isTeaching = true;

            //datetime is for holding.... datetime
            var today = new DateTime(2021,7,13);
            today = DateTime.Today;


            //arrays are not much fun in c#
            //var students = new string[5];

            // instance/ instatiation
            //             list of string
            var students = new List<string>();

            students.Add("Hunter");
            students.Add("Rob");
            students.Add("Jimbo");

            students.Remove("Jimbo");

            for(var i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            //more idiomatic
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            //csharp one equal for set and two for equality

        }
    }
}
