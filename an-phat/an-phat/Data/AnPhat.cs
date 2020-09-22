namespace an_phat.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AnPhat : DbContext
    {
        public AnPhat()
            : base("name=AnPhat")
        {
        }

        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductProperty> ProductProperties { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PropertyCategory> PropertyCategories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.SellPrice)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.SellDiscount)
                .HasPrecision(3, 0);

            modelBuilder.Entity<PropertyCategory>()
                .HasMany(e => e.ProductProperties)
                .WithOptional(e => e.PropertyCategory)
                .HasForeignKey(e => e.PropertyID);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OrderDetails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.OrderID);
        }
    }
}
