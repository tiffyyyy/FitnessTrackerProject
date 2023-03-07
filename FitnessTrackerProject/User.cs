using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerProject
{
    internal class User  
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public CalculateCalories? CalculateCalories { get; set; }
        public List<Food> Food { get; set; }
        public List<Workout>? Workouts { get; set; }


        public User(String name, int weight, double height, int age, List<Food> food, CalculateCalories calculateCalories, List<Workout> workouts) 
        {
            Name = name;
            this.Weight = weight;
            this.Height = height;
            Age = age;
            Food = food;
        }
        public override string ToString()
        {
            return "Practitioner's Name: " + Name + "\n" + "Current Weight(kg): " + Weight + "\n" + "Height(m): " + Height + "\n" + "Age: " + Age + "\n";
        }
    }
}
