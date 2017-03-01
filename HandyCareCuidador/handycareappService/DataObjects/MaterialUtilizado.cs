namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialUtilizado")]
    public partial class MaterialUtilizado:EntityData
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string MatAfazer { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string MatUtilizado { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(36)]
        public new string Id { get; set; }

        public int MatQuantidadeUtilizada { get; set; }

        public virtual Material Material { get; set; }
        public virtual Afazer Afazer { get; set; }
    }
}
