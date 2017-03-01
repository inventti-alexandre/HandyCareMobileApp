namespace handycareappService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicamentoAdministrado")]
    public partial class MedicamentoAdministrado:EntityData
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string MedAfazer { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string MedAdministrado { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(36)]
        public new string Id { get; set; }

        public int MemQuantidadeAdministrada { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        public virtual Afazer Afazer { get; set; }
    }
}
