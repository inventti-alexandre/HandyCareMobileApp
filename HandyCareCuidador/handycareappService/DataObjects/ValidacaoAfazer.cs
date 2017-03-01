namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValidacaoAfazer")]
    public partial class ValidacaoAfazer:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValidacaoAfazer()
        {
            MotivoNaoValidacaoConclusaoAfazer = new HashSet<MotivoNaoValidacaoConclusaoAfazer>();
        }

        //[StringLength(36)]
        //public string Id { get; set; }

        [Required]
        [StringLength(36)]
        public string ValFamId { get; set; }

        [Required]
        [StringLength(36)]
        public string ValAfazer { get; set; }

        public bool ValValidado { get; set; }

        public virtual ConclusaoAfazer ConclusaoAfazer { get; set; }

        //public virtual Familiar Familiar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MotivoNaoValidacaoConclusaoAfazer> MotivoNaoValidacaoConclusaoAfazer { get; set; }
    }
}
