using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class OrderService
    {
        OrderRepo orepo;
        OrderDetailRepo odrepo;
        IMapper mapper;
        public OrderService(OrderRepo orepo, OrderDetailRepo odrepo, IMapper mapper) { 
            this.orepo = orepo;
            this.odrepo = odrepo;
            this.mapper = mapper;
        }

        public bool PlaceOrder(OrderPlaceModel model) {
            var order = new Order()
            {
               CusId = model.CusId,
               Status ="Ordered",
               Time = DateTime.Now,
               Total=0
            };
            orepo.Create(order);

            foreach (var item in model.Products) {
                var odetail = new OrderDetail()
                {
                    Pid = item.Id,
                    Qty = item.Qty,
                    Price = item.Price,
                    Oid = order.Id
                };
                order.Total += item.Price * item.Qty;
                odrepo.Create(odetail);
            }
            return true;
        }
       
    }
}
