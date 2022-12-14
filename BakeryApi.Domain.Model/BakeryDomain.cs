using System.ComponentModel.DataAnnotations;

namespace BakeryApi.Domain.Model
{
    public class BakeryDomain
    {
        public int BakeryId { get; set; }

        public string? BakeryName { get; set; }
        public List<OrderDomain>? OrderList { get; set; }
        
        public int MaxBreads { get; set; }
    }
}