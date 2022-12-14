using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BakeryApi.Dao.Model
{
    public class OrderDao
    {
        public OrderDao() 
        {
            Breads = new List<BreadDao>();
        }
        [Key]
        public int OrderId { get; set; }
      
        [Required]
        [JsonIgnore]
        public ICollection<OrderBreadDao> BreadDaoList { get; set; }
        [Required]
        public float TotalCost { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
        [Required]
        public string Status { get; set; }

        [NotMapped]

        public ICollection<BreadDao> Breads
        {
            get
            {
                return BreadDaoList.Select(b => b.BreadDao).ToList();
            }
            set
            {
                BreadDaoList = value.Select(v => new OrderBreadDao()
                {
                    BreadDao = v
                }).ToList();
            }
        }

    }
}
