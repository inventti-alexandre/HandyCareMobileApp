namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoNaoConclusaoTarefa")]
    public partial class MotivoNaoConclusaoTarefa:EntityData
    {
        [Required]
        [StringLength(100)]
        public string MoExplicacao { get; set; }

        [Required]
        [StringLength(36)]
        public string MoAfazer { get; set; }

        public virtual ConclusaoAfazer ConclusaoAfazer { get; set; }
    }
}
