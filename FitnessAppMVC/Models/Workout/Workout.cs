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

        public List<Exercise> ListOfExercises { get; set; }
    }

    public enum WorkoutType
    {
        Aerobic,
        Anaerobic,
        StretchingAndFlexibility
    }
}
