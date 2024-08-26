namespace MathsXY.Infrastructure.Data
{
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    using MathsXY.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Identity;

    public class MathsXYContext : IdentityDbContext<IdentityUser>
    {
        public MathsXYContext(DbContextOptions options) : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
