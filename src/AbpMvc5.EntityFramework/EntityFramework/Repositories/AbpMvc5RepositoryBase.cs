using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpMvc5.EntityFramework.Repositories
{
    public abstract class AbpMvc5RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AbpMvc5DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpMvc5RepositoryBase(IDbContextProvider<AbpMvc5DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AbpMvc5RepositoryBase<TEntity> : AbpMvc5RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpMvc5RepositoryBase(IDbContextProvider<AbpMvc5DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
