using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnEnums
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Educationlevel Level { get; set; }

        public Student(int id,string name,Educationlevel level) 
        { 
           this.Id = id;
            this.Name = name;
            this.Level = level;
        }

    }
}
