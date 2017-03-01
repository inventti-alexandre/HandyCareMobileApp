using Microsoft.Azure.Mobile.Server;

namespace handycareappService.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PacienteFamiliar")]
    public partial class PacienteFamiliar:EntityData
    {
        [StringLength(36)]
        public string PacId { get; set; }

        [StringLength(36)]
        public string FamId { get; set; }
        public virtual Familiar Familiar { get; set; }

        public virtual Paciente Paciente { get; set; }


    }
}
