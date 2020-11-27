using System;
using System.Collections.Generic;
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
    }
}
