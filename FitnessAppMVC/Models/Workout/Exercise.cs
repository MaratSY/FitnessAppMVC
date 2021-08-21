using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.Models.Workout
{
    public class Exercise
    {
        public ushort Id { get; set; }

        public int Name { get; set; }

        public ExerciseType ExerciseType { get; set; }

        public Enum WorkoutType { get; set; }
    }
}
