using AbpMvc5.EntityFramework;
using EntityFramework.DynamicFilters;

namespace AbpMvc5.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AbpMvc5DbContext _context;

        public InitialHostDbBuilder(AbpMvc5DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
