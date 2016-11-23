namespace DylanChan_MarioCraft_Phase3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PLAYER")]
    public partial class PLAYER
    {
        public byte PLAYERID { get; set; }

        public byte? USERID { get; set; }

        public byte? HEALTH { get; set; }

        public virtual GAMEUSER GAMEUSER { get; set; }
    }
}
