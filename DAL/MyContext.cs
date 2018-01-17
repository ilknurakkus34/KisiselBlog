using Entity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class MyContext: IdentityDbContext<IdentityUser>
    {
        public static DAL.MyContext db;
        public MyContext() : base("DefaultConnection")
        {

        }

       
        public virtual DbSet<Kategori> Kategoriler{ get; set; }
        public virtual DbSet<Makale> Makaleler { get; set; }
        public virtual DbSet<Kullanici>Kullanıcılar { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }



    }

}


