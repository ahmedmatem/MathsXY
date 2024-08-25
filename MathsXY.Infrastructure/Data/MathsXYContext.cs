namespace MathsXY.Infrastructure.Data
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using MathsXY.Infrastructure.Data.Models;

    public class MathsXYContext : DbContext
    {
        public MathsXYContext(DbContextOptions options) : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ApplyAuditInfoRules();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void ApplyAuditInfoRules()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(e => e.Entity is DataModel))
            {
                var entity = (DataModel)entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    entity.Id = Guid.NewGuid().ToString();
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    entity.DeletedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
