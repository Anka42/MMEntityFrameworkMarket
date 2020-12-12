using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEntityFrameworkMarket
{
    public class ProductDal
    {
        public List<Product> Listeleme()
        {
            using (EMarketContext context = new EMarketContext())
            {
                return context.Products.ToList();
            }
        }
        public void Ekle(Product product) //Model Binding
        {
            using (EMarketContext context = new EMarketContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Guncelle(Product product) //Model Binding
        {
            using (EMarketContext context = new EMarketContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
