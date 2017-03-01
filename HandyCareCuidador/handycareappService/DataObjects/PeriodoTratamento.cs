namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PeriodoTratamento")]
    public partial class PeriodoTratamento:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PeriodoTratamento()
        {
            CuidadorPaciente = new HashSet<CuidadorPaciente>();
        }

        [Column(TypeName = "date")]
        public DateTime PerInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PerTermino { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuidadorPaciente> CuidadorPaciente { get; set; }
    }
}
