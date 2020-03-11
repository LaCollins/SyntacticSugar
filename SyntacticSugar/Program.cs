using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var predatorsForBug1 = new List<string>() { "Mantis", "Bird" };

            predatorsForBug1.Add("Ribbon Snake");

            var preyForBug1 = new List<string>() { "Tomato", "Bell Pepper" };

            preyForBug1.Add("Lettuce");

            var bug1 = new Bug("Bob", "Tomato bug", predatorsForBug1, preyForBug1);

            var predatorsForBug2 = new List<string>() { "Human", "Frontline" };

            var preyForBug2 = new List<string>() { "Cat", "Dog" };

            var bug2 = new Bug("Tilly", "Flea", predatorsForBug2, preyForBug2);

            Console.WriteLine(bug1.Eat("Tomato"));
            Console.WriteLine(bug1.Eat("Celery"));
            Console.WriteLine(bug2.Eat("Dog"));
            Console.WriteLine(bug2.Eat("Mouse"));
        }
    }
}
