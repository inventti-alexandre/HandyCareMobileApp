using Microsoft.Azure.Mobile.Server;

namespace handycareappService.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FotoFamiliar")]
    public partial class FotoFamiliar:EntityData
    {
        [StringLength(36)]
        public string FamId { get; set; }

        [StringLength(36)]
        public string FotId { get; set; }

        public virtual Familiar Familiar { get; set; }

        public virtual Foto Foto { get; set; }
    }
}
