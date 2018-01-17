using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Repository2
    {
       
        public class MakaleRep : Repository<Makale> { }                
        public class KategoriRep : Repository<Kategori> { }
    }
}
