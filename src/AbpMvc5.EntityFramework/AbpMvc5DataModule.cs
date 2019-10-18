using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using AbpMvc5.EntityFramework;

namespace AbpMvc5
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AbpMvc5CoreModule))]
    public class AbpMvc5DataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AbpMvc5DbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
