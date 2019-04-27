using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<Entity> where Entity : class
    {
        void Add(Entity entity);

        void Remove(Entity entity);

        void Update(Entity entity);

        ICollection<Entity> GetAll();

        Entity GetById(int id);
    }
}
