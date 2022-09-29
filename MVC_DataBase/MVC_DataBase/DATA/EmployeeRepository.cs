namespace MVC_DataBase.DATA
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly IEmployeeContext _context;
        public EmployeeRepository(IEmployeeContext context) : base(context)
        {
            _context = context;
        }

        public new void Add(Employee employee)
        {
            _context.SetAdded(employee);
            _context.SaveChanges();
        }
        public new void Update(Employee employee)
        {
            _context.SetAdded(employee);
            _context.SetModified(employee);
            _context.SaveChanges();
        }

        public new void Delete(Employee employee)
        {
            _context.SetDeleted(employee);
            _context.SaveChanges();
        }
    }

}
