namespace MyFirstProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Workout newWorkout = CreateWorkoutFromUserInput();

            RemoveExcercisesFromList(newWorkout);

            SelectRandomExercisesFromList(newWorkout);

            ShowSummmaryOfWorkout(newWorkout);
            
            ShowRandomlySelectedExcercises(newWorkout.selectedExercises);

            Console.ReadKey();

        }

        public static Workout CreateWorkoutFromUserInput()
        {
            String workoutName;
            int workoutDuration;
            String workoutDifficulty;
            Workout newWorkout;
        
            Console.WriteLine("What would you like to call this workout?");
            workoutName = Console.ReadLine();

            Console.WriteLine("How long have you got? (in minutes)");
            workoutDuration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How challenging would you like the workout to be? (easy/medium/hard)");
            workoutDifficulty = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"\tWorkout name = \"{workoutName}\"");
            Console.WriteLine($"\tMaximum duration = {workoutDuration} minutes");
            Console.WriteLine($"\tDifficulty level = {workoutDifficulty}");

            newWorkout = new Workout(workoutName, workoutDuration, workoutDifficulty);

            return newWorkout;
        }

        public static void RemoveExcercisesFromList(Workout workoutToBeModified)
        {
            for (int i = workoutToBeModified.allExercises.Count - 1; i > -1; i--)
            {
                switch (workoutToBeModified.workoutDifficulty)
                {
                    case "easy":

                        if (workoutToBeModified.allExercises[i].difficulty == "medium" || workoutToBeModified.allExercises[i].difficulty == "hard")
                        {
                            workoutToBeModified.allExercises.RemoveAt(i);
                        }
                        break;

                    case "medium":

                        if (workoutToBeModified.allExercises[i].difficulty == "hard")
                        {
                            workoutToBeModified.allExercises.RemoveAt(i);
                        }
                        break;

                    case "hard":
                        break;
                }
            }
        }
        public static int GetRandomExerciseFromList(int max)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, max + 1);

            return randomNumber - 1;
        }

        public static void SelectRandomExercisesFromList(Workout workoutToBeModified)
        {

            for (int i = 0; i < workoutToBeModified.allExercises.Count; i++)
            {
                int randomExcercise = GetRandomExerciseFromList(workoutToBeModified.allExercises.Count);

                if (workoutToBeModified.workoutActualDuration + workoutToBeModified.allExercises[randomExcercise].duration < workoutToBeModified.workoutDuration)
                {
                    workoutToBeModified.selectedExercises.Add(new Exercise( workoutToBeModified.allExercises[randomExcercise].name,
                                                                            workoutToBeModified.allExercises[randomExcercise].difficulty,
                                                                            workoutToBeModified.allExercises[randomExcercise].duration));

                    workoutToBeModified.workoutActualDuration += workoutToBeModified.allExercises[randomExcercise].duration;

                    workoutToBeModified.allExercises.RemoveAt(randomExcercise);

                    workoutToBeModified.workoutNumberOfExercises++;
                }
            }
        }

        public static void ShowSummmaryOfWorkout(Workout workoutToBeModified)
        {
            Console.WriteLine();
            Console.WriteLine("\t####################################");
            Console.WriteLine($"\tNumber of exercises in workout: {workoutToBeModified.workoutNumberOfExercises}");
            Console.WriteLine($"\tDuration of workout: {workoutToBeModified.workoutActualDuration} minutes");
            Console.WriteLine("\t####################################");
            Console.WriteLine();
        }

        public static void ShowRandomlySelectedExcercises(List<Exercise> exercises)
        {
            for (int i = 0; i < exercises.Count; i++)
            {
                Console.WriteLine($"\t - Ex {i + 1} = " +
                                    $"{exercises[i].name}," +
                                    $"{exercises[i].duration} minutes," +
                                    $"{exercises[i].difficulty}");
            }
        }

    }
}
