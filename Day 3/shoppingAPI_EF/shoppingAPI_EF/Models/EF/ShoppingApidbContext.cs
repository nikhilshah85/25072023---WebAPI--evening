using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace shoppingAPI_EF.Models.EF;

public partial class ShoppingApidbContext : DbContext
{
    public ShoppingApidbContext()
    {
    }

    public ShoppingApidbContext(DbContextOptions<ShoppingApidbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=shopping_APIDB;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Productid).HasName("PK__products__2D172D3287449A34");

            entity.ToTable("products");

            entity.Property(e => e.Productid)
                .ValueGeneratedNever()
                .HasColumnName("productid");
            entity.Property(e => e.ProductCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("productCategory");
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("productDescription");
            entity.Property(e => e.ProductIsInStock).HasColumnName("productIsInStock");
            entity.Property(e => e.ProductName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("productName");
            entity.Property(e => e.ProductPrice).HasColumnName("productPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
