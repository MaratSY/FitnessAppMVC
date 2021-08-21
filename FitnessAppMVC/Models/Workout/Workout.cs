using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.Models.Workout
{
    public class Workout
    {
        public ushort Id { get; set; }

        public int Name { get; set; }

        public Enum WorkoutType { get; set; }

        public List<Exercise> Exercises { get; set; }
    }

    // many-to-many
    public class WorkoutExercise 
    {

    }

    public enum WorkoutType
    {
        Aerobic = 0,
        Anaerobic = 1,
        StretchingAndFlexibility = 2
    }
}
