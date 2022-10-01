using Microsoft.EntityFrameworkCore;

namespace Employee.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {

        }

        public DbSet<Employee.Models.MEmployee> MEmployee { get; set; }
    }
}
