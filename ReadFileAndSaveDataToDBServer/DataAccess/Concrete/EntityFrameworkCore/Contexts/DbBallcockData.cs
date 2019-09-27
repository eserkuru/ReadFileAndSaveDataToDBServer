using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class DbBallcockData : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BallcockData; Trusted_Connection=true");
        }

        public DbSet<Ballcock> Ballcocks { get; set; }
        public DbSet<Adcp> Adcps { get; set; }
        public DbSet<AdcpDetail> AdcpDetails { get; set; }
    }
}
