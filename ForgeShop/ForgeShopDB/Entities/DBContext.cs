using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace ForgeShopDB.Entities
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PgStatStatements> PgStatStatements { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                var connectionString = configuration.GetConnectionString("ForgeShopDB");
                optionsBuilder.UseNpgsql("connectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("btree_gin")
                .HasPostgresExtension("btree_gist")
                .HasPostgresExtension("citext")
                .HasPostgresExtension("cube")
                .HasPostgresExtension("dblink")
                .HasPostgresExtension("dict_int")
                .HasPostgresExtension("dict_xsyn")
                .HasPostgresExtension("earthdistance")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("hstore")
                .HasPostgresExtension("intarray")
                .HasPostgresExtension("ltree")
                .HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("pgrowlocks")
                .HasPostgresExtension("pgstattuple")
                .HasPostgresExtension("tablefunc")
                .HasPostgresExtension("unaccent")
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("xml2");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(30);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .HasMaxLength(20);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("lname")
                    .HasMaxLength(30);

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasColumnName("pin")
                    .HasMaxLength(15);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(2);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnName("street")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(30);

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("zipcode")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("inventory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anvillarge).HasColumnName("anvillarge");

                entity.Property(e => e.Anvilmed).HasColumnName("anvilmed");

                entity.Property(e => e.Anvilsmall).HasColumnName("anvilsmall");

                entity.Property(e => e.Apronblack).HasColumnName("apronblack");

                entity.Property(e => e.Apronbrown).HasColumnName("apronbrown");

                entity.Property(e => e.Ballhammer).HasColumnName("ballhammer");

                entity.Property(e => e.Crosshammer).HasColumnName("crosshammer");

                entity.Property(e => e.Flathammer).HasColumnName("flathammer");

                entity.Property(e => e.Storeid).HasColumnName("storeid");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.Storeid)
                    .HasConstraintName("inventory_storeid_fkey");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("manager");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .HasMaxLength(20);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("lname")
                    .HasMaxLength(30);

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasColumnName("pin")
                    .HasMaxLength(15);

                entity.Property(e => e.Storeid).HasColumnName("storeid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.Storeid)
                    .HasConstraintName("manager_storeid_fkey");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anvilforty).HasColumnName("anvilforty");

                entity.Property(e => e.Anvilhundred).HasColumnName("anvilhundred");

                entity.Property(e => e.Apronblack).HasColumnName("apronblack");

                entity.Property(e => e.Apronbrown).HasColumnName("apronbrown");

                entity.Property(e => e.Aviltwenty).HasColumnName("aviltwenty");

                entity.Property(e => e.Ballhammer).HasColumnName("ballhammer");

                entity.Property(e => e.Crosshammer).HasColumnName("crosshammer");

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Flathammer).HasColumnName("flathammer");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Storeid).HasColumnName("storeid");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Custid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_custid_fkey");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Storeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_storeid_fkey");
            });

            modelBuilder.Entity<PgStatStatements>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_stat_statements");

                entity.Property(e => e.BlkReadTime).HasColumnName("blk_read_time");

                entity.Property(e => e.BlkWriteTime).HasColumnName("blk_write_time");

                entity.Property(e => e.Calls).HasColumnName("calls");

                entity.Property(e => e.Dbid)
                    .HasColumnName("dbid")
                    .HasColumnType("oid");

                entity.Property(e => e.LocalBlksDirtied).HasColumnName("local_blks_dirtied");

                entity.Property(e => e.LocalBlksHit).HasColumnName("local_blks_hit");

                entity.Property(e => e.LocalBlksRead).HasColumnName("local_blks_read");

                entity.Property(e => e.LocalBlksWritten).HasColumnName("local_blks_written");

                entity.Property(e => e.MaxTime).HasColumnName("max_time");

                entity.Property(e => e.MeanTime).HasColumnName("mean_time");

                entity.Property(e => e.MinTime).HasColumnName("min_time");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.Queryid).HasColumnName("queryid");

                entity.Property(e => e.Rows).HasColumnName("rows");

                entity.Property(e => e.SharedBlksDirtied).HasColumnName("shared_blks_dirtied");

                entity.Property(e => e.SharedBlksHit).HasColumnName("shared_blks_hit");

                entity.Property(e => e.SharedBlksRead).HasColumnName("shared_blks_read");

                entity.Property(e => e.SharedBlksWritten).HasColumnName("shared_blks_written");

                entity.Property(e => e.StddevTime).HasColumnName("stddev_time");

                entity.Property(e => e.TempBlksRead).HasColumnName("temp_blks_read");

                entity.Property(e => e.TempBlksWritten).HasColumnName("temp_blks_written");

                entity.Property(e => e.TotalTime).HasColumnName("total_time");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("oid");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnName("price");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
