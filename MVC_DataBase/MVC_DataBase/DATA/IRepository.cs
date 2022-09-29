using System.Collections.Generic;

namespace MVC_DataBase.DATA
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById<T>(T id);
        int SaveChanges();
        void Update(TEntity entity);
        void Add(TEntity entity);
        void Delete(TEntity entity);
    }
}
