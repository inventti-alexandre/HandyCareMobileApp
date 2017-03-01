namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConTelefone")]
    public partial class ConTelefone:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConTelefone()
        {
            ContatoEmergencia = new HashSet<ContatoEmergencia>();
        }

        [Column("ConNumTelefone")]
        [Required]
        [StringLength(10)]
        public string ConNumTelefone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContatoEmergencia> ContatoEmergencia { get; set; }
    }
}
