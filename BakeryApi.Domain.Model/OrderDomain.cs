using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BakeryApi.Domain.Model
{
    public class OrderDomain
    {
        //public OrderDomain()
        //{
        //    Breads = new List<BreadDomain>();
        //}
        public int OrderId { get; set; }


        public ICollection<OrderBreadDomain> BreadDomainList { get; set; }

        public float TotalCost { get; set; }

        public DateTime DateCreation { get; set; }

        public string Status { get; set; }

        
        //public ICollection<BreadDomain> Breads
        //{
        //    get
        //    {
        //        return BreadDomainList.Select(b => b.BreadDomain).ToList();
        //    }
        //    set
        //    {
        //        BreadDomainList = value.Select(v => new OrderBreadDomain()
        //        {
        //            BreadDomain = v
        //        }).ToList();
        //    }
        //} 
    }
}
