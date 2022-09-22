using Arsys.Domain.Entities.Common;

namespace Arsys.Domain.Entities.Storage
{
    public class ProductSummary
    {
        public Guid Id { get; set; }        
        public Guid ProductId { get; set; }        
        
        public short Amount { get; set; }
        
        public Product Product { get; set; }
    }
}
