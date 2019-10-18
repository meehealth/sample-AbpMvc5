using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AbpMvc5.EntityFramework;

namespace AbpMvc5.Migrator
{
    [DependsOn(typeof(AbpMvc5DataModule))]
    public class AbpMvc5MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AbpMvc5DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}