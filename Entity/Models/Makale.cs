namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Makale
    {
        public int MakaleID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public int? KategoriID { get; set; }

        [DisplayName("Makale Eklenme Tarihi")]
        public DateTime EklenmeTarihi { get; set; }
        public Makale()
        {
            EklenmeTarihi = DateTime.Now;
        }

        public virtual Kategori Kategori { get; set; }

        public int? TotalRate { get; set; }
    }
}
