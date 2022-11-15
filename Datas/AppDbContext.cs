using Microsoft.EntityFrameworkCore;
using Papere.Models;

namespace Papere.Datas
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Papera> Papere { get; set; }


    }
}
