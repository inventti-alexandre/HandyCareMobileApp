namespace HandyCareCuidador.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medicamento")]
    public partial class Medicamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicamento()
        {
            MedicamentoAdministrado = new HashSet<MedicamentoAdministrado>();
        }

        public int MedQuantidade { get; set; }

        public string MedApresentacao { get; set; }

        public string MedViaAdministracao { get; set; }

        public string MedDescricao { get; set; }

        public virtual FormaApresentacaoMedicamento FormaApresentacaoMedicamento { get; set; }

        public virtual ViaAdministracaoMedicamento ViaAdministracaoMedicamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicamentoAdministrado> MedicamentoAdministrado { get; set; }
    }
}
