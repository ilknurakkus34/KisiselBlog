using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public  class Yetki
    {
        [Key]
        public int yetkiID { get; set; }

        public string yetki { get; set; }
    }
}

