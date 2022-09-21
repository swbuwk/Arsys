using Arsys.Domain.Entities.Common;

namespace Arsys.Domain.Entities.Storage
{
    public class Supply
    {
        public Guid Id { get; set; }
        //public Guid EmployeeId { get; set; } do it identity
        public DateTime SupplyDate { get; set; }
        public bool IsComplete { get; set; }
        
        public IEnumerable<Product> Products { get; set; }
        //public Employee ResponsibleEmployee { get; set; }
    }
}
