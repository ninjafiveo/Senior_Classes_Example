using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person_Class();

            Console.ReadLine();
        }

        static void Person_Class() 
        { 
            Person person = new Person();
            person.Name = "Jonesy";
            person.Introduce();

            Person person1 = new Person();
            person1.Name = "Philipe";
            person1.Say_Goodbye();

            Person_with_Constructor employee2 = new Person_with_Constructor("Bob", 44, 5.8);
            Person_with_Constructor employee3 = new Person_with_Constructor("Kelly", 33, 6.5);
            Person_with_Constructor employee4 = new Person_with_Constructor("Freddie", 22, 4.8);
            Person_with_Constructor employee5 = new Person_with_Constructor("Ricky", 88, 5.5);
            Person_with_Constructor employee6 = new Person_with_Constructor("Mikey", 46, 6.2);
            Person_with_Constructor employee7 = new Person_with_Constructor("Roxanne", 26, 5.2);
            Person_with_Constructor employee8 = new Person_with_Constructor("Sarah", 46, 4.9);
            Person_with_Constructor employee9 = new Person_with_Constructor("Jesse", 46, 6.1);

            foreach (var item in Person_with_Constructor.AllInstances)
            {
                item.Introduce();
            }


        }

    }
}
