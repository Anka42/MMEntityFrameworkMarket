using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEntityFrameworkMarket
{
    public class OrderDal
    {
        public List<Order> Listeleme()
        {
            using (EMarketContext context = new EMarketContext())
            {
                return context.Orders.ToList();
            }
        }
        public void Ekle(Order order) //Model Binding
        {
            using (EMarketContext context = new EMarketContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void Sil(Order order)
        {
            using (EMarketContext context = new EMarketContext())
            {
                var entity = context.Entry(order);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Guncelle(Order order)
        {
            using (EMarketContext context = new EMarketContext())
            {
                var entity = context.Entry(order);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
