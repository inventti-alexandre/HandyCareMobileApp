namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViaAdministracaoMedicamento")]
    public partial class ViaAdministracaoMedicamento:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ViaAdministracaoMedicamento()
        {
            Medicamento = new HashSet<Medicamento>();
        }

        [Required]
        [StringLength(50)]
        public string ViaAdministracao { get; set; }

        [Required]
        [StringLength(36)]
        public string ViaSubtipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicamento> Medicamento { get; set; }

        public virtual SubtipoViaAdministracaoMedicamento SubtipoViaAdministracaoMedicamento { get; set; }
    }
}
