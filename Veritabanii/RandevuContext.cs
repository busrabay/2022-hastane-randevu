using Siniflarim;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritabanii
{
        public  class RandevuContext:DbContext
    {
        

        public DbSet<Randevu> Randevu { get; set; }

        public DbSet<User> user { get; set; }


    }
}
