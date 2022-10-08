using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InnovaLinks.DAL.Models
{
    public partial class InnovaLinksEntities : DbContext
    {
        public InnovaLinksEntities()
        {
        }

        public InnovaLinksEntities(DbContextOptions<InnovaLinksEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<NivelesCombustibleActuales> NivelesCombustibleActuales { get; set; }
        public virtual DbSet<TblTiemposBitacora> TblTiemposBitacora { get; set; }
        public virtual DbSet<TciplaceEnca> TciplaceEnca { get; set; }
        public virtual DbSet<ViajesRendimientoInnovalinks> ViajesRendimientoInnovalinks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=51.143.12.226;Database=Combustible_Innovalinks;User Id=softmsa; Password=Dsy-2Sa-2S5-fuA;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NivelesCombustibleActuales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("niveles_combustible_actuales");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateLocation).HasColumnType("datetime");

                entity.Property(e => e.MotorUsage).HasColumnName("motor_usage");

                entity.Property(e => e.Odometro).HasColumnName("odometro");

                entity.Property(e => e.Tea).HasColumnName("tea");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<TblTiemposBitacora>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_TiemposBitacora");

                entity.Property(e => e.Conductor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdViajeTc).HasColumnName("IdViajeTC");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TciplaceEnca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCIplaceEnca");

                entity.Property(e => e.CartaPorte)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Destinatario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Destino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusViaje)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdArea).HasColumnName("ID_Area");

                entity.Property(e => e.IdCliente).HasColumnName("ID_cliente");

                entity.Property(e => e.IdDestinatario).HasColumnName("ID_Destinatario");

                entity.Property(e => e.IdDestino).HasColumnName("ID_Destino");

                entity.Property(e => e.IdOperador).HasColumnName("ID_Operador");

                entity.Property(e => e.IdOrigen).HasColumnName("ID_Origen");

                entity.Property(e => e.IdUnidad)
                    .HasColumnName("ID_Unidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdrutaLis).HasColumnName("IDRutaLis");

                entity.Property(e => e.Idtc).HasColumnName("IDTC");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoViaje).HasColumnName("No_Viaje");

                entity.Property(e => e.Origen)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViajesRendimientoInnovalinks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VIAJES_RENDIMIENTO_INNOVALINKS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InicioViaje)
                    .HasColumnName("INICIO_VIAJE")
                    .HasColumnType("datetime");

                entity.Property(e => e.KmsRecorridos).HasColumnName("KMS_RECORRIDOS");

                entity.Property(e => e.LitrosDiesel).HasColumnName("LITROS_DIESEL");

                entity.Property(e => e.Rendimiento).HasColumnName("RENDIMIENTO");

                entity.Property(e => e.TerminoViaje)
                    .HasColumnName("TERMINO_VIAJE")
                    .HasColumnType("datetime");

                entity.Property(e => e.VelocidadMax).HasColumnName("VELOCIDAD_MAX");

                entity.Property(e => e.VelocidadPromedio).HasColumnName("VELOCIDAD_PROMEDIO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
