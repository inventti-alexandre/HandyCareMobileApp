namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoCuidado")]
    public partial class MotivoCuidado:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MotivoCuidado()
        {
            Paciente = new HashSet<Paciente>();
            TipoTratamento = new HashSet<TipoTratamento>();
        }

        [Required]
        [StringLength(150)]
        public string MotDescricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente> Paciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoTratamento> TipoTratamento { get; set; }
    }
}
