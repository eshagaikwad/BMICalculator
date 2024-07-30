using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PocOnEnums
{
    public enum Educationlevel
    { 
        primary,
        secondary,
        highSchool,
        undergraduate,
        Postgraduate
    }
    internal class Program
    {
        public static void PrintDetails(Student student)
        {
            Console.WriteLine($"Student Id: {student.Id}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Education Level: {student.Level}");
        }
        static void Main(string[] args)
        {
         Student student1=new Student(1,"Esha",Educationlevel.undergraduate);
         PrintDetails(student1);
         Console.WriteLine();
         Student student2 = new Student(2, "Parth", Educationlevel.Postgraduate);
         PrintDetails(student2);
        }
    }
}
