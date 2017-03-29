namespace Razvlekator
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Razvlekator")
        {
        }

        public virtual DbSet<attraction> attraction { get; set; }
        public virtual DbSet<cart> cart { get; set; }
        public virtual DbSet<discount> discount { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<place> place { get; set; }
        public virtual DbSet<refund> Refund { get; set; }
        public virtual DbSet<session> session { get; set; }
        public virtual DbSet<ticket> Ticket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<attraction>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<attraction>()
                .HasMany(e => e.cart)
                .WithRequired(e => e.attraction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cart>()
                .HasMany(e => e.place)
                .WithRequired(e => e.cart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<discount>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<place>()
                .HasMany(e => e.session)
                .WithRequired(e => e.place)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<session>()
                .HasMany(e => e.Ticket)
                .WithRequired(e => e.session)
                .WillCascadeOnDelete(false);
        }
    }
}
