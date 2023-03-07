using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerProject
{
    internal class Workout
    {
        public string? Type { get; set; }
        public int NumberOfDays { get; set; }
        public string? Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public Intensity Intensity { get; set; }

        public Workout(string? type, int NumberOfDays, string duration, int caloriesBurned, Intensity intensity) : base()
        {
            Type = type;
            this.NumberOfDays = NumberOfDays;
            Duration = duration;
            CaloriesBurned = caloriesBurned;
            Intensity = intensity;
        }

        public Workout(string? type, int numberOfDays, string duration, Intensity intensity)
        {
            Type = type;
            NumberOfDays = numberOfDays;
            Duration = duration;
            Intensity = intensity;
        }

        public override string ToString()
        {
            return "Type of Workout: " + Type + "\n" + "Number of Day/s: " + NumberOfDays + "\n" + "Time Duration(minute/s): " + Duration +
                "\n" + "Exercise Intensity: " + Intensity + "\n" + "Calories Burned: " + CaloriesBurned + "\n";
        }
    }
}
