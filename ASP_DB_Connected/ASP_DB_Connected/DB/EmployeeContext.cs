using System.Data.Entity;

namespace ASP_DB_Connected.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("Data Source=DESKTOP-890Q20G;Initial Catalog=AdventureWorksLT2019;Integrated Security=True")
        { }

    }
}
