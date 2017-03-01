namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormaApresentacaoMedicamento")]
    public partial class FormaApresentacaoMedicamento:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormaApresentacaoMedicamento()
        {
            Medicamento = new HashSet<Medicamento>();
        }

        [Required]
        [StringLength(36)]
        public string ForSubtipo { get; set; }

        [Required]
        [StringLength(50)]
        public string FormaApresentacao { get; set; }

        public virtual SubtipoFormaAdministracaoMedicamento SubtipoFormaAdministracaoMedicamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicamento> Medicamento { get; set; }
    }
}
