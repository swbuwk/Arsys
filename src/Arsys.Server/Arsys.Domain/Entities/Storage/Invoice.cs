using Arsys.Domain.Entities.Common;

namespace Arsys.Domain.Entities.Storage
{
    public class Invoice
    {
        public Guid Id { get; set; }
        
        public Guid EmployeeId { get; set; }
        
        public short Number { get; set; }
        
        public decimal TotalPrice { get; set; }
        
        public DateTime CreateAt { get; set; }                       
                       
        public IEnumerable<Product> Products { get; set; }
        public Employee ResponsibleEmployee { get; set; }
    }

    
}
