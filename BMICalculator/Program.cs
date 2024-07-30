using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    
    internal class Program
    {
        static void Print(Person person)
        {
            Console.WriteLine(person);
        }
        static void Main(string[] args)
        {
          Person[] person = {new Person(1, "esha", 21, 5.0, 51),
                             new Person(2, "Preet", 35, 6.7, 50),
                             new Person(3,"Daksh",40,4.2,60),
                             new Person(4,"Parth",22)};

           foreach (Person items in person)
           {
                Print(items);
                Console.WriteLine(items.BMIScore(items.height,items.weight));
                Console.WriteLine(items.BodyType(items.BMIScore(items.height, items.weight)));
                Console.WriteLine();

           }

        }
    }
}
