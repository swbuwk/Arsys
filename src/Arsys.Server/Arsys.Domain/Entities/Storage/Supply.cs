using Arsys.Domain.Entities.Common;

namespace Arsys.Domain.Entities.Storage
{
    public class Supply
    {
        public int Id { get; set; }
        public DateTime SupplyDate { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
