using Microsoft.Azure.Mobile.Server;

namespace handycareappService.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Camera")]
    public partial class Camera:EntityData
    {
        [Required]
        [StringLength(36)]
        public string CamFamiliar { get; set; }

        [StringLength(50)]
        public string CamIPv4 { get; set; }
        public string CamDescricao { get; set; }

        [StringLength(50)]
        public string CamIPv6 { get; set; }
        public virtual Familiar Familiar { get; set; }

    }
}
