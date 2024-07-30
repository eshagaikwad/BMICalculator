using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double height { get; set; }
        public int weight { get; set; }

        public double BmiStored;
        public const double heightConstVar = 0.3048;
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            this.height = 5;
            this.weight = 50;
        }
        public Person(int id, string name, int age, double height, int weight) : this(id, name, age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.height = height;
            this.weight = weight;

        }
        public double BMIScore(double height, int weight)
        {
            double heightInmeters = height * heightConstVar;
            double bmi = weight / Math.Pow(heightInmeters, 2);
            BmiStored = bmi;

            return BmiStored;

        }
        public override string ToString()
        {
            return $"Person Id: {Id} \n"+
                    $"Person name: {Name}\n"+
                    $"Person Age: {Age}\n" +
                    $"Person Height: {height} \n"+
                    $"Person Weight: {weight}";
        }
        public string BodyType(double BMI)
        {
            string category=" ";

            if (BMI < 18.5)
              category=  "underweight";

            else if (BMI >= 18.5 && BMI < 24.9)
                category = "Healthy";

            else if (BMI >= 24.9 && BMI < 30)
                category="overweight";

            else if (BMI >= 30)
                category="Suffering from Obesity";

            return category;
        }

    }
}
