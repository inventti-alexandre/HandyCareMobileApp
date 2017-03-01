namespace HandyCareCuidador.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicamentoAdministrado")]
    public partial class MedicamentoAdministrado
    {
        [Column(Order = 0)]
        public string MedAfazer { get; set; }

        [Column(Order = 1)]
        public string MedAdministrado { get; set; }

        public int MemQuantidadeAdministrada { get; set; }

        public virtual Afazer Afazer { get; set; }

        public virtual Medicamento Medicamento { get; set; }
    }
}
