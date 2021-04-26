using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TravelAgencyDatabaseImplement.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement
{
    public partial class TravelAgencyContext : DbContext
    {
        public TravelAgencyContext()
        {
        }

        public TravelAgencyContext(DbContextOptions<TravelAgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<HotelNumberofhotel> HotelNumberofhotel { get; set; }
        public virtual DbSet<Numberofhotel> Numberofhotel { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<Typeofnumber> Typeofnumber { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=TravelAgency;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Datebithday)
                    .HasColumnName("datebithday")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Nameclient)
                    .IsRequired()
                    .HasColumnName("nameclient")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasColumnName("phonenumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("contract");

                entity.Property(e => e.Contractid).HasColumnName("contractid");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Countnumberhotel).HasColumnName("countnumberhotel");

                entity.Property(e => e.Datefromhotel)
                    .HasColumnName("datefromhotel")
                    .HasColumnType("date");

                entity.Property(e => e.Datefromtravel)
                    .HasColumnName("datefromtravel")
                    .HasColumnType("date");

                entity.Property(e => e.Datetohotel)
                    .HasColumnName("datetohotel")
                    .HasColumnType("date");

                entity.Property(e => e.Datetotravel)
                    .HasColumnName("datetotravel")
                    .HasColumnType("date");

                entity.Property(e => e.Hotelid).HasColumnName("hotelid");

                entity.Property(e => e.Routeid).HasColumnName("routeid");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.Clientid)
                    .HasConstraintName("contract_clientfk");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("contract_hotelfk");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.Routeid)
                    .HasConstraintName("contract_routefk");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.ToTable("hotel");

                entity.Property(e => e.Hotelid).HasColumnName("hotelid");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Hotelname)
                    .IsRequired()
                    .HasColumnName("hotelname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<HotelNumberofhotel>(entity =>
            {
                entity.HasKey(e => new { e.Hotelid, e.Numberofhotelid })
                    .HasName("hotel_numberofhotel_pkey");

                entity.ToTable("hotel_numberofhotel");

                entity.Property(e => e.Hotelid).HasColumnName("hotelid");

                entity.Property(e => e.Numberofhotelid).HasColumnName("numberofhotelid");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.HotelNumberofhotel)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("hotelfk");

                entity.HasOne(d => d.Numberofhotel)
                    .WithMany(p => p.HotelNumberofhotel)
                    .HasForeignKey(d => d.Numberofhotelid)
                    .HasConstraintName("numberofhotelfk");
            });

            modelBuilder.Entity<Numberofhotel>(entity =>
            {
                entity.ToTable("numberofhotel");

                entity.Property(e => e.Numberofhotelid).HasColumnName("numberofhotelid");

                entity.Property(e => e.Datearrival)
                    .HasColumnName("datearrival")
                    .HasColumnType("date");

                entity.Property(e => e.Dateofdeparture)
                    .HasColumnName("dateofdeparture")
                    .HasColumnType("date");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.Typeofnumberid).HasColumnName("typeofnumberid");

                entity.Property(e => e.Viewnumber)
                    .IsRequired()
                    .HasColumnName("viewnumber")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Typeofnumber)
                    .WithMany(p => p.Numberofhotel)
                    .HasForeignKey(d => d.Typeofnumberid)
                    .HasConstraintName("numberofhotel_typeofnumberfk");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("route");

                entity.Property(e => e.Routeid).HasColumnName("routeid");

                entity.Property(e => e.Cityto)
                    .IsRequired()
                    .HasColumnName("cityto")
                    .HasMaxLength(255);

                entity.Property(e => e.Transportid).HasColumnName("transportid");

                entity.Property(e => e.Сityfrom)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Transport)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.Transportid)
                    .HasConstraintName("routefr");
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.ToTable("transport");

                entity.Property(e => e.Transportid).HasColumnName("transportid");

                entity.Property(e => e.Priceticket)
                    .HasColumnName("priceticket")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.Routefrom)
                    .IsRequired()
                    .HasColumnName("routefrom")
                    .HasMaxLength(255);

                entity.Property(e => e.Routeto)
                    .IsRequired()
                    .HasColumnName("routeto")
                    .HasMaxLength(255);

                entity.Property(e => e.Viewtransport)
                    .IsRequired()
                    .HasColumnName("viewtransport")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Typeofnumber>(entity =>
            {
                entity.ToTable("typeofnumber");

                entity.Property(e => e.Typeofnumberid).HasColumnName("typeofnumberid");

                entity.Property(e => e.Viewnumber)
                    .IsRequired()
                    .HasColumnName("viewnumber")
                    .HasMaxLength(255);
            });

            modelBuilder.HasSequence("client_seq");

            modelBuilder.HasSequence("contract_seq").StartsAt(600);

            modelBuilder.HasSequence("hotel_seq").StartsAt(200);

            modelBuilder.HasSequence("numberofhotel_seq").StartsAt(400);

            modelBuilder.HasSequence("route_seq").StartsAt(100);

            modelBuilder.HasSequence("transport_seq").StartsAt(500);

            modelBuilder.HasSequence("typeofnumber_seq").StartsAt(300);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
