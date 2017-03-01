using Microsoft.Azure.Mobile.Server;

namespace handycareappService.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuidadorPaciente")]
    public partial class CuidadorPaciente:EntityData
    {
        [StringLength(36)]
        public string CuiId { get; set; }

        [StringLength(36)]
        public string PacId { get; set; }

        [StringLength(36)]
        public string CuiPeriodoTratamento { get; set; }

        public virtual Cuidador Cuidador { get; set; }

        public virtual Paciente Paciente { get; set; }
   
        public virtual PeriodoTratamento PeriodoTratamento { get; set; }
    }
}
