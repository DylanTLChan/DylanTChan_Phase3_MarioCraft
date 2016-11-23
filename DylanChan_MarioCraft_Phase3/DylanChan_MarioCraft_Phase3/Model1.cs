namespace DylanChan_MarioCraft_Phase3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    //https://github.com/DylanTLChan/DylanTChan_Phase3_MarioCraft.git

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<GAMEMAP> GAMEMAPs { get; set; }
        public virtual DbSet<GAMEUSER> GAMEUSERs { get; set; }
        public virtual DbSet<MATERIAL> MATERIALs { get; set; }
        public virtual DbSet<PLAYER> PLAYERs { get; set; }
        public virtual DbSet<RUCKSACK> RUCKSACKs { get; set; }
        public virtual DbSet<TOOL> TOOLs { get; set; }
        public virtual DbSet<GAMEUSERDETAIL> GAMEUSERDETAILS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GAMEMAP>()
                .Property(e => e.COORDINATESXY)
                .HasPrecision(2, 2);

            modelBuilder.Entity<GAMEMAP>()
                .Property(e => e.BLOCKSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GAMEMAP>()
                .Property(e => e.BLOCKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GAMEMAP>()
                .HasOptional(e => e.MATERIAL)
                .WithRequired(e => e.GAMEMAP);

            modelBuilder.Entity<GAMEUSER>()
                .Property(e => e.USEREMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<GAMEUSER>()
                .Property(e => e.USERPASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<GAMEUSER>()
                .HasMany(e => e.PLAYERs)
                .WithOptional(e => e.GAMEUSER)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MATERIAL>()
                .Property(e => e.MATERIALTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MATERIAL>()
                .HasMany(e => e.GAMEMAPs)
                .WithOptional(e => e.MATERIAL1)
                .HasForeignKey(e => e.MATERIALID);

            modelBuilder.Entity<MATERIAL>()
                .HasMany(e => e.RUCKSACKs)
                .WithOptional(e => e.MATERIAL)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RUCKSACK>()
                .Property(e => e.ITEMDESC)
                .IsUnicode(false);

            modelBuilder.Entity<TOOL>()
                .Property(e => e.TOOLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TOOL>()
                .HasMany(e => e.RUCKSACKs)
                .WithOptional(e => e.TOOL)
                .WillCascadeOnDelete();

            modelBuilder.Entity<GAMEUSERDETAIL>()
                .Property(e => e.USEREMAIL)
                .IsUnicode(false);
        }
    }
}
