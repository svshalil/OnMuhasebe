using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace OnMuhasebe.Commons;
public interface ICommonRepository<TEntity> : IRepository<TEntity, Guid> 
    where TEntity : class, IEntity<Guid>
{
    Task<TEntity> GetAsync(object id, Exception<Func<TEntity,bool>> predicate=null, );
}