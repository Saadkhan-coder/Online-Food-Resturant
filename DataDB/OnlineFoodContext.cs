using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnlineFood.DataDB;

public partial class OnlineFoodContext : DbContext
{
    public OnlineFoodContext()
    {
    }

    public OnlineFoodContext(DbContextOptions<OnlineFoodContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Orderfood> Orderfoods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\sqlexpress;Initial Catalog=OnlineFood;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Orderfood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orderfoo__3214EC07ABFB117D");

            entity.ToTable("Orderfood");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FoodItem).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
