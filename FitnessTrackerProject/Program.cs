using FitnessTrackerProject;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fitness Tracker for Cardiovascular Exercises

Practitioner prac = new Practitioner("Tiffany Andrade", 47, 1.49, 20);
Food a = new Food("Chocolate Milk", 208);
Food b = new Food("White Beans", 249);
Food c = new Food("Sweet Potato", 118);

Workout activity1 = new Workout("Running", 1, "20-30", 300, Intensity.Moderate);
Workout activity2 = new Workout("Cycling", 2, "5-10", 400, Intensity.Light);


Console.WriteLine(prac.ToString());
Console.WriteLine(a.ToString());
Console.WriteLine(b.ToString());
Console.WriteLine(c.ToString());
Console.WriteLine(activity1.ToString());
