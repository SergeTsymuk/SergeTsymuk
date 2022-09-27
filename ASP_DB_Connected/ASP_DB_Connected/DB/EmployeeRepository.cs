using ASP_DB_Connected.Data;
using System;

namespace ASP_DB_Connected
{
    internal class EmployeeRepository
    {
        private EmployeeContext employeeContext;

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        internal void CreateNewEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}