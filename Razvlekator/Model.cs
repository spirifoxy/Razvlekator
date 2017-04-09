namespace Razvlekator
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

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

        public List<session> GetAllSessionsFromAttr(attraction attr)
        {
            //ключ аттракциона
            var pk_attract = attr.pk_attraction;
            var carts = this.cart;
            //лист картов с аттракциона
            var cartsfromattr = new List<int>();

            foreach (var c in this.cart)
                if (c.pk_attraction == pk_attract)
                    cartsfromattr.Add(c.pk_cart);

            //лист мест по всем картам с аттракциона
            var placesfromcarts = new List<int>();
            var places = this.place;

            foreach (var pkcart in cartsfromattr)
                foreach (var place in places)
                {
                    if (place.pk_cart == pkcart)
                        placesfromcarts.Add(place.pk_place);
                }

            var places2 = this.place;
            var sessionsfromattr = new List<session>();
            var sessions = this.session;
            foreach (var ses in sessions)
                foreach (var placeinplaces in places2)
                    if (ses.pk_place == placeinplaces.pk_place)
                        sessionsfromattr.Add(ses);
            return sessionsfromattr;
        }

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
