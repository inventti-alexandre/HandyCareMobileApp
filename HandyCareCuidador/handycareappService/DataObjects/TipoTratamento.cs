namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoTratamento")]
    public partial class TipoTratamento:EntityData
    {

        [Required]
        [StringLength(150)]
        public string TipDescricao { get; set; }

        [Required]
        [StringLength(36)]
        public string TipCuidado { get; set; }

        public virtual MotivoCuidado MotivoCuidado { get; set; }
    }
}
