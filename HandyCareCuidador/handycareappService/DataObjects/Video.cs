namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Video")]
    public partial class Video:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Video()
        {
            VideoFamiliar = new HashSet<VideoFamiliar>();
        }


        [Required]
        public byte[] VidDados { get; set; }

        [Required]
        [StringLength(100)]
        public string VidDescricao { get; set; }

        [Required]
        [StringLength(36)]
        public string VidCuidador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoFamiliar> VideoFamiliar { get; set; }
        public virtual Cuidador Cuidador { get; set; }
    }
}
