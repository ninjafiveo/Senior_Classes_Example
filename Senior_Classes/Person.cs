using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Classes
{
    internal class Person
    {
        // Field
        private string name;

        // Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Method
        public void Introduce()
        {
            Console.WriteLine($"Hi my name is {name}.");
        }

        public void Say_Goodbye()
        {
            Console.WriteLine($"{name} says bye y'all");
        }
    }
}
