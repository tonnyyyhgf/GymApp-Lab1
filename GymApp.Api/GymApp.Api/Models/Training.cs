namespace GymApp.Api.Models;

public class Training
{
    public int TrainingId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Price { get; set; }
    public int Duration { get; set; }
    
    public int DirectionId { get; set; }
    public Direction Direction { get; set; } = null!;
    
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; } = null!;

    public List<Recording> Recordings { get; set; } = new();
}