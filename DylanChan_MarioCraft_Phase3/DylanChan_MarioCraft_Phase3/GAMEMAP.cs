namespace DylanChan_MarioCraft_Phase3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.GAMEMAP")]
    public partial class GAMEMAP
    {
        [Key]
        public decimal COORDINATESXY { get; set; }

        public byte? MATERIALID { get; set; }

        [StringLength(1)]
        public string BLOCKSTATUS { get; set; }

        [StringLength(10)]
        public string BLOCKTYPE { get; set; }

        public virtual MATERIAL MATERIAL { get; set; }

        public virtual MATERIAL MATERIAL1 { get; set; }
    }
}
