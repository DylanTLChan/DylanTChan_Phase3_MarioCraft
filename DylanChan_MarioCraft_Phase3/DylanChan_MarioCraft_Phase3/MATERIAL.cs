namespace DylanChan_MarioCraft_Phase3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.MATERIAL")]
    public partial class MATERIAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATERIAL()
        {
            GAMEMAPs = new HashSet<GAMEMAP>();
            RUCKSACKs = new HashSet<RUCKSACK>();
        }

        public byte MATERIALID { get; set; }

        [StringLength(7)]
        public string MATERIALTYPE { get; set; }

        public byte? MATERIALVALUE { get; set; }

        public virtual GAMEMAP GAMEMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAMEMAP> GAMEMAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUCKSACK> RUCKSACKs { get; set; }
    }
}
