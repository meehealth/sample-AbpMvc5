using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using AbpMvc5.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace AbpMvc5.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<AbpMvc5.EntityFramework.AbpMvc5DbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AbpMvc5";
        }

        protected override void Seed(AbpMvc5.EntityFramework.AbpMvc5DbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
