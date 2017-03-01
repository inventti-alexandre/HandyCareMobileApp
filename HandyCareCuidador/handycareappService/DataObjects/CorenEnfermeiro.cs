namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CorenEnfermeiro")]
    public partial class CorenEnfermeiro:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CorenEnfermeiro()
        {
            ValidacaoCuidador = new HashSet<ValidacaoCuidador>();
        }

        [Required]
        [StringLength(20)]
        public string CorenIdentificacao { get; set; }

        public bool CorenValidado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValidacaoCuidador> ValidacaoCuidador { get; set; }
    }
}
