using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MMEntityFrameworkMarket
{
   public class GetOrderDal 
    {
        public void Ekle(GetOrder getOrder) //Model Binding
        {
            using (EMarketContext context = new EMarketContext())
            {
                context.GetOrders.Add(getOrder);
                context.SaveChanges();
            }
        }

        public List<GetOrder> Listeleme()
        {
            using (EMarketContext context = new EMarketContext())
            {
                return context.GetOrders.ToList();
            }
        }

        public void Sil(GetOrder getOrder)
        {
            using (EMarketContext context = new EMarketContext())
            {
                var entity = context.Entry(getOrder);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
