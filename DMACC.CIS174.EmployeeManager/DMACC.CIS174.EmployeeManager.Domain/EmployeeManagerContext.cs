using System.Data.Entity;

namespace DMACC.CIS174.EmployeeManager.Domain
{
    public class EmployeeManagerContext : DbContext
    {
        public EmployeeManagerContext()
            : base()
        { }

        // Reference your DbSets here
        // Example: public DbSet<Employee> Employees { get; set; }
    }
}
