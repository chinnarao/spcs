using Microsoft.EntityFrameworkCore;
using common.admodels;

namespace ad.services.db
{
    //https://github.com/damienbod/AspNetCoreMultipleProject/blob/master/src/DataAccessMsSqlServerProvider/DomainModelMsSqlServerContext.cs
    public class AdDbContext : DbContext
    {
        public AdDbContext(DbContextOptions<AdDbContext> options) : base(options)
        {
        }

        public DbSet<Ad> Ad { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<DataEventRecord> DataEventRecords { get; set; }
        //public DbSet<SourceInfo> SourceInfos { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<DataEventRecord>().HasKey(m => m.DataEventRecordId);
        //    builder.Entity<SourceInfo>().HasKey(m => m.SourceInfoId);
        //    // shadow properties
        //    builder.Entity<DataEventRecord>().Property<DateTime>("UpdatedTimestamp");
        //    builder.Entity<SourceInfo>().Property<DateTime>("UpdatedTimestamp");
        //    base.OnModelCreating(builder);
        //}
    }
}
