namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            MaterialUtilizado = new HashSet<MaterialUtilizado>();
        }

        [Required]
        [StringLength(50)]
        public string MatDescricao { get; set; }

        public float MatQuantidade { get; set; }
        public string MatPacId { get; set; }
        public string MatUnidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialUtilizado> MaterialUtilizado { get; set; }

    }
}
