using System;
using System.Collections.Generic;

namespace LoopingConsole
{
    class Program //leave as Program for the most part
    {
        static void Main(string[] args) //Main-where your app starts execution
        {
            var children = new List<Child>()
            {
                new Child {Name = "Charles", Sick = false},
                new Child {Name = "Jane", Sick = true }
            };

            foreach (var child in children)
            {
                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}.");
                Console.WriteLine(child.ForgeASickNote());
            }

            //Console.WriteLine(charles.ForgeASickNote());

            Console.ReadLine();

        }
    }
}
