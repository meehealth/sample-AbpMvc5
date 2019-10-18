using System.Linq;
using AbpMvc5.EntityFramework;
using AbpMvc5.MultiTenancy;

namespace AbpMvc5.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AbpMvc5DbContext _context;

        public DefaultTenantCreator(AbpMvc5DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
