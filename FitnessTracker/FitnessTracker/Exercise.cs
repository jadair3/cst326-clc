using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class Exercise
    {
        //list of exercise properties
        public string DayOfWeek { get; set; }
        public string Type { get; set; }
        public string MuscleGroup { get; set;}
        public string Reps { get; set; }
        public string Minutes { get; set; }


        public Exercise(string dayOfWeek, string type, string muscleGroup, string reps, string minutes)
        {
            DayOfWeek = dayOfWeek;
            Type = type;
            MuscleGroup = muscleGroup;
            Reps = reps;
            Minutes = minutes;

        }

        public Exercise()
        {
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} {2} {3} {4}", DayOfWeek, Type, MuscleGroup, Reps, Minutes);
            }
        }
    }
}