namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConEmail")]
    public partial class ConEmail:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConEmail()
        {
            ContatoEmergencia = new HashSet<ContatoEmergencia>();
        }

        [Column("ConEnderecoEmail")]
        [Required]
        [StringLength(80)]
        public string ConEnderecoEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContatoEmergencia> ContatoEmergencia { get; set; }
    }
}
