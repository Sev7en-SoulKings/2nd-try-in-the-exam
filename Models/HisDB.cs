using Microsoft.EntityFrameworkCore;

namespace THE_REAL_ONE.Models
{
    public class HisDB : DbContext
    {
        public DbSet<HisPProjects> HisPProjects { get; set; }
        public DbSet<HisTTasks> HisTTasks { get; set; }
        public DbSet<HisTTeamMembers> HisTTeamMembers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Xeroooooooooo;Persist Security Info=True;User ID=sa;Password=FIATS@2024;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
