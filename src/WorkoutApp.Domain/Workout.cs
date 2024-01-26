namespace WorkoutApp.Domain;

public class Workout
{
    public DateOnly CurrentDateOnly { get; set; }
    public Guid ID { get; set; }
    public List<Exercise> Exercises { get; set; } = new List<Exercise>();
}