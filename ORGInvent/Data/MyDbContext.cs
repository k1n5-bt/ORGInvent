using ORGInvent.Data.Tables;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace ORGInvent.Data
{
    public class MyDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            var model = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            _ = sqlGenerator.Generate(model.StoreModel);
        }

        public DbSet<Tables.User> Users { get; set; }
        public DbSet<Tables.Worker> Workers { get; set; }
        public DbSet<Tables.MB> MbSet { get; set; }
        public DbSet<Tables.RAM> RamSet { get; set; }
        public DbSet<Tables.VideoCard> VideoCardSet { get; set; }
        public DbSet<Tables.CPU> CpuSet { get; set; }
        public DbSet<Tables.OS> OsSet { get; set; }
        public DbSet<Tables.DataStorage> DataStorageSet { get; set; }
        public DbSet<Tables.GeneralInformation> GeneralInformation { get; set; }
        public DbSet<Tables.Equipment> Equipments { get; set; }
        public DbSet<Tables.Moving> Movings { get; set; }
        public DbSet<Tables.Modernization> Modernizations { get; set; }
      
    }
}
