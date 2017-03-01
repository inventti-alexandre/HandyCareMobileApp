namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paciente")]
    public partial class Paciente:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            CuidadorPaciente = new HashSet<CuidadorPaciente>();
            PacienteFamiliar = new HashSet<PacienteFamiliar>();
        }

        [Required]
        [StringLength(50)]
        public string PacNome { get; set; }

        [Required]
        [StringLength(100)]
        public string PacSobrenome { get; set; }
        [Required]
        public float PacPeso { get; set; }
        [Required]
        public float PacAltura { get; set; }
        [Required]
        [StringLength(10)]
        public string PacTipoSanguineo { get; set; }
        [Column(TypeName = "date")]
        public DateTime PacIdade { get; set; }

        [Required]
        [StringLength(36)]
        public string PacMotivoCuidado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuidadorPaciente> CuidadorPaciente { get; set; }

        public virtual MotivoCuidado MotivoCuidado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PacienteFamiliar> PacienteFamiliar { get; set; }
    }
}
