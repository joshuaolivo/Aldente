using Aldente.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aldente.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private string tenantId { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ITenantService tenant) : base(options)
        {
            tenantId = tenant.getTenant();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach(var entity in builder.Model.GetEntityTypes())
            {
                var type = entity.ClrType;
                if (typeof(ITenantEntity).IsAssignableFrom(type))
                {
                    var method = typeof(ApplicationDbContext).GetMethod(nameof(CreateGlobalFilter), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);
                    var filter = method?.Invoke(null, new object[] { this })!;
                    entity.SetQueryFilter((LambdaExpression)filter);
                    entity.AddIndex(entity.FindProperty(nameof(ITenantEntity.TenantId))!);
                }
                else if (type.NoValidateTenant())
                {
                    continue;
                }
                else
                {
                    throw new Exception($"The entity {entity} have not named like Tenant or Common entity");
                }
            }
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Added && e.Entity is ITenantEntity))
            {
                if (string.IsNullOrEmpty(tenantId))
                {
                    throw new Exception("The tenant Id was not found");
                }

                var entity = item.Entity as ITenantEntity;
                entity!.TenantId = tenantId;
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        private static LambdaExpression CreateGlobalFilter<TEntity>(ApplicationDbContext context) where TEntity : class, ITenantEntity
        {
            Expression<Func<TEntity, bool>> filter = x => x.TenantId == context.tenantId;
            return filter;
        } 
    }
}
