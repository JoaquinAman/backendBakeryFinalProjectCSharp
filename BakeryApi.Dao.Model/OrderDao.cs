using System.ComponentModel.DataAnnotations;

namespace BakeryApi.Dao.Model
{
    public class OrderDao
    {
        [Key]
        public int OrderId { get; set; }
      
        [Required]
        public ICollection<OrderBreadDao> BreadDaoList { get; set; }
        [Required]
        public float TotalCost { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
