
using BakeryApi.Dao.Model;
using BakeryApi.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BakeryApi.Dao.Service.Utils
{
    public static class Parser
    {
        
        //public static OrderDao toOrderDao(OrderDomain orderDomain)
        //{
        //    ICollection<BreadDao> list = new List<BreadDao>();

        //    foreach(var item in orderDomain.BreadDomainList)
        //    {
        //        list.Add(new BreadDao
        //        {
        //            BreadDaoId=item.BreadDomainId,
        //            Price=item.BreadDomain.Price,
        //            BreadDaoName=item.BreadDomain.BreadDomainName,
        //        });
        //    }
            
        //    return new OrderDao
        //    {
        //        OrderId = orderDomain.OrderId,
        //        TotalCost = orderDomain.TotalCost,
        //        DateCreation = orderDomain.DateCreation,
        //        Status = orderDomain.Status,
        //        //Breads=orderDomain.Breads,
        //        BreadDaoList = (ICollection<OrderBreadDao>)list,
        //    };
        //}
    }
}
