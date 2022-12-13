
using System.ComponentModel.DataAnnotations;

namespace BakeryApi.Dao.Model
{
    public class BakeryDao
    {
        [Key]
        public int BakeryId { get; set; }
        [Required]
        public string? BakeryName { get; set; }
        
        public List<OrderDao>? OrderList { get; set; }
        [Required]
        public int MaxBreads { get; set; }
    }
}
