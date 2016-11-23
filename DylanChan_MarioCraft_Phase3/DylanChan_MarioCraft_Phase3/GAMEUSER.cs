namespace DylanChan_MarioCraft_Phase3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.GAMEUSER")]
    public partial class GAMEUSER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GAMEUSER()
        {
            PLAYERs = new HashSet<PLAYER>();
        }

        [Key]
        public byte USERID { get; set; }

        [StringLength(20)]
        public string USEREMAIL { get; set; }

        [StringLength(20)]
        public string USERPASSWORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLAYER> PLAYERs { get; set; }
    }
}
