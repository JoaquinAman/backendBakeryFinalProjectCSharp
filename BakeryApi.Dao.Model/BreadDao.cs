using System.ComponentModel.DataAnnotations;

namespace BakeryApi.Dao.Model
{
    public class BreadDao
    {
        [Key]
        public int BreadDaoId { get; set; }
        
        public string? BreadDaoName { get; set; }
        
        public int Price { get; set; }
        
        public ICollection<OrderBreadDao> BreadDaoList { get; set; }
    }
}
