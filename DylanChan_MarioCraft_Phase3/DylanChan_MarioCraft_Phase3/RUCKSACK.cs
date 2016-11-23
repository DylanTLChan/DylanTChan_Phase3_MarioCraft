namespace DylanChan_MarioCraft_Phase3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.RUCKSACK")]
    public partial class RUCKSACK
    {
        [Key]
        public byte ITEMID { get; set; }

        public byte? MATERIALID { get; set; }

        [StringLength(10)]
        public string ITEMDESC { get; set; }

        public byte? ITEMQTY { get; set; }

        public byte? TOOLID { get; set; }

        public byte? TOOLSTRENGTH { get; set; }

        public byte? TOOLHEALTH { get; set; }

        public virtual MATERIAL MATERIAL { get; set; }

        public virtual TOOL TOOL { get; set; }
    }
}
