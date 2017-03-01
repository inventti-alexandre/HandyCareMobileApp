using Microsoft.Azure.Mobile.Server;

namespace handycareappService.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Foto")]
    public partial class Foto:EntityData
    {
        [Required]
        public byte[] FotoDados { get; set; }

        [Required]
        [StringLength(100)]
        public string FotoDescricao { get; set; }

        [Required]
        [StringLength(36)]
        public string FotCuidador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FotoFamiliar> FotoFamiliar { get; set; }
        public virtual Cuidador Cuidador { get; set; }
    }
}
