using Siniflarim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritabanii
{
         public class Useroperation
    {

        public void Add(Randevu Randevu)
        {
            using (RandevuContext ctx = new RandevuContext())
            {
                ctx.Randevu.Add(Randevu);
                ctx.SaveChanges();
               
            }
        }

        public void Add (User user)
        {
            using (RandevuContext rtv = new RandevuContext())
            {
                rtv.user.Add(user);
                rtv.SaveChanges();
            }
        }

        public void Update (User user)
        {
            RandevuContext context = new RandevuContext();
            {
                var entity = context.Entry(user);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }

        }

        public void Delete(User user)
        {
            RandevuContext context = new RandevuContext();
            {
                var entity = context.Entry(user);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }




        }
    }
}
