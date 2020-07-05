using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;
namespace DatingApp.API.Data 
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base (options) {
        }

    //values name here will be used to create the table
        public DbSet<Value> Values {get; set;}
        
    }
}