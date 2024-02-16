using Microsoft.EntityFrameworkCore;
using Task_Management.Models;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){

    }
    public DbSet<UserModel> users {get; set;}
}