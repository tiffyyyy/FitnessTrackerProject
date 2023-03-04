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
    internal class CalculateCalories : Workout
    {
        public int CaloriesPerMinute { get; set; }


        public CalculateCalories(string? type, int numberOfDays, string duration, Intensity intensity) : base(type, numberOfDays, duration, intensity)
        {
            this.CaloriesPerMinute = 0;
            
            switch (type)
            {
                case "Running":
                    switch (intensity)
                    {
                        case Intensity.Light:
                            CaloriesPerMinute = 1;
                            break;
                        case Intensity.Moderate:
                            CaloriesPerMinute = 2;
                            break;
                        case Intensity.Vigorous: 
                            CaloriesPerMinute = 3;
                            break;
                    }
                    break;
            }


        }
    }
}

