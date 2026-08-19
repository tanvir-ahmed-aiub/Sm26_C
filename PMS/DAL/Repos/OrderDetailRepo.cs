using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class OrderDetailRepo
    {
        PmsSm26CContext db;
        public OrderDetailRepo(PmsSm26CContext db)
        {
            this.db = db;
        }
        public List<OrderDetail> Get()
        {
            return db.OrderDetails.ToList();
        }
        public OrderDetail Get(int id)
        {
            return db.OrderDetails.Find(id);
        }
        public bool Create(OrderDetail OrderDetail)
        {
            db.OrderDetails.Add(OrderDetail);
            return db.SaveChanges() > 0;
        }
        public bool Update(OrderDetail OrderDetail)
        {
            var ex = Get(OrderDetail.Id);
            //ex.Name = OrderDetail.Name;

            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.OrderDetails.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
