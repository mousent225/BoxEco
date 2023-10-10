using BoxEco.Core.Domain.Content;
using BoxEco.Core.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoxEco.Data
{
    public class BoxEcoContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public BoxEcoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<RawDataPnL> RawDataPnL { get; set; }
        public DbSet<AccountDefine> AccountDefine { get; set; }
        public DbSet<SysCategory> SysCategory { get; set; }
        public DbSet<SysCategoryValue> SysCategoryValue { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims").HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => new { x.UserId});
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangeOnSuccess, CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
            foreach (var entry in entries)
            {
                var dateCreatedProp = entry.Entity.GetType().GetProperty("CreateDate");
                if (entry.State == EntityState.Added && dateCreatedProp != null)
                { 
                    dateCreatedProp.SetValue(entry.Entity, DateTime.Now);
                }

                var dateUpdatedProp = entry.Entity.GetType().GetProperty("UpdateDate");
                if (entry.State == EntityState.Modified && dateUpdatedProp != null)
                {
                    dateUpdatedProp.SetValue(entry.Entity, DateTime.Now);
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
