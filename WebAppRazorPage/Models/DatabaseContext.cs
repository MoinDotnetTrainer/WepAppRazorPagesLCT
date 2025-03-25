using Microsoft.EntityFrameworkCore;

namespace WebAppRazorPage.Models
{
    public class DatabaseContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial Catalog=db_LCT;Integrated security=true;trustServerCertificate=true");
        }

        public DbSet<Books> Books { get; set; } 

        public DbSet<LateralData> lateralData { get; set; }
    }
}
