using System.Collections.Generic;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ServiceBase<Entity> : IServiceBase<Entity> where Entity : class
    {
        private readonly IRepositoryBase<Entity> _repository;

        public ServiceBase(IRepositoryBase<Entity> repository)
        {
            _repository = repository;
        }

        public void Add(Entity entity)
        {
            _repository.Add(entity);
        }

        public ICollection<Entity> GetAll()
        {
            return _repository.GetAll();
        }

        public Entity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Entity entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Entity entity)
        {
            _repository.Update(entity);
        }
    }
}