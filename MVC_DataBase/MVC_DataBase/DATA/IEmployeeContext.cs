using System.Data.Entity;

namespace MVC_DataBase.DATA
{
    public interface IEmployeeContext
    {
        DbSet<Employee> Employee { get; set; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        void SetModified(object entity);
        void SetAdded(object entity);
        void SetDeleted(object entity);
        void SetValue(object currentValue, object newValue);
        int SaveChanges();
    }
}
