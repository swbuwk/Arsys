using Arsys.Domain.Entities.Common.Enums;

namespace Arsys.Domain.Entities.Common
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeRole EmployeeRole { get; set; }
    }
}
