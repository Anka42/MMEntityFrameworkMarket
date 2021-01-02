using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEntityFrameworkMarket
{
    public class UserDal
    {
        public void Ekle(User user)
        {
            using (EMarketContext context = new EMarketContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
