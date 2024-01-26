using System;
namespace WorkoutApp.Domain;
public class Exercise
{
    public Guid WorkoutID { get; set; }
    public Guid ExerciseID {get; set; }
    public Workout Workout { get; set; }
    public string ExerciseName {get; set; }
    public double AmountOfWeight {get; set; }
    public int AmountOfReps {get; set; }
    public int AmountOfSets {get; set; }
    public string ExerciseDescrition { get; set; }
}
