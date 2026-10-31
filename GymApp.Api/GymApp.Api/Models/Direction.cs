namespace GymApp.Api.Models;

public class Direction
{
    public int DirectionId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    public List<Training> Trainings { get; set; } = new();
}