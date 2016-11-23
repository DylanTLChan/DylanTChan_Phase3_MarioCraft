namespace DylanChan_MarioCraft_Phase3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.TOOL")]
    public partial class TOOL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOOL()
        {
            RUCKSACKs = new HashSet<RUCKSACK>();
        }

        public byte TOOLID { get; set; }

        [StringLength(8)]
        public string TOOLNAME { get; set; }

        public byte? TOOLSTRENGTH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUCKSACK> RUCKSACKs { get; set; }
    }
}
