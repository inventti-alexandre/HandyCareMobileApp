namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubtipoFormaAdministracaoMedicamento")]
    public partial class SubtipoFormaAdministracaoMedicamento:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubtipoFormaAdministracaoMedicamento()
        {
            FormaApresentacaoMedicamento = new HashSet<FormaApresentacaoMedicamento>();
        }

        [Column("SubtipoFormaAdministracaoMedicamento")]
        [Required]
        [StringLength(50)]
        public string SubtipoFormaAdministracaoMedicamento1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormaApresentacaoMedicamento> FormaApresentacaoMedicamento { get; set; }
    }
}
