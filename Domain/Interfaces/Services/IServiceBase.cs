using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Remove(TEntity entity);

        void Update(TEntity entity);

        ICollection<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
