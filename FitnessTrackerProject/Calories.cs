using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FitnessTrackerProject
{
    internal class Calories : Workout
    {
        public int CaloriesPerMinute { get; set; }


        public Calories(string? type, int numberOfDays, int duration, Intensity intensity) : base(type, numberOfDays, duration, intensity)
        {
            this.CaloriesPerMinute = 0;

            switch (type)
            {
                case "Running":
                    switch (intensity)
                    {
                        case Intensity.Light:
                            CaloriesPerMinute = 20;
                            break;
                        case Intensity.Moderate:
                            CaloriesPerMinute = 40;
                            break;
                        case Intensity.Vigorous:
                            CaloriesPerMinute = 60;
                            break;
                    }
                    break;
            }


        }

        public int CalculateCalories(int CaloriesPerMinute)
        {
            CaloriesPerMinute = this.CaloriesPerMinute * base.Duration;
            return CaloriesPerMinute;
        }

        public int BurnedCalories(int CaloriesPerMinute, int CaloriesPerServing, Food FoodCal) 
        {
            Food Foodcal = new Food("", 0);
            base.CaloriesBurned = Foodcal.CaloriesPerServing  - CaloriesPerMinute;

            return base.CaloriesBurned;
        }
    }

}

