using FitnessAppMVC.Models.Workout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.Form.Exercises
{
    public class CreateNewExercisesForm
    {
        //public ExerciseType ExerciseType { get; set; }
        public string Name { get; set; }
        public WorkoutType WorkoutType { get; set; }
    }
}
