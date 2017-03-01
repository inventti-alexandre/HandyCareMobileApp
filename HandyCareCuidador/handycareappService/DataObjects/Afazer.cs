namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Afazer")]
    public partial class Afazer:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Afazer()
        {
            ConclusaoAfazer = new HashSet<ConclusaoAfazer>();
            MaterialUtilizado = new HashSet<MaterialUtilizado>();
            MedicamentoAdministrado = new HashSet<MedicamentoAdministrado>();
        }

        //[StringLength(36)]
        //public string Id { get; set; }

        public DateTime AfaHorarioPrevisto { get; set; }

        [Required]
        [StringLength(100)]
        public string AfaObservacao { get; set; }
        public string AfaTitulo { get; set; }
        public bool AfaRecorrente { get; set; }
        public string AfaPaciente { get; set; }
        public DateTime AfaHorarioPrevistoTermino { get; set; }
        public string AfaCor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConclusaoAfazer> ConclusaoAfazer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialUtilizado> MaterialUtilizado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicamentoAdministrado> MedicamentoAdministrado { get; set; }
    }
}
