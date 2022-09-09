namespace MVC_DataBase.DATA
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly IEmployeeContext _context;
        public EmployeeRepository(IEmployeeContext context) : base(context)
        {
            _context = context;
        }

        public void CreateNewEmployee(Employee domain)
        {
            _context.SetAdded(domain);
            _context.SaveChanges();
        }
        public void EditEmployee(Employee employee)
        {
            _context.SetAdded(employee);
            _context.SetModified(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.SetDeleted(employee);
            _context.SaveChanges();
        }
    }

}
