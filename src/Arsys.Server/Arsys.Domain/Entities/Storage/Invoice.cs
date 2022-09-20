using Arsys.Domain.Entities.Common;

namespace Arsys.Domain.Entities.Storage
{
    public class Invoice
    {
        public int Id { get; set; }
        
        public int EmployeeId { get; set; }
        
        public short Number { get; set; }
        
        public decimal TotalPrice { get; set; }
        
        public DateTime CreateAt { get; set; }                       
                       
        public IEnumerable<Product> Products { get; set; }
        public Employee ResponsibleEmployee { get; set; }
    }

    
}
