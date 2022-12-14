
using System.ComponentModel.DataAnnotations;

namespace BakeryApi.Dao.Model
{
    public class OrderBreadDao
    {
        [Key]
        public int OrderBreadId { get; set; }
        
        public int OrderDaoId { get; set; }
        
        public int BreadDaoId { get; set; }
        
        public int Quantity { get; set; }
        
        public OrderDao OrderDao { get; set; }
        
        public BreadDao BreadDao { get; set;}
    }
}
