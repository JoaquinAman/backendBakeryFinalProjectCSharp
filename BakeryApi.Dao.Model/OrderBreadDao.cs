
using System.ComponentModel.DataAnnotations;

namespace BakeryApi.Dao.Model
{
    public class OrderBreadDao
    {
        [Key]
        public int OrderBreadId { get; set; }
        [Required]
        public int OrderDaoId { get; set; }
        [Required]
        public int BreadDaoId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public OrderDao OrderDao { get; set; }
        [Required]
        public BreadDao BreadDao { get; set;}
    }
}
