namespace GymApp.Api.Models;

public class User
{
    public int UserId { get; set; }
    public string Login { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    
    public Trainer? Trainer { get; set; }
    public List<Recording> Recordings { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();
    public List<Address> Addresses { get; set; } = new();
}