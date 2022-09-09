using System.Collections.Generic;

namespace MVC_DataBase.DATA
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById<T>(T id);
        int SaveChanges();
        void Update(TEntity entity);
        void Add<T>(T entity);
        void Delete<T>(T entity);
    }
}
