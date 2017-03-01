namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Avaliacao")]
    public partial class Avaliacao:EntityData
    {

        [Required]
        [StringLength(36)]
        public string AvaCuidador { get; set; }

        [Required]
        [StringLength(36)]
        public string AvaFamiliar { get; set; }

        public double AvaPontuacao { get; set; }

        [Required]
        public string AvaDescricao { get; set; }

        public virtual Cuidador Cuidador { get; set; }

        public virtual Familiar Familiar { get; set; }
    }
}
