namespace HandyCareCuidador.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialUtilizado")]
    public partial class MaterialUtilizado
    {
        [Column(Order = 0)]
        public string MatAfazer { get; set; }

        [Column(Order = 1)]
        public string MatUtilizado { get; set; }

        public int MatQuantidadeUtilizada { get; set; }

        public virtual Afazer Afazer { get; set; }

        public virtual Material Material { get; set; }
    }
}
