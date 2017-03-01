using Microsoft.Azure.Mobile.Server;

namespace handycareappService.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VideoFamiliar")]
    public partial class VideoFamiliar:EntityData
    {
        [StringLength(36)]
        public string FamId { get; set; }

        [StringLength(36)]
        public string VidId { get; set; }

        public virtual Video Video { get; set; }
        public virtual Familiar Familiar { get; set; }
    }
}
