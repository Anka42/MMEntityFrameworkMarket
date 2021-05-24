using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
