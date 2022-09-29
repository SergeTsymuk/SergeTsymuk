
using System.Data.Entity;

namespace MVC_DataBase.DATA
{
    public class EmployeeContext : DbContext, IEmployeeContext
    {
        public EmployeeContext() : base("Data Source=DESKTOP-890Q20G;Initial Catalog=AdventureWorksLT2019;Integrated Security=True")
        { }

        public DbSet<Employee> Employee { get; set; }
        public static EmployeeContext Create()
        {
            return new EmployeeContext();
        }

        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        public virtual void SetAdded(object entity)
        {
            Entry(entity).State = EntityState.Added;
        }

        public void SetDeleted(object entity)
        {
            Entry(entity).State = EntityState.Deleted;
        }

        public void SetValue(object currentValue, object newValue)
        {
            Entry(currentValue).CurrentValues.SetValues(newValue);
        }

        public virtual int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
