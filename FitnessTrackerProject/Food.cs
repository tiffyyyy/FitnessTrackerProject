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
        public string FoodName { get; set; }    
        public int CaloriesPerServing { get; set; }
        public CalculateCalories? CalculateCalories { get; set; }
        public Food(string foodName, int caloriesPerServing)  
        {
            this.FoodName = foodName;
            this.CaloriesPerServing = caloriesPerServing;
        }

            public override string ToString()
        {
            return "Food Intake: " + FoodName + "\n" + "Food Calories: " + CaloriesPerServing + "\n";
        }
    }
}
