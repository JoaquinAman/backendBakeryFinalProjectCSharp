using System.ComponentModel.DataAnnotations;

namespace BakeryApi.Dao.Model
{
    public class BreadDao
    {
        [Key]
        public int BreadDaoId { get; set; }
        [Required]
        public string? BreadDaoName { get; set; }
        [Required]
        public int Price { get; set; }
    }
}