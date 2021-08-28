﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.Models.Workout
{
    public class Exercise
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public ExerciseType ExerciseType { get; set; }

        public WorkoutType WorkoutType { get; set; }

        // link to creator
    }
}
