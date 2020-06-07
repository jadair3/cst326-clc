using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class Program
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

            Console.Out.WriteLine("Welcome to your Fitness Tracker! \n");
            int action = chooseAction();
            while (action != 0)
            {
                switch (action)
                {

                    case 1:
                        //choice: Add additional exercises
                        Console.Out.WriteLine("You chose to add additional exercises to your list: \n");

                        // asking for property details
                        String exerciseDay = "";
                        String exerciseType = "";
                        String exerciseMG = "";
                        String exerciseReps = "";
                        String exerciseMin = "";


                        Console.Out.WriteLine("Which day of the week did you work out?");
                        exerciseDay = Console.ReadLine();

                        Console.Out.WriteLine("What type of exercise did you do? (Walk, Run, Strength-Training, etc.)");
                        exerciseType = Console.ReadLine();

                        Console.Out.WriteLine("What muscle group was targeted? ie: (upper body, lower body, total body)");
                        exerciseMG = Console.ReadLine();

                        Console.Out.WriteLine("How many reps were completed?");
                        exerciseReps = Console.ReadLine();

                        Console.Out.WriteLine("How many minutes did you work out?");
                        exerciseMin = Console.ReadLine();

                        //create a new exercise object and add it to the list of imported exercises
                        Exercise workOut = new Exercise();
                        workOut.DayOfWeek = exerciseDay;
                        workOut.Type = exerciseType;
                        workOut.MuscleGroup = exerciseMG;
                        workOut.Reps = exerciseReps;
                        workOut.Minutes = exerciseMin;
                        exercise.Add(workOut);
                        break;

                    case 2:
                        //choice: Export list of completed exercises
                        //print a list of exercises and save the list to another file
                        // output lines will be used to save the file

                        List<String> outputLines = new List<String>();
                        Console.WriteLine("You have completed the following exercises: \n");
                        foreach (Exercise e in exercise)
                        {
                            //first print to the console.
                            Console.WriteLine("Day: " + e.DayOfWeek + " Type: " + e.Type + " MuscleGroup: " + e.MuscleGroup + " Reps: " + e.Reps + " Minutes: " + e.Minutes);

                            //add another line for the file output
                            outputLines.Add("Day: " + e.DayOfWeek + " Type: " + e.Type + " MuscleGroup: " + e.MuscleGroup + " Reps: " + e.Reps + " Minutes: " + e.Minutes);
                        }

                        //write to another file
                        //** work in progress: downloading file to pdf format **
                        string outPath = @"C:\demos\completedWorkouts.txt";
                        File.WriteAllLines(outPath, outputLines);
                        Console.ReadLine();
                        break;


                    default:
                        throw new ArgumentOutOfRangeException("Unknown value, please make a valid selection");
                }


                // calling the user to make a choice
                action = chooseAction();
            }


            int chooseAction()

            //added try-catch with error message for incorrect values
            {
                int choice = 0;
                try
                {
                    Console.Out.WriteLine("Choose an action (0) QUIT (1) Add Additional Exercises (2) Export List \n");
                    choice = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please select option: 0, 1, or 2", e);
                    choice = 0;
                }

                return choice;
            }
        }
    }
}

