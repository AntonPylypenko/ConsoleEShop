using System.Collections.Generic;

namespace BusinessLogicLayer.Interfaces
{
    interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> GetAllEntities();
        TEntity GetById(int id);
    }
}
