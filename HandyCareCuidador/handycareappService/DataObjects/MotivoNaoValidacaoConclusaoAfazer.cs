namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoNaoValidacaoConclusaoAfazer")]
    public partial class MotivoNaoValidacaoConclusaoAfazer:EntityData
    { 
        [Required]
        [StringLength(150)]
        public string MoDescricao { get; set; }

        [Required]
        [StringLength(36)]
        public string MoValidacao { get; set; }

        public virtual ValidacaoAfazer ValidacaoAfazer { get; set; }
    }
}
