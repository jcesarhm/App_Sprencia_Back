using Microsoft.EntityFrameworkCore;
using SPRENCIA.Domain.Models;


namespace SPRENCIA.Infraestructure
{
    public class SprenciaDbContext: DbContext
    {
         public SprenciaDbContext(DbContextOptions<SprenciaDbContext> options) : base(options) 
        { 

        }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
