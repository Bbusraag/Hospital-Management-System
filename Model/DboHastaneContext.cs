using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hastane_Proje.Model
{
    public partial class DboHastaneContext : DbContext
    {
        public DboHastaneContext()
        {
        }

        public DboHastaneContext(DbContextOptions<DboHastaneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Doktor> Doktor { get; set; }
        public virtual DbSet<Hasta> Hasta { get; set; }
        public virtual DbSet<Randevu> Randevu { get; set; }
        public virtual DbSet<TBölüm> TBölüm { get; set; }
        public virtual DbSet<TabloLaboratuvar> TabloLaboratuvar { get; set; }
        public virtual DbSet<TabloOda> TabloOda { get; set; }
        public virtual DbSet<TabloRadyoloji> TabloRadyoloji { get; set; }
        public virtual DbSet<TabloSaat> TabloSaat { get; set; }
        public virtual DbSet<TabloTahlilSonuç> TabloTahlilSonuç { get; set; }
        public virtual DbSet<TabloTahlilTür> TabloTahlilTür { get; set; }
        public virtual DbSet<TabloTarih> TabloTarih { get; set; }
        public virtual DbSet<TarihSaat> TarihSaat { get; set; }
        public virtual DbSet<TblHastane> TblHastane { get; set; }
        public virtual DbSet<TblHemsireTur> TblHemsireTur { get; set; }
        public virtual DbSet<TblHemsireler> TblHemsireler { get; set; }
        public virtual DbSet<TblPersoneller> TblPersoneller { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-7VA90SV\\SQLEXPRESS;Initial Catalog=DboHastane;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doktor>(entity =>
            {
                entity.Property(e => e.DoktorId).HasColumnName("Doktor id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BölümId).HasColumnName("Bölüm id");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bölüm)
                    .WithMany(p => p.Doktor)
                    .HasForeignKey(d => d.BölümId)
                    .HasConstraintName("FK_Doktor_T_Bölüm");
            });

            modelBuilder.Entity<Hasta>(entity =>
            {
                entity.Property(e => e.Ad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Randevu>(entity =>
            {
                entity.ToTable("RANDEVU");

                entity.Property(e => e.DoktorId).HasColumnName("Doktor Id");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.Hasta)
                    .WithMany(p => p.Randevu)
                    .HasForeignKey(d => d.HastaId)
                    .HasConstraintName("FK_RANDEVU_Hasta");
            });

            modelBuilder.Entity<TBölüm>(entity =>
            {
                entity.HasKey(e => e.BölümIdPk);

                entity.ToTable("T_Bölüm");

                entity.Property(e => e.BölümIdPk).HasColumnName("Bölüm_id_pk");

                entity.Property(e => e.BölümAd)
                    .IsRequired()
                    .HasColumnName("Bölüm Ad")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabloLaboratuvar>(entity =>
            {
                entity.HasKey(e => e.LabId)
                    .HasName("PK_Tablo_Laboratuvar_1");

                entity.ToTable("Tablo_Laboratuvar");

                entity.Property(e => e.DoktorId).HasColumnName("Doktor id");

                entity.Property(e => e.HastaTc).HasColumnName("Hasta Tc");

                entity.HasOne(d => d.Sonuc)
                    .WithMany(p => p.TabloLaboratuvar)
                    .HasForeignKey(d => d.SonucId)
                    .HasConstraintName("FK_Tablo_Laboratuvar_Tablo_Tahlil_Sonuç1");

                entity.HasOne(d => d.Tahlil)
                    .WithMany(p => p.TabloLaboratuvar)
                    .HasForeignKey(d => d.TahlilId)
                    .HasConstraintName("FK_Tablo_Laboratuvar_Tablo_Tahlil Tür");
            });

            modelBuilder.Entity<TabloOda>(entity =>
            {
                entity.HasKey(e => e.OdaId);

                entity.ToTable("Tablo_Oda");

                entity.Property(e => e.OdaId).HasColumnName("OdaID");

                entity.Property(e => e.OdaTürId).HasColumnName("Oda Tür id");

                entity.Property(e => e.YatakSayı).HasColumnName("Yatak sayı");
            });

            modelBuilder.Entity<TabloRadyoloji>(entity =>
            {
                entity.HasKey(e => e.RadyoId)
                    .HasName("PK_Tablo_Radyoloji_1");

                entity.ToTable("Tablo_Radyoloji");

                entity.Property(e => e.RadyoId).ValueGeneratedNever();

                entity.Property(e => e.DoktorId).HasColumnName("Doktor id");

                entity.Property(e => e.HastaTc).HasColumnName("Hasta Tc");

                entity.HasOne(d => d.Sonuc)
                    .WithMany(p => p.TabloRadyoloji)
                    .HasForeignKey(d => d.SonucId)
                    .HasConstraintName("FK_Tablo_Radyoloji_Tablo_Tahlil_Sonuç1");

                entity.HasOne(d => d.Tahlil)
                    .WithMany(p => p.TabloRadyoloji)
                    .HasForeignKey(d => d.TahlilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tablo_Radyoloji_Tablo_Tahlil Tür");
            });

            modelBuilder.Entity<TabloSaat>(entity =>
            {
                entity.HasKey(e => e.Saat);

                entity.ToTable("Tablo_Saat");

                entity.Property(e => e.Saat).ValueGeneratedNever();
            });

            modelBuilder.Entity<TabloTahlilSonuç>(entity =>
            {
                entity.HasKey(e => e.SonucId);

                entity.ToTable("Tablo_Tahlil_Sonuç");

                entity.Property(e => e.HastaTc).HasColumnName("Hasta_Tc");
            });

            modelBuilder.Entity<TabloTahlilTür>(entity =>
            {
                entity.HasKey(e => e.TahlilId)
                    .HasName("PK_Tablo_Tahlil Tür_1");

                entity.ToTable("Tablo_Tahlil Tür");

                entity.Property(e => e.TahlilTürAd)
                    .HasColumnName("Tahlil tür ad")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabloTarih>(entity =>
            {
                entity.HasKey(e => e.Tarih);

                entity.ToTable("Tablo_Tarih");

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TarihSaat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tarih_Saat");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.SaatNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Saat)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Tarih_Saat_Tablo_Saat");

                entity.HasOne(d => d.TarihNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Tarih)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Tarih_Saat_Tablo_Tarih");
            });

            modelBuilder.Entity<TblHastane>(entity =>
            {
                entity.HasKey(e => e.HastaneId);

                entity.ToTable("Tbl_Hastane");

                entity.Property(e => e.BölümId).HasColumnName("Bölüm id");

                entity.Property(e => e.DoktorId).HasColumnName("Doktor id");

                entity.Property(e => e.HastaneAd)
                    .HasColumnName("Hastane Ad")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OdaNo).HasColumnName("Oda No");

                entity.HasOne(d => d.Bölüm)
                    .WithMany(p => p.TblHastane)
                    .HasForeignKey(d => d.BölümId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Tbl_Hastane_T_Bölüm");

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.TblHastane)
                    .HasForeignKey(d => d.DoktorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Tbl_Hastane_Doktor");

                entity.HasOne(d => d.OdaNoNavigation)
                    .WithMany(p => p.TblHastane)
                    .HasForeignKey(d => d.OdaNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Tbl_Hastane_Tablo_Oda");
            });

            modelBuilder.Entity<TblHemsireTur>(entity =>
            {
                entity.HasKey(e => e.HemsireTurId);

                entity.ToTable("Tbl_HemsireTur");

                entity.Property(e => e.HemsireTurAd).HasMaxLength(50);
            });

            modelBuilder.Entity<TblHemsireler>(entity =>
            {
                entity.HasKey(e => e.HemsireId);

                entity.ToTable("Tbl_Hemsireler");

                entity.Property(e => e.HemsireAd).HasMaxLength(50);

                entity.Property(e => e.HemsireSoyad).HasMaxLength(50);

                entity.HasOne(d => d.HemsireTur)
                    .WithMany(p => p.TblHemsireler)
                    .HasForeignKey(d => d.HemsireTurId)
                    .HasConstraintName("FK_Tbl_Hemsireler_Tbl_HemsireTur");
            });

            modelBuilder.Entity<TblPersoneller>(entity =>
            {
                entity.HasKey(e => e.PersonelId);

                entity.ToTable("Tbl_Personeller");

                entity.Property(e => e.Adres).HasMaxLength(250);

                entity.Property(e => e.PersonelAd).HasMaxLength(50);

                entity.Property(e => e.PersonelSoyad).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
