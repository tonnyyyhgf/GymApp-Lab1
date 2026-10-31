using Microsoft.EntityFrameworkCore;
using GymApp.Api.Models;

namespace GymApp.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Hall> Halls { get; set; }
    public DbSet<Direction> Directions { get; set; }
    public DbSet<Training> Trainings { get; set; }
    public DbSet<Recording> Recordings { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Address> Addresses { get; set; }
}