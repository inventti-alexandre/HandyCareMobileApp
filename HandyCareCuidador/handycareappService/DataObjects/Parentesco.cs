namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Parentesco")]
    public partial class Parentesco:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parentesco()
        {
            Familiar = new HashSet<Familiar>();
        }

        [Required]
        [StringLength(50)]
        public string ParDescricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Familiar> Familiar { get; set; }
    }
}
