using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnThis
{
    public class Person
    {
        private int id;
        private string name;
        private int age;

        public Person()
        {
            this.id = 0;
            this.name = "Unknown";
            this.age = 0;
        } 
        public Person(int id, string name) : this() // Constructor chaining using this()
        {
            this.id = id;
            this.name = name;
        }
        public Person(int id, string name, int age) : this(id, name)
        {
            this.age = age;
        }
        public void UpdateAge(int age)
        {
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {this.id}, Name: {this.name}, Age: {this.age}");
        }
        public bool IsSamePerson(Person other)
        {
            return this.id == other.id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
            
        {
          Person person1 = new Person(1, "Esha gaikwad", 30);
          Person person2 = new Person(2, "Om Pandey", 25);
          Person person3 = new Person(3, "Vaidehi Ingale");

          person1.Display();
          person2.Display();
          person3.Display();

         Console.WriteLine("Updating age of person1 to 35.");
         person1.UpdateAge(35);
         person1.Display();

         Console.WriteLine("Comparing person1 with person2:");
         Console.WriteLine(person1.IsSamePerson(person2) ? "They are the same person." : "They are different persons.");
           
        }
        
    }
    
}

