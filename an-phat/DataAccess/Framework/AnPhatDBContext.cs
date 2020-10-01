
    using DataAccess.Framework.Entity;
    using System;
using System.Collections.Generic;
using System.Data.Entity;
    using System.Data.Entity.Infrastructure;


    namespace DataAccess.Framework
    {
        public partial class AnPhatDBContext : DbContext
        {
            public AnPhatDBContext()
                : base("name=AnPhatDB")
            {
            }

            //public virtual DbSet<Category> Categories { get; set; }
            public virtual DbSet<District> Districts { get; set; }
            public virtual DbSet<Image> Images { get; set; }



        //public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        //public virtual DbSet<Order> Orders { get; set; }
            public virtual DbSet<ProductImage> ProductImage { get; set; }
            public virtual DbSet<ProductProperty> ProductProperties { get; set; }
            public virtual DbSet<Product> Products { get; set; }
            public virtual DbSet<PropertyCategory> PropertyCategories{ get; set; }
            //public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
            public virtual DbSet<User> Users { get; set; }
            //public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
            //public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
            //public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
        }
    }


