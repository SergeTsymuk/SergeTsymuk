namespace MVC_DataBase.DATA
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        new void Add(Employee employee);

        new void Update(Employee employee);

        new void Delete(Employee employee);
    }
}
