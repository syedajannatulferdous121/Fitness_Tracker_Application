using System;
using System.Collections.Generic;

class Exercise
{
    public string Type { get; set; }
    public int Duration { get; set; }
    public int Intensity { get; set; }
    public string Notes { get; set; }
}

class FitnessTracker
{
    private List<Exercise> exercises;

    public FitnessTracker()
    {
        exercises = new List<Exercise>();
    }

    public void AddExercise()
    {
        Exercise exercise = new Exercise();

        Console.WriteLine("Enter exercise type:");
        exercise.Type = Console.ReadLine();

        Console.WriteLine("Enter exercise duration (in minutes):");
        exercise.Duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter exercise intensity (1-10):");
        exercise.Intensity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter any additional notes:");
        exercise.Notes = Console.ReadLine();

        exercises.Add(exercise);
    }

    public void DisplayExerciseLog()
    {
        Console.WriteLine("Exercise Log");
        Console.WriteLine("======================");

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine("Type: " + exercise.Type);
            Console.WriteLine("Duration: " + exercise.Duration + " minutes");
            Console.WriteLine("Intensity: " + exercise.Intensity);
            Console.WriteLine("Notes: " + exercise.Notes);
            Console.WriteLine("----------------------");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        FitnessTracker tracker = new FitnessTracker();

        Console.WriteLine("Fitness Tracker Application");
        Console.WriteLine("===========================");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add Exercise");
            Console.WriteLine("2. Display Exercise Log");
            Console.WriteLine("3. Exit");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    tracker.AddExercise();
                    Console.WriteLine("Exercise added successfully.");
                    Console.WriteLine("============================");
                    break;
                case 2:
                    tracker.DisplayExerciseLog();
                    Console.WriteLine("============================");
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.WriteLine("============================");
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Fitness Tracker Application!");
        Console.ReadLine();
    }
}
