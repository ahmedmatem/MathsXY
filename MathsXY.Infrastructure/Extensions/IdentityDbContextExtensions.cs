namespace MathsXY.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using MathsXY.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;

    public static class IdentityDbContextExtensions
    {
        public static void ApplyAuditInfoRules(this IdentityDbContext<IdentityUser> context)
        {
            foreach (var entry in context.ChangeTracker.Entries()
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
