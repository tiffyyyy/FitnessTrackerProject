using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerProject
{
    internal class Food
    {
        public string Name { get; set; }    
        public int CaloriesPerServing { get; set; }
        public Food(string name, int caloriesPerServing)
        {
            this.Name = name;
            this.CaloriesPerServing = caloriesPerServing;
        }

            public override string ToString()
        {
            return "Food Intake: " + Name + "\n" + "Food Calories: " + CaloriesPerServing + "\n";
        }
    }
}
