namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Kullanici
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullaniciID { get; set; }

        [Required]
        public string KullaniciAdSoyad { get; set; }

        public int sifre { get; set; }

        [Required]
        public string email { get; set; }

        [ForeignKey("yetki")]
        public int? yetkiID { get; set; }
        public virtual Yetki yetki { get; set; }
    }
}
