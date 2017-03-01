namespace HandyCareCuidador.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConclusaoAfazer")]
    public partial class ConclusaoAfazer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConclusaoAfazer()
        {
            MotivoNaoConclusaoTarefa = new HashSet<MotivoNaoConclusaoTarefa>();
            ValidacaoAfazer = new HashSet<ValidacaoAfazer>();
        }


        public DateTime ConHorarioConcluido { get; set; }

        public bool ConConcluido { get; set; }
        public string ConAfazer { get; set; }

        public virtual Afazer Afazer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MotivoNaoConclusaoTarefa> MotivoNaoConclusaoTarefa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValidacaoAfazer> ValidacaoAfazer { get; set; }
    }
}
