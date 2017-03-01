namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medicamento")]
    public partial class Medicamento:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicamento()
        {
            MedicamentoAdministrado = new HashSet<MedicamentoAdministrado>();
        }

        public float MedQuantidade { get; set; }

        [Required]
        [StringLength(36)]
        public string MedApresentacao { get; set; }

        [Required]
        [StringLength(36)]
        public string MedViaAdministracao { get; set; }

        [Required]
        [StringLength(50)]
        public string MedDescricao { get; set; }
        [Column(TypeName = "image")]
        public  byte[] MedFoto { get; set; }
        [Required]
        public string MedPacId { get; set; }
        public string MedUnidade { get; set; }

        public virtual FormaApresentacaoMedicamento FormaApresentacaoMedicamento { get; set; }

        public virtual ViaAdministracaoMedicamento ViaAdministracaoMedicamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicamentoAdministrado> MedicamentoAdministrado { get; set; }
    }
}
