using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class Workout
    {
        // ################################################################
        // Fields    
        
        public String workoutName;
        public int workoutDuration;
        public String workoutDifficulty;
        public List<Exercise> allExercises;
        public List<Exercise> selectedExercises;
        public int workoutActualDuration = 0;
        public int workoutNumberOfExercises = 0;

        // ################################################################
        // Constructor
        public Workout(String name, int duration, String difficulty)
        {            
            workoutName = name;
            workoutDuration = duration;
            workoutDifficulty = difficulty;

            selectedExercises = new List<Exercise>();

            allExercises = new List<Exercise>();
            
            allExercises.Add(new Exercise("Ex01", "easy", 5));
            allExercises.Add(new Exercise("Ex02", "medium", 15));
            allExercises.Add(new Exercise("Ex03", "hard", 10));
            allExercises.Add(new Exercise("Ex04", "easy", 10));
            allExercises.Add(new Exercise("Ex05", "medium", 15));
            allExercises.Add(new Exercise("Ex06", "hard", 8));
            allExercises.Add(new Exercise("Ex07", "easy", 4));
            allExercises.Add(new Exercise("Ex08", "medium", 13));
            allExercises.Add(new Exercise("Ex09", "hard", 5));
            allExercises.Add(new Exercise("Ex10", "easy", 5));
            allExercises.Add(new Exercise("Ex11", "medium", 10));
            allExercises.Add(new Exercise("Ex12", "hard", 8));
            allExercises.Add(new Exercise("Ex13", "easy", 5));
            allExercises.Add(new Exercise("Ex14", "medium", 10));
            allExercises.Add(new Exercise("Ex15", "hard", 15));
            allExercises.Add(new Exercise("Ex16", "easy", 15));
            allExercises.Add(new Exercise("Ex17", "medium", 5));
            allExercises.Add(new Exercise("Ex18", "hard", 5));
            allExercises.Add(new Exercise("Ex19", "easy", 8));
            allExercises.Add(new Exercise("Ex20", "medium", 12));
            allExercises.Add(new Exercise("Ex21", "hard", 8));
            allExercises.Add(new Exercise("Ex22", "easy", 5));
            allExercises.Add(new Exercise("Ex23", "medium", 10));
            allExercises.Add(new Exercise("Ex24", "hard", 15));
            allExercises.Add(new Exercise("Ex25", "easy", 15));
            allExercises.Add(new Exercise("Ex26", "medium", 5));
            allExercises.Add(new Exercise("Ex27", "hard", 5));
            allExercises.Add(new Exercise("Ex28", "easy", 8));
            allExercises.Add(new Exercise("Ex29", "medium", 12));
            allExercises.Add(new Exercise("Ex30", "hard", 5));
            allExercises.Add(new Exercise("Ex31", "easy", 5));
            allExercises.Add(new Exercise("Ex32", "medium", 10));
            allExercises.Add(new Exercise("Ex33", "hard", 15));
            allExercises.Add(new Exercise("Ex34", "easy", 15));
            allExercises.Add(new Exercise("Ex35", "medium", 5));
            allExercises.Add(new Exercise("Ex36", "hard", 5));
            allExercises.Add(new Exercise("Ex37", "easy", 8));
            allExercises.Add(new Exercise("Ex38", "medium", 12));
            allExercises.Add(new Exercise("Ex39", "hard", 5));
        }

        // ################################################################
        // Methods

    }
}
