using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Classes
{
    internal class Person_with_Constructor
    {
        // Fields
        private string name;
        private int age;
        private double height;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Height
        {
            get { return height; }
            set{ height = value; }
        }

        //Methods
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old. I am {height} feet tall. ");
        }

        // Constructor
        public Person_with_Constructor(string initialName, int initialAge, double initialHeight)
        {
            name = initialName;
            age = initialAge;
            height = initialHeight;

            //Extra 3 // From Lambda below, add current instance to "instances" list.
            instances.Add(this);
        }

        //Extra 1 // Let's add all the instances of this class to a list so that we can iterate and sort thme if needed.
        private static List<Person_with_Constructor> instances = new List<Person_with_Constructor>();

        // Extra 2 // Static property to get all the instances using Lambdas functions
        public static IEnumerable<Person_with_Constructor> AllInstances => instances;


    }
}
