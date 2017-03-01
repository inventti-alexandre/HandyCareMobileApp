namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cuidador")]
    public partial class Cuidador:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuidador()
        {
            Avaliacao = new HashSet<Avaliacao>();
            ContatoEmergencia = new HashSet<ContatoEmergencia>();
            CuidadorPaciente = new HashSet<CuidadorPaciente>();
            Foto = new HashSet<Foto>();
            Video = new HashSet<Video>();
        }

        [Required]
        [StringLength(36)]
        public string CuiTipoCuidador { get; set; }

        [Required]
        [StringLength(36)]
        public string CuiValidacaoCuidador { get; set; }

        [Required]
        [StringLength(70)]
        public string CuiNome { get; set; }

        [Required]
        [StringLength(100)]
        public string CuiSobrenome { get; set; }

        [Required]
        [StringLength(80)]
        public string CuiCidade { get; set; }

        [Column(TypeName = "image")]
        public byte[] CuiFoto { get; set; }

        [Required]
        [StringLength(2)]
        public string CuiEstado { get; set; }
        [StringLength(50)]
        public string CuiGoogleId { get; set; }
        [StringLength(50)]
        public string CuiFacebookId { get; set; }
        [StringLength(50)]
        public string CuiMicrosoftId { get; set; }
        [StringLength(50)]
        public string CuiMicrosoftAdId { get; set; }
        [StringLength(50)]
        public string CuiTwitterId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliacao> Avaliacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContatoEmergencia> ContatoEmergencia { get; set; }
        public string CuiContatoEmergencia { get; set; }

        public virtual TipoCuidador TipoCuidador { get; set; }

        public virtual ValidacaoCuidador ValidacaoCuidador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuidadorPaciente> CuidadorPaciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Foto> Foto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Video { get; set; }
    }
}
