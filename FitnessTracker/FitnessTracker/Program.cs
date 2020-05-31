using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\demos\exerciseLog.txt";
           

            List<Exercise> exercise = new List<Exercise>();
            List<String> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                Exercise e = new Exercise();
                e.DayOfWeek = entries[0];
                e.Type = entries[1];
                e.MuscleGroup = entries[2];
                e.Reps = entries[3];
                e.Minutes = entries[4];

                exercise.Add(e);

            }

            //print a list of people and save the list to another file
            // output lines will be used to save the file

            List<String> outputLines = new List<String>();
            Console.WriteLine("The exercises I have completed: ");
            foreach (Exercise e in exercise)
            {
                //first print to the console.
                Console.WriteLine("Day: " + e.DayOfWeek + " Type: " + e.Type + " MuscleGroup: " + e.MuscleGroup + " Reps: " + e.Reps + " Minutes: " + e.Minutes);

                //add another line for the file output
                outputLines.Add("Day: " + e.DayOfWeek + " Type: " + e.Type + " MuscleGroup: " + e.MuscleGroup + " Reps: " + e.Reps + " Minutes: " + e.Minutes);
            }

            //write to another file
            string outPath = @"C:\demos\completedWorkouts.pdf";
            File.WriteAllLines(outPath, outputLines);
            Console.ReadLine();
        }
    }
}

