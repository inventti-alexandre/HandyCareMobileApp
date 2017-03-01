namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Familiar")]
    public partial class Familiar:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Familiar()
        {
            FotoFamiliar = new HashSet<FotoFamiliar>();
            VideoFamiliar = new HashSet<VideoFamiliar>();
            Camera = new HashSet<Camera>();
            PacienteFamiliar = new HashSet<PacienteFamiliar>();
        }

        [Required]
        [StringLength(36)]
        public string FamParentesco { get; set; }

        [Required]
        [StringLength(36)]
        public string FamContatoEmergencia { get; set; }

        [Required]
        [StringLength(50)]
        public string FamNome { get; set; }
        [StringLength(80)]
        public string FamCidade { get; set; }
        [StringLength(2)]
        public string FamEstado { get; set; }

        [Required]
        [StringLength(100)]
        public string FamSobrenome { get; set; }
        [StringLength(50)]
        public string FamGoogleId { get; set; }
        [StringLength(50)]
        public string FamFacebookId { get; set; }
        [StringLength(50)]
        public string FamMicrosoftId { get; set; }
        [StringLength(50)]
        public string FamMicrosoftAdId { get; set; }
        [StringLength(50)]
        public string FamTwitterId { get; set; }
        public string FamInstallationId { get; set; }
        public string FamRegistrationId { get; set; }

        [Column(TypeName = "image")]
        public byte[] FamFoto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliacao> Avaliacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FotoFamiliar> FotoFamiliar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoFamiliar> VideoFamiliar { get; set; }
        public virtual ICollection<Camera> Camera { get; set; }
        public virtual Parentesco Parentesco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PacienteFamiliar> PacienteFamiliar { get; set; }

    }
}
