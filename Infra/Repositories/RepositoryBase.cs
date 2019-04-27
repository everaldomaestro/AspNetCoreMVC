using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryBase<Entity> : IRepositoryBase<Entity> where Entity : class
    {
        protected readonly NotiLigaContext Db;

        public RepositoryBase(NotiLigaContext context)
        {
            Db = context;
        }

        public void Add(Entity entity)
        {
            Db.Set<Entity>().Add(entity);
            Db.SaveChanges();
        }

        public ICollection<Entity> GetAll()
        {
            return Db.Set<Entity>().ToList();
        }

        public Entity GetById(int id)
        {
            return Db.Set<Entity>().Find(id);
        }

        public void Remove(Entity entity)
        {
            Db.Entry(entity).State = EntityState.Deleted;
            Db.Set<Entity>().Remove(entity);
            Db.SaveChanges();
        }

        public void Update(Entity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
