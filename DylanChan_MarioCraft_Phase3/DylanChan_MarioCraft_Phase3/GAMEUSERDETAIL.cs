namespace DylanChan_MarioCraft_Phase3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.GAMEUSERDETAILS")]
    public partial class GAMEUSERDETAIL
    {
        [Key]
        public byte USERID { get; set; }

        [StringLength(20)]
        public string USEREMAIL { get; set; }
    }
}
