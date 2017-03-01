using Newtonsoft.Json;

namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContatoEmergencia")]
    public partial class ContatoEmergencia:EntityData
    {
        [Required]
        [StringLength(36)]
        public string ConTelefone { get; set; }

        [Required]
        [StringLength(36)]
        public string ConCelular { get; set; }

        [Required]
        [StringLength(36)]
        public string ConEmail { get; set; }

        public string ConDescricao { get; set; }

        [StringLength(36)]
        public string ConTipo { get; set; }

        [StringLength(36)]
        public string ConPessoa { get; set; }
        public virtual ConCelular ConNumCelular { get; set; }

        public virtual ConEmail ConEnderecoEmail { get; set; }

        public virtual ConTelefone ConNumTelefone { get; set; }

        public virtual Cuidador Cuidador { get; set; }

        //public virtual Familiar Familiar { get; set; }

        public virtual TipoContato TipoContato { get; set; }
    }
}
