using System.Collections.Generic;

namespace ASP_DB_Connected
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IEmployeeContext _context;
        public Repository(IEmployeeContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public virtual TEntity GetById<T>(T id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.SetModified(entity);
        }

        public void Add<T>(T entity)
        {
            _context.SetAdded(entity);
        }

        public void Delete<T>(T entity)
        {
            _context.SetDeleted(entity);
        }
    }

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
