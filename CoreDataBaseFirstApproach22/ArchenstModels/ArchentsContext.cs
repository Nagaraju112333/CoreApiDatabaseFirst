using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class ArchentsContext : DbContext
    {
        public ArchentsContext()
        {
        }

        public ArchentsContext(DbContextOptions<ArchentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Lionlion> Lionlions { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderDetail1> OrderDetails1 { get; set; } = null!;
        public virtual DbSet<OrderProductId> OrderProductIds { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Products1> Products1s { get; set; } = null!;
        public virtual DbSet<Register> Registers { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<ShopingCartModel> ShopingCartModels { get; set; } = null!;
        public virtual DbSet<Size> Sizes { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<UserShipingAddress> UserShipingAddresses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Name");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__City__StateId__2BFE89A6");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Country_Name");
            });

            modelBuilder.Entity<Lionlion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lionlion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__OrderDet__C39F40174FE43B49");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.RazorpayKey)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("razorpayKey");

                entity.Property(e => e.RazorpayOrderid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Addressid)
                    .HasConstraintName("FK__OrderDeta__Addre__2645B050");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__OrderDeta__useri__245D67DE");
            });

            modelBuilder.Entity<OrderDetail1>(entity =>
            {
                entity.HasKey(e => e.OderDetaislId);

                entity.ToTable("OrderDetails", "Order");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<OrderProductId>(entity =>
            {
                entity.HasKey(e => e.OrderPid)
                    .HasName("PK__OrderPro__E59C916B3FF293EF");

                entity.ToTable("OrderProductId");

                entity.Property(e => e.OrderPid).HasColumnName("OrderPId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProductIds)
                    .HasForeignKey(d => d.Orderid)
                    .HasConstraintName("FK__OrderProd__Order__3A4CA8FD");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProductIds)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__OrderProd__Produ__3B40CD36");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payment");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContectNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contect_Number");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Products1>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__9834FBBAD68ECF52");

                entity.ToTable("Products1");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductDescription).HasColumnName("product_Description");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.Pstatus).HasColumnName("pstatus");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products1s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products1__Categ__72C60C4A");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("Register");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.ResetpasswordCode).HasMaxLength(100);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Registers)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK__Register__Roleid__29221CFB");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewTittle)
                    .HasMaxLength(50)
                    .HasColumnName("Review_Tittle");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShopingCartModel>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.ToTable("ShopingCartModel");

                entity.Property(e => e.ItemName).IsUnicode(false);

                entity.Property(e => e.Ondate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ShopingCartModels)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShopingCa__ItemI__1BC821DD");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ShopingCartModels)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ShopingCartModel_Register");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("size");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.Size1).HasColumnName("size");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Sizes)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__size__ProductId__5CD6CB2B");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__State__CountryId__07C12930");
            });

            modelBuilder.Entity<UserShipingAddress>(entity =>
            {
                entity.HasKey(e => e.AdderssId)
                    .HasName("PK__User_Shi__4C477CE329A37885");

                entity.ToTable("User_Shiping_Address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.UserShipingAddresses)
                    .HasForeignKey(d => d.Cityid)
                    .HasConstraintName("FK__User_Ship__Cityi__2EDAF651");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.UserShipingAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__User_Ship__Count__2CF2ADDF");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.UserShipingAddresses)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__User_Ship__State__2DE6D218");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserShipingAddresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__User_Ship__UserI__2180FB33");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
