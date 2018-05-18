namespace HomeWork08.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
        }

        public virtual DbSet<MyData> MyData { get; set; }
        public virtual DbSet<Pcalculate> Pcalculate { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Scalculate> Scalculate { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyData>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pcalculate>()
                .Property(e => e.ProductsTotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Scalculate>()
                .Property(e => e.SalesTotalPrice)
                .HasPrecision(18, 0);
        }
    }
}
