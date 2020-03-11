using System;
using System.Collections.Generic;
using System.Text;

namespace SyntacticSugar
{
    public class Bug
    {
        /*
            You can declare a typed public property, make it read-only,
            and initialize it with a default value all on the same
            line of code in C#. Readonly properties can be set in the
            class' constructors, but not by external code.
        */
        public string Name { get; }
        public string Species { get; }
        public List<string> Predators { get; }
        public List<string> Prey { get; }

        // Convert this readonly property to an expression member
        public string FormalName => $"{Name} the {Species}";

        // Class constructor
        public Bug(string name, string species, List<string> predators, List<string> prey)
        {
            Name = name;
            Species = species;
            Predators = predators;
            Prey = prey;
        }

        // Convert this method to an expression member
        public string PreyList() => string.Join(",", Prey);

        // Convert this method to an expression member
        public string PredatorList() => string.Join(",", this.Predators);

        // Convert this to expression method

        public string Eat(string food) => Prey.Contains(food) ? $"{Name} ate the {food}." : $"{this.Name} is still hungry.";

    }
}
