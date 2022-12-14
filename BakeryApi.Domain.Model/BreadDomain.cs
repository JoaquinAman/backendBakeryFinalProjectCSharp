
namespace BakeryApi.Domain.Model
{
    public class BreadDomain
    {
        public int BreadDomainId { get; set; }

        public string? BreadDomainName { get; set; }

        public int Price { get; set; }

        public ICollection<OrderBreadDomain> BreadDomainList { get; set; }
    }
}
