namespace HandyCareCuidador.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuidadorPaciente")]
    public partial class CuidadorPaciente
    {
        [Column(Order = 0)]
        public string CuiId { get; set; }

        [Column(Order = 1)]
        public string PacId { get; set; }

        [Column(Order = 2)]
        public string CuiPeriodoTratamento { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        [Column(TypeName = "timestamp")]
        public byte[] Version { get; set; }

        public bool? Deleted { get; set; }
        public virtual Cuidador Cuidador { get; set; }

        public virtual Paciente Paciente { get; set; }
   
        public virtual PeriodoTratamento PeriodoTratamento { get; set; }
    }
}
