namespace MVC_DataBase.DATA
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        void CreateNewEmployee(Employee domain);

        void EditEmployee(Employee employee);

        void DeleteEmployee(Employee employee);
    }
}
