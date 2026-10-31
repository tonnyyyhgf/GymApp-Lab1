using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymApp.Api.Models;

public class Trainer
{
    [Key]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Patronymic { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public string Experience { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    
    public User User { get; set; } = null!;
    public List<Training> Trainings { get; set; } = new();
    public List<Recording> Recordings { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();
}