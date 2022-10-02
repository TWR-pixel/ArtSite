using ArtSite.Data.Models;

namespace ArtSite.Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : EntityBase
{
    public ValueTask CreateAndSave(TEntity entity);
    public ValueTask<TEntity> GetById(Guid id);
    public ValueTask<IList<TEntity>> GetAll();


}
