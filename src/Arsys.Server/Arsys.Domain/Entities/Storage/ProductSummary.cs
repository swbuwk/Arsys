using Arsys.Domain.Entities.Common;

namespace Arsys.Domain.Entities.Storage
{
    public class ProductSummary
    {
        public int Id { get; set; }        
        public int ProductId { get; set; }        
        
        public short Amount { get; set; }
        
        public Product Product { get; set; }
    }
}
