using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrmTc.DAL.Models
{
    public partial class CrmTcEntities : DbContext
    {
        public CrmTcEntities()
        {
        }

        public CrmTcEntities(DbContextOptions<CrmTcEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<AreasCobranza> AreasCobranza { get; set; }
        public virtual DbSet<AutosCategorias> AutosCategorias { get; set; }
        public virtual DbSet<AutosFamilias> AutosFamilias { get; set; }
        public virtual DbSet<AutosModelos> AutosModelos { get; set; }
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<BitacoraTiposEntrada> BitacoraTiposEntrada { get; set; }
        public virtual DbSet<CatalogoParametrosCotizacion> CatalogoParametrosCotizacion { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ClientesFacturacion> ClientesFacturacion { get; set; }
        public virtual DbSet<ClientesTipoGirosCliente> ClientesTipoGirosCliente { get; set; }
        public virtual DbSet<Colonias> Colonias { get; set; }
        public virtual DbSet<ComentariosCotizacion> ComentariosCotizacion { get; set; }
        public virtual DbSet<CondicionesEspeciales> CondicionesEspeciales { get; set; }
        public virtual DbSet<CondicionesEspecialesPuntosEntrega> CondicionesEspecialesPuntosEntrega { get; set; }
        public virtual DbSet<ConfigZam> ConfigZam { get; set; }
        public virtual DbSet<ConfiguracionCorreos> ConfiguracionCorreos { get; set; }
        public virtual DbSet<ConfiguracionesAdicionales> ConfiguracionesAdicionales { get; set; }
        public virtual DbSet<ContactosCliente> ContactosCliente { get; set; }
        public virtual DbSet<Contratos> Contratos { get; set; }
        public virtual DbSet<CotizaComentariosRuta> CotizaComentariosRuta { get; set; }
        public virtual DbSet<CotizaDetalleRuta> CotizaDetalleRuta { get; set; }
        public virtual DbSet<CotizaEstatusRevisionRuta> CotizaEstatusRevisionRuta { get; set; }
        public virtual DbSet<CotizaParadas> CotizaParadas { get; set; }
        public virtual DbSet<CotizaPuntosDeEntrega> CotizaPuntosDeEntrega { get; set; }
        public virtual DbSet<CotizaPuntosDeEntregaCondicionesEspeciales> CotizaPuntosDeEntregaCondicionesEspeciales { get; set; }
        public virtual DbSet<CotizaRegresos> CotizaRegresos { get; set; }
        public virtual DbSet<CotizaRutas> CotizaRutas { get; set; }
        public virtual DbSet<CotizaTiposMercados> CotizaTiposMercados { get; set; }
        public virtual DbSet<Cotizacion> Cotizacion { get; set; }
        public virtual DbSet<CotizacionParametros> CotizacionParametros { get; set; }
        public virtual DbSet<DealerTelefonos> DealerTelefonos { get; set; }
        public virtual DbSet<Destinos> Destinos { get; set; }
        public virtual DbSet<DetalleRuta> DetalleRuta { get; set; }
        public virtual DbSet<DistanciasRegresos> DistanciasRegresos { get; set; }
        public virtual DbSet<DocumentosCotizacion> DocumentosCotizacion { get; set; }
        public virtual DbSet<ErroresGlobalMaps> ErroresGlobalMaps { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<EstatusCliente> EstatusCliente { get; set; }
        public virtual DbSet<EstatusContrato> EstatusContrato { get; set; }
        public virtual DbSet<EstatusCotizacion> EstatusCotizacion { get; set; }
        public virtual DbSet<EstatusCotizacionHistory> EstatusCotizacionHistory { get; set; }
        public virtual DbSet<EstructuraCostosFijos> EstructuraCostosFijos { get; set; }
        public virtual DbSet<FasesEstatusCotizacion> FasesEstatusCotizacion { get; set; }
        public virtual DbSet<FlujoEstatusCotizacion> FlujoEstatusCotizacion { get; set; }
        public virtual DbSet<FormaPago> FormaPago { get; set; }
        public virtual DbSet<FormulasCotizacion> FormulasCotizacion { get; set; }
        public virtual DbSet<Funcionalidad> Funcionalidad { get; set; }
        public virtual DbSet<HorasRecepcion> HorasRecepcion { get; set; }
        public virtual DbSet<InfoDb> InfoDb { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<MetodoPago> MetodoPago { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<MotivosRechazoCliente> MotivosRechazoCliente { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<OficinaDisponibilidad> OficinaDisponibilidad { get; set; }
        public virtual DbSet<OficinaRazonesDisponibilidad> OficinaRazonesDisponibilidad { get; set; }
        public virtual DbSet<Oficinas> Oficinas { get; set; }
        public virtual DbSet<OficinasOperativas> OficinasOperativas { get; set; }
        public virtual DbSet<Origenes> Origenes { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Paradas> Paradas { get; set; }
        public virtual DbSet<ParametrosSistema> ParametrosSistema { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<PreciosHistoricosRutas> PreciosHistoricosRutas { get; set; }
        public virtual DbSet<ProcesoEnvioNotificaciones> ProcesoEnvioNotificaciones { get; set; }
        public virtual DbSet<ProductoTransportar> ProductoTransportar { get; set; }
        public virtual DbSet<Proyectos> Proyectos { get; set; }
        public virtual DbSet<PuntosEntrega> PuntosEntrega { get; set; }
        public virtual DbSet<RegistrosActividad> RegistrosActividad { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesPermisos> RolesPermisos { get; set; }
        public virtual DbSet<RutaTipoTractor> RutaTipoTractor { get; set; }
        public virtual DbSet<Rutas> Rutas { get; set; }
        public virtual DbSet<Seguros> Seguros { get; set; }
        public virtual DbSet<SesionHistory> SesionHistory { get; set; }
        public virtual DbSet<TarifasContratos> TarifasContratos { get; set; }
        public virtual DbSet<TemplateConfig> TemplateConfig { get; set; }
        public virtual DbSet<TemplateCorreos> TemplateCorreos { get; set; }
        public virtual DbSet<TipoPuntoEntrega> TipoPuntoEntrega { get; set; }
        public virtual DbSet<TiposCredito> TiposCredito { get; set; }
        public virtual DbSet<TiposDocumento> TiposDocumento { get; set; }
        public virtual DbSet<TiposFormula> TiposFormula { get; set; }
        public virtual DbSet<TiposGirosCliente> TiposGirosCliente { get; set; }
        public virtual DbSet<TiposIva> TiposIva { get; set; }
        public virtual DbSet<TiposMoneda> TiposMoneda { get; set; }
        public virtual DbSet<TiposPago> TiposPago { get; set; }
        public virtual DbSet<TiposRetencion> TiposRetencion { get; set; }
        public virtual DbSet<TiposTractor> TiposTractor { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
        public virtual DbSet<UsosCfdi> UsosCfdi { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosRoles> UsuariosRoles { get; set; }
        public virtual DbSet<VwCiudades> VwCiudades { get; set; }
        public virtual DbSet<VwColonias> VwColonias { get; set; }
        public virtual DbSet<VwContratos> VwContratos { get; set; }
        public virtual DbSet<VwCotizacionParametrosPermisos> VwCotizacionParametrosPermisos { get; set; }
        public virtual DbSet<VwCotizaciones> VwCotizaciones { get; set; }
        public virtual DbSet<VwDashBoardContratos> VwDashBoardContratos { get; set; }
        public virtual DbSet<VwDashBoardCotizacion> VwDashBoardCotizacion { get; set; }
        public virtual DbSet<VwDashBoardListadoCliente> VwDashBoardListadoCliente { get; set; }
        public virtual DbSet<VwDestinos> VwDestinos { get; set; }
        public virtual DbSet<VwDocumentosContrato> VwDocumentosContrato { get; set; }
        public virtual DbSet<VwMaquinaEstados> VwMaquinaEstados { get; set; }
        public virtual DbSet<VwObtenerCondicionesEspecialesPuntosEntrega> VwObtenerCondicionesEspecialesPuntosEntrega { get; set; }
        public virtual DbSet<VwOficinasTc> VwOficinasTc { get; set; }
        public virtual DbSet<VwOrigenes> VwOrigenes { get; set; }
        public virtual DbSet<VwParadas> VwParadas { get; set; }
        public virtual DbSet<VwParadasRutaTipoTractor> VwParadasRutaTipoTractor { get; set; }
        public virtual DbSet<VwPuntosEntrega> VwPuntosEntrega { get; set; }
        public virtual DbSet<VwRolesFuncionalidadesPermisos> VwRolesFuncionalidadesPermisos { get; set; }
        public virtual DbSet<VwRutas> VwRutas { get; set; }
        public virtual DbSet<VwUbicaciones> VwUbicaciones { get; set; }
        public virtual DbSet<Zonas> Zonas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=51.143.12.226;Database=CRMTCV2;User Id=softmsa; Password=Dsy-2Sa-2S5-fuA;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreasCobranza>(entity =>
            {
                entity.ToTable("areasCobranza");

                entity.HasComment(@"Catálogo: i.e.
Autos
Secos (papa)
Refrigerado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<AutosCategorias>(entity =>
            {
                entity.ToTable("autosCategorias");

                entity.HasComment(@"Catálogo: i.e.
Nombre: Categoria 1
Descripción: autos chicos

Nombre: Categoria 2
Descripción: autos medianos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Categoria)
                    .HasColumnName("categoria")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdLinea).HasColumnName("idLinea");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<AutosFamilias>(entity =>
            {
                entity.ToTable("autosFamilias");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.AutosFamilias)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKautosFamil909252");
            });

            modelBuilder.Entity<AutosModelos>(entity =>
            {
                entity.ToTable("autosModelos");

                entity.HasComment(@"Catálogo: i.e.
Nissan Versa
NIssan Altima
Nissan March");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.AutosModelos)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKautosModel160099");
            });

            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.ToTable("bitacora");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Entity)
                    .HasColumnName("entity")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdBitacoraTipoEntrada).HasColumnName("idBitacoraTipoEntrada");

                entity.Property(e => e.IdObject).HasColumnName("idObject");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdBitacoraTipoEntradaNavigation)
                    .WithMany(p => p.Bitacora)
                    .HasForeignKey(d => d.IdBitacoraTipoEntrada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKbitacora487547");
            });

            modelBuilder.Entity<BitacoraTiposEntrada>(entity =>
            {
                entity.ToTable("bitacoraTiposEntrada");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<CatalogoParametrosCotizacion>(entity =>
            {
                entity.ToTable("catalogoParametrosCotizacion");

                entity.HasComment(@"Catálogo:

Diesel
Número días del año");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EditableEnCotizacion)
                    .IsRequired()
                    .HasColumnName("editableEnCotizacion")
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.EsOperativo)
                    .IsRequired()
                    .HasColumnName("esOperativo")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Seccion)
                    .HasColumnName("seccion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VisibleEnCotizacion).HasColumnName("visibleEnCotizacion");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.ToTable("ciudades");

                entity.HasComment("Este catálogo vendrá de ZAM, de la entidad de Plazas.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdZona)
                    .HasColumnName("idZona")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.IdZona)
                    .HasConstraintName("FKciudades416540");

                entity.HasOne(d => d.Municipios)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.Municipiosid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKciudades836483");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.ToTable("clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AutosNuevos)
                    .IsRequired()
                    .HasColumnName("autosNuevos")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AuxiliarContable)
                    .HasColumnName("auxiliarContable")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CalculaSeguroCarga).HasColumnName("calculaSeguroCarga");

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("claveCliente")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ConsecutivoCobranza).HasColumnName("consecutivoCobranza");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CuentaCliente)
                    .HasColumnName("cuentaCliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAreaCobranza)
                    .HasColumnName("descripcionAreaCobranza")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasColumnName("domicilio")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EsLead).HasColumnName("esLead");

                entity.Property(e => e.EsPersonaMoral).HasColumnName("esPersonaMoral");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FrecuenciaNotificacion).HasColumnName("frecuenciaNotificacion");

                entity.Property(e => e.FuelSurcharge).HasColumnName("fuelSurcharge");

                entity.Property(e => e.HoldingNombre)
                    .HasColumnName("holdingNombre")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.HoldingPorcentaje).HasColumnName("holdingPorcentaje");

                entity.Property(e => e.HoldingVolumen).HasColumnName("holdingVolumen");

                entity.Property(e => e.Holdings).HasColumnName("holdings");

                entity.Property(e => e.IdAreaCobranza).HasColumnName("idAreaCobranza");

                entity.Property(e => e.IdClienteFacturacionPrincipal).HasColumnName("idClienteFacturacionPrincipal");

                entity.Property(e => e.IdClienteZam).HasColumnName("idClienteZam");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstatusCliente).HasColumnName("idEstatusCliente");

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.IdOtrosGirosCliente).HasColumnName("idOtrosGirosCliente");

                entity.Property(e => e.IdPlazaCliente).HasColumnName("idPlazaCliente");

                entity.Property(e => e.IdTipoCredito).HasColumnName("idTipoCredito");

                entity.Property(e => e.IdTipoFormula).HasColumnName("idTipoFormula");

                entity.Property(e => e.IdTipoGiroPrincipalCliente).HasColumnName("idTipoGiroPrincipalCliente");

                entity.Property(e => e.IdTipoIva).HasColumnName("idTipoIVA");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.IdTipoRetencion).HasColumnName("idTipoRetencion");

                entity.Property(e => e.IdUsoCfdi).HasColumnName("idUsoCFDI");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("image");

                entity.Property(e => e.MontoAdvertenciaLimite).HasColumnName("montoAdvertenciaLimite");

                entity.Property(e => e.MontoLimiteCredito).HasColumnName("montoLimiteCredito");

                entity.Property(e => e.NoCliente)
                    .HasColumnName("noCliente")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAreaCobranza)
                    .HasColumnName("nombreAreaCobranza")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComercial)
                    .IsRequired()
                    .HasColumnName("nombreComercial")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("numExterior")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("numInterior")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Prioridad).HasColumnName("prioridad");

                entity.Property(e => e.SeguroUnidades).HasColumnName("seguroUnidades");

                entity.Property(e => e.SubcuentaCliente)
                    .HasColumnName("subcuentaCliente")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.ValorSurcharge).HasColumnName("valorSurcharge");

                entity.HasOne(d => d.IdAreaCobranzaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdAreaCobranza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes387401");

                entity.HasOne(d => d.IdColoniaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdColonia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes891040");

                entity.HasOne(d => d.IdEstatusClienteNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdEstatusCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes520989");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes734882");

                entity.HasOne(d => d.IdTipoCreditoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes853615");

                entity.HasOne(d => d.IdTipoFormulaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoFormula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes2525");

                entity.HasOne(d => d.IdTipoGiroPrincipalClienteNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoGiroPrincipalCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes368071");

                entity.HasOne(d => d.IdTipoIvaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoIva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes19661");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes534488");

                entity.HasOne(d => d.IdTipoRetencionNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoRetencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes531312");

                entity.HasOne(d => d.IdUsoCfdiNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdUsoCfdi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientes847238");
            });

            modelBuilder.Entity<ClientesFacturacion>(entity =>
            {
                entity.ToTable("clientesFacturacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ApellidoMat)
                    .HasColumnName("apellidoMat")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPat)
                    .HasColumnName("apellidoPat")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EsPersonaMoral).HasColumnName("esPersonaMoral");

                entity.Property(e => e.EsPrincipal).HasColumnName("esPrincipal");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdFormaPago).HasColumnName("idFormaPago");

                entity.Property(e => e.IdMetodoPago).HasColumnName("idMetodoPago");

                entity.Property(e => e.IdTipoCliente).HasColumnName("idTipoCliente");

                entity.Property(e => e.Localidad)
                    .HasColumnName("localidad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("numExterior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("numInterior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCuenta)
                    .HasColumnName("numeroCuenta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razonSocial")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesFacturacion)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientesFa658291");

                entity.HasOne(d => d.IdColoniaNavigation)
                    .WithMany(p => p.ClientesFacturacion)
                    .HasForeignKey(d => d.IdColonia)
                    .HasConstraintName("FKclientesFa48444");

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.ClientesFacturacion)
                    .HasForeignKey(d => d.IdFormaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientesFa633872");

                entity.HasOne(d => d.IdMetodoPagoNavigation)
                    .WithMany(p => p.ClientesFacturacion)
                    .HasForeignKey(d => d.IdMetodoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientesFa368267");
            });

            modelBuilder.Entity<ClientesTipoGirosCliente>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoGiroCliente })
                    .HasName("PK__clientes__5DF044B04D9A39EF");

                entity.ToTable("clientesTipoGirosCliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdTipoGiroCliente).HasColumnName("idTipoGiroCliente");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesTipoGirosCliente)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientesTi912689");

                entity.HasOne(d => d.IdTipoGiroClienteNavigation)
                    .WithMany(p => p.ClientesTipoGirosCliente)
                    .HasForeignKey(d => d.IdTipoGiroCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKclientesTi283639");
            });

            modelBuilder.Entity<Colonias>(entity =>
            {
                entity.ToTable("colonias");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Municipiosid).HasColumnName("municipiosid");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Statesid).HasColumnName("statesid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Municipios)
                    .WithMany(p => p.Colonias)
                    .HasForeignKey(d => d.Municipiosid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcolonias459940");
            });

            modelBuilder.Entity<ComentariosCotizacion>(entity =>
            {
                entity.ToTable("comentariosCotizacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstatusCotizacionHistory).HasColumnName("idEstatusCotizacionHistory");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstatusCotizacionHistoryNavigation)
                    .WithMany(p => p.ComentariosCotizacion)
                    .HasForeignKey(d => d.IdEstatusCotizacionHistory)
                    .HasConstraintName("FKcomentario410370");
            });

            modelBuilder.Entity<CondicionesEspeciales>(entity =>
            {
                entity.ToTable("condicionesEspeciales");

                entity.HasComment(@"Catálogo: i.e.
Ferrie
Taxi
Hotel
Pension
Guia
Permiso
Seguro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<CondicionesEspecialesPuntosEntrega>(entity =>
            {
                entity.HasKey(e => new { e.IdCondicionesEspeciales, e.IdPuntoEntrega })
                    .HasName("PK__condicio__6DC44202B2B35400");

                entity.ToTable("condicionesEspecialesPuntosEntrega");

                entity.Property(e => e.IdCondicionesEspeciales).HasColumnName("idCondicionesEspeciales");

                entity.Property(e => e.IdPuntoEntrega).HasColumnName("idPuntoEntrega");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(19, 0)");

                entity.HasOne(d => d.IdCondicionesEspecialesNavigation)
                    .WithMany(p => p.CondicionesEspecialesPuntosEntrega)
                    .HasForeignKey(d => d.IdCondicionesEspeciales)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcondicione758734");

                entity.HasOne(d => d.IdPuntoEntregaNavigation)
                    .WithMany(p => p.CondicionesEspecialesPuntosEntrega)
                    .HasForeignKey(d => d.IdPuntoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcondicione669303");
            });

            modelBuilder.Entity<ConfigZam>(entity =>
            {
                entity.ToTable("configZAM");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Database)
                    .IsRequired()
                    .HasColumnName("database")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Servername)
                    .IsRequired()
                    .HasColumnName("servername")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userId")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracionCorreos>(entity =>
            {
                entity.ToTable("configuracionCorreos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BContrasena)
                    .HasColumnName("bContrasena")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.PuertoEntrada).HasColumnName("puertoEntrada");

                entity.Property(e => e.PuertoSalida).HasColumnName("puertoSalida");

                entity.Property(e => e.ServidorEntrada)
                    .HasColumnName("servidorEntrada")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorSalida)
                    .HasColumnName("servidorSalida")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracionesAdicionales>(entity =>
            {
                entity.ToTable("configuracionesAdicionales");

                entity.HasComment(@"Todos los parámetros configuracion a considerar para no manejar variables hardcode dentro del código.
 ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactosCliente>(entity =>
            {
                entity.ToTable("contactosCliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Domicilio)
                    .HasColumnName("domicilio")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("numExterior")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("numInterior")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .HasColumnName("puesto")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ContactosCliente)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcontactosC87437");
            });

            modelBuilder.Entity<Contratos>(entity =>
            {
                entity.ToTable("contratos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ClaveContrato)
                    .IsRequired()
                    .HasColumnName("claveContrato")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fechaFin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEstatusContrato).HasColumnName("idEstatusContrato");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdEstatusContratoNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.IdEstatusContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcontratos785186");
            });

            modelBuilder.Entity<CotizaComentariosRuta>(entity =>
            {
                entity.ToTable("cotizaComentariosRuta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.IdCotizaEstatusRevisionRuta).HasColumnName("idCotizaEstatusRevisionRuta");

                entity.Property(e => e.IdCotizaRutas).HasColumnName("idCotizaRutas");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCotizaEstatusRevisionRutaNavigation)
                    .WithMany(p => p.CotizaComentariosRuta)
                    .HasForeignKey(d => d.IdCotizaEstatusRevisionRuta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaCome538681");

                entity.HasOne(d => d.IdCotizaRutasNavigation)
                    .WithMany(p => p.CotizaComentariosRuta)
                    .HasForeignKey(d => d.IdCotizaRutas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaCome346086");
            });

            modelBuilder.Entity<CotizaDetalleRuta>(entity =>
            {
                entity.ToTable("cotizaDetalleRuta");

                entity.HasComment(@"Esta infomración es la que viene de las rutas de GlobalMap.


La regla de negocio es que una ruta tenga solo un detalle de ruta, pero se deja la relación Mto1 por flexibilidad

La relación de muchos a 1, con cotizaRutas, también puede ser necesaria por si se tienen que guardar diferentes versiones del detalle de la ruta, como un HISTORIAL, o algo similar.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CombustibleSinIva)
                    .HasColumnName("combustibleSinIVA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ConRepartos)
                    .HasColumnName("conRepartos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostoCasetas)
                    .HasColumnName("costoCasetas")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DiasViajeEstimados)
                    .HasColumnName("diasViajeEstimados")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DiversosGastosTransportacion)
                    .HasColumnName("diversosGastosTransportacion")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FacturacionEstimadaMensual)
                    .HasColumnName("facturacionEstimadaMensual")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.FechaFleteHistorico)
                    .HasColumnName("fechaFleteHistorico")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCotizaRutas).HasColumnName("idCotizaRutas");

                entity.Property(e => e.IdRutaInnovaLinks)
                    .HasColumnName("idRutaInnovaLinks")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdRutaZam)
                    .HasColumnName("idRutaZam")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KilometrajeCliente)
                    .HasColumnName("kilometrajeCliente")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.KmsEstMensuales)
                    .HasColumnName("kmsEstMensuales")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.KmsNegociados).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Llantas)
                    .HasColumnName("llantas")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PeajeSinIva)
                    .HasColumnName("peajeSinIVA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PorcentajeCargado)
                    .HasColumnName("porcentajeCargado")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PorcentajeDescuento)
                    .HasColumnName("porcentajeDescuento")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PorcentajeIncDec)
                    .HasColumnName("porcentajeIncDec")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcentajeProbabilidadCarga).HasColumnName("porcentajeProbabilidadCarga");

                entity.Property(e => e.PorcentajeSueldoOperador)
                    .HasColumnName("porcentajeSueldoOperador")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PorcentajeVacio)
                    .HasColumnName("porcentajeVacio")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PrecioFleteCalculado)
                    .HasColumnName("precioFleteCalculado")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecioFleteFinal)
                    .HasColumnName("precioFleteFinal")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecioFleteHistorico)
                    .HasColumnName("precioFleteHistorico")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PrecioXkms)
                    .HasColumnName("precioXkms")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RateCarga)
                    .HasColumnName("rateCarga")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.RefaccionesAccesorios)
                    .HasColumnName("refaccionesAccesorios")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Rendimiento)
                    .HasColumnName("rendimiento")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RequiereRevision)
                    .IsRequired()
                    .HasColumnName("requiereRevision")
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.RutaEspecial).HasColumnName("rutaEspecial");

                entity.Property(e => e.SalarioOperador)
                    .HasColumnName("salarioOperador")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SueldoOperador)
                    .HasColumnName("sueldoOperador")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TiempoTotal).HasColumnName("tiempoTotal");

                entity.Property(e => e.TotalGastosVariables)
                    .HasColumnName("totalGastosVariables")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Utilidad)
                    .HasColumnName("utilidad")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ViajesAlMes)
                    .HasColumnName("viajesAlMes")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Volumen)
                    .HasColumnName("volumen")
                    .HasColumnType("decimal(19, 2)");

                entity.HasOne(d => d.IdCotizaRutasNavigation)
                    .WithMany(p => p.CotizaDetalleRuta)
                    .HasForeignKey(d => d.IdCotizaRutas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaDeta716154");
            });

            modelBuilder.Entity<CotizaEstatusRevisionRuta>(entity =>
            {
                entity.ToTable("cotizaEstatusRevisionRuta");

                entity.HasComment(@"Catálogo:

1
no-revision
No se requiere revisión
2
revision
Se requiere revisión
3
aprobada
Se revisó, y ya está aprobada.
4
rechazada
Se revisó y fue rechazada
 ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CotizaParadas>(entity =>
            {
                entity.ToTable("cotizaParadas");

                entity.HasComment(@"Un Reparto se compone de un Origen y un Destino.
Cada Punto de Entrega debe de fungir uno de estos roles en algún momento.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.CostoCasetas)
                    .HasColumnName("costoCasetas")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CostoCasetasAcum)
                    .HasColumnName("costoCasetasAcum")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EsReparto)
                    .HasColumnName("esReparto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCotizaRutas).HasColumnName("idCotizaRutas");

                entity.Property(e => e.IdParadas).HasColumnName("idParadas");

                entity.Property(e => e.Incluido)
                    .IsRequired()
                    .HasColumnName("incluido")
                    .HasDefaultValueSql("('true')")
                    .HasComment("esto significa que si el usuario sekecciona que se incluye o no.");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.KmsAcumulados)
                    .HasColumnName("kmsAcumulados")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.TiempoTotal).HasColumnName("tiempoTotal");

                entity.Property(e => e.TiempoTotalAcum).HasColumnName("tiempoTotalAcum");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCotizaRutasNavigation)
                    .WithMany(p => p.CotizaParadas)
                    .HasForeignKey(d => d.IdCotizaRutas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaPara1336");

                entity.HasOne(d => d.IdParadasNavigation)
                    .WithMany(p => p.CotizaParadas)
                    .HasForeignKey(d => d.IdParadas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaPara78529");
            });

            modelBuilder.Entity<CotizaPuntosDeEntrega>(entity =>
            {
                entity.ToTable("cotizaPuntosDeEntrega");

                entity.HasComment(@"La necesidad de esta entidad, es porque las cotizaciones, al visualizarse hacia atrás en el tiempo, deben de mostrarse cuáles eran los DEALERS, y cuáles fueron las condiciones especiales de dichos dealers que se tenían!

cuando se termine la cotización, deberá copiarse los dealers que pertenecen a cada destino, y guardarse sus condiciones especiales.

Esta tabla lo relacionamos a la ruta, para poder sacar posteriormente de manera directa, los dealers que tenía la cotización.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCotizaRutas).HasColumnName("idCotizaRutas");

                entity.Property(e => e.IdPuntosEntrega).HasColumnName("idPuntosEntrega");

                entity.HasOne(d => d.IdCotizaRutasNavigation)
                    .WithMany(p => p.CotizaPuntosDeEntrega)
                    .HasForeignKey(d => d.IdCotizaRutas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaPunt559737");

                entity.HasOne(d => d.IdPuntosEntregaNavigation)
                    .WithMany(p => p.CotizaPuntosDeEntrega)
                    .HasForeignKey(d => d.IdPuntosEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaPunt19346");
            });

            modelBuilder.Entity<CotizaPuntosDeEntregaCondicionesEspeciales>(entity =>
            {
                entity.HasKey(e => new { e.IdCotizaPuntosDeEntrega, e.IdCondicionesEspeciales })
                    .HasName("PK__cotizaPu__4DB36FFC10BE38C0");

                entity.ToTable("cotizaPuntosDeEntrega_CondicionesEspeciales");

                entity.Property(e => e.IdCotizaPuntosDeEntrega).HasColumnName("idCotizaPuntosDeEntrega");

                entity.Property(e => e.IdCondicionesEspeciales).HasColumnName("idCondicionesEspeciales");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdCondicionesEspecialesNavigation)
                    .WithMany(p => p.CotizaPuntosDeEntregaCondicionesEspeciales)
                    .HasForeignKey(d => d.IdCondicionesEspeciales)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaPunt814017");

                entity.HasOne(d => d.IdCotizaPuntosDeEntregaNavigation)
                    .WithMany(p => p.CotizaPuntosDeEntregaCondicionesEspeciales)
                    .HasForeignKey(d => d.IdCotizaPuntosDeEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaPunt998551");
            });

            modelBuilder.Entity<CotizaRegresos>(entity =>
            {
                entity.ToTable("cotizaRegresos");

                entity.HasComment(@"De la pantalla donde se muestran los regresos, se acordó que solo estos van a pertener al tramo: DESTINO (De la ruta) al REGRESO.

Datos de la ruta (Destino-Regreso):
Kms – Solo se considera Destino-Regreso
Autopistas – Solo se considera Destino-Regreso
% Probabilidad de Carga – (Validar) Aun no tenemos este dato ya que viene de las tablas de innovalinks que aun no tienen disponibles en ZAM");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.AcumuladoProbabilidadCarga)
                    .HasColumnName("acumuladoProbabilidadCarga")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CostoCasetas)
                    .HasColumnName("costoCasetas")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdCotizaRutas).HasColumnName("idCotizaRutas");

                entity.Property(e => e.IdOrigenes).HasColumnName("idOrigenes");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PorcentajeCargado)
                    .HasColumnName("porcentajeCargado")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PorcentajeVacio)
                    .HasColumnName("porcentajeVacio")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.PrecioFlete)
                    .HasColumnName("precioFlete")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecioPorKilometro)
                    .HasColumnName("precioPorKilometro")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ProbabilidadCarga)
                    .HasColumnName("probabilidadCarga")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Seleccionado)
                    .HasColumnName("seleccionado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sugerido)
                    .HasColumnName("sugerido")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tiempo).HasColumnName("tiempo");

                entity.Property(e => e.TotalGastosFijos)
                    .HasColumnName("totalGastosFijos")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalGastosVariables)
                    .HasColumnName("totalGastosVariables")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCotizaRutasNavigation)
                    .WithMany(p => p.CotizaRegresos)
                    .HasForeignKey(d => d.IdCotizaRutas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaRegr704459");

                entity.HasOne(d => d.IdOrigenesNavigation)
                    .WithMany(p => p.CotizaRegresos)
                    .HasForeignKey(d => d.IdOrigenes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaRegr580875");
            });

            modelBuilder.Entity<CotizaRutas>(entity =>
            {
                entity.ToTable("cotizaRutas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Calculada).HasColumnName("calculada");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdCotizaEstatusRevisionRuta).HasColumnName("idCotizaEstatusRevisionRuta");

                entity.Property(e => e.IdCotizaTiposMercados).HasColumnName("idCotizaTiposMercados");

                entity.Property(e => e.IdCotizacion).HasColumnName("idCotizacion");

                entity.Property(e => e.IdEstructuraCostosFijos).HasColumnName("idEstructuraCostosFijos");

                entity.Property(e => e.IdRutas).HasColumnName("idRutas");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCotizaEstatusRevisionRutaNavigation)
                    .WithMany(p => p.CotizaRutas)
                    .HasForeignKey(d => d.IdCotizaEstatusRevisionRuta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaRuta759180");

                entity.HasOne(d => d.IdCotizaTiposMercadosNavigation)
                    .WithMany(p => p.CotizaRutas)
                    .HasForeignKey(d => d.IdCotizaTiposMercados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaRuta584931");

                entity.HasOne(d => d.IdCotizacionNavigation)
                    .WithMany(p => p.CotizaRutas)
                    .HasForeignKey(d => d.IdCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaRuta920452");

                entity.HasOne(d => d.IdRutasNavigation)
                    .WithMany(p => p.CotizaRutas)
                    .HasForeignKey(d => d.IdRutas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizaRuta127813");
            });

            modelBuilder.Entity<CotizaTiposMercados>(entity =>
            {
                entity.ToTable("cotizaTiposMercados");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Cotizacion>(entity =>
            {
                entity.ToTable("cotizacion");

                entity.HasComment(@"esto se va a realizar usando cotizacionIdenitity en cotizacion

Se deben identificar las entidades que deben de ser 'clonados los registros' para generar el histórico.

Notas:
idEstatusCotizacion está duplicado porque existe en EstatusCotizaciónHistory, pero va a ayudar para las consultas sean más rápidas cuando sea por estatus.");

                entity.HasIndex(e => e.CotizacionIdentity)
                    .HasName("cotizacion_cotizacionIdentity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivacionFlota)
                    .HasColumnName("activacionFlota")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Aprobacion).HasColumnName("aprobacion");

                entity.Property(e => e.CotizacionIdentity).HasColumnName("cotizacionIdentity");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.FechaAprobacion)
                    .HasColumnName("fechaAprobacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFinServicio)
                    .HasColumnName("fechaFinServicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicioServicio)
                    .HasColumnName("fechaInicioServicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.FuelSurcharge).HasColumnName("fuelSurcharge");

                entity.Property(e => e.FuelSurchargeValor).HasColumnName("fuelSurchargeValor");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdContratos).HasColumnName("idContratos");

                entity.Property(e => e.IdEstatusCotizacion).HasColumnName("idEstatusCotizacion");

                entity.Property(e => e.IdEstructuraCostosFijos).HasColumnName("idEstructuraCostosFijos");

                entity.Property(e => e.IdFormulaCotizacion).HasColumnName("idFormulaCotizacion");

                entity.Property(e => e.IdMotivosRechazoCliente).HasColumnName("idMotivosRechazoCliente");

                entity.Property(e => e.IdParametroCotizacion).HasColumnName("idParametroCotizacion");

                entity.Property(e => e.IdProductoTransportar).HasColumnName("idProductoTransportar");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdTipoTractor).HasColumnName("idTipoTractor");

                entity.Property(e => e.IdUsuarios)
                    .HasColumnName("idUsuarios")
                    .HasComment("Este campo es para guardar la relación entre la cotización, y el agente comercial.");

                entity.Property(e => e.IncrementoFlota)
                    .HasColumnName("incrementoFlota")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservacionVersion)
                    .HasColumnName("observacionVersion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioTotalCotizacion)
                    .HasColumnName("precioTotalCotizacion")
                    .HasColumnType("decimal(19, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Reprocesar)
                    .HasColumnName("reprocesar")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RespuestaDa).HasColumnName("respuestaDA");

                entity.Property(e => e.RespuestaDg).HasColumnName("respuestaDG");

                entity.Property(e => e.TasaTiie).HasColumnName("tasaTIIE");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizacion515658");

                entity.HasOne(d => d.IdContratosNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdContratos)
                    .HasConstraintName("FKcotizacion764166");

                entity.HasOne(d => d.IdEstatusCotizacionNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdEstatusCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizacion646239");

                entity.HasOne(d => d.IdEstructuraCostosFijosNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdEstructuraCostosFijos)
                    .HasConstraintName("FKcotizacion948755");

                entity.HasOne(d => d.IdFormulaCotizacionNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdFormulaCotizacion)
                    .HasConstraintName("FKcotizacion867438");

                entity.HasOne(d => d.IdMotivosRechazoClienteNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdMotivosRechazoCliente)
                    .HasConstraintName("FKcotizacion392190");

                entity.HasOne(d => d.IdProductoTransportarNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdProductoTransportar)
                    .HasConstraintName("FKcotizacion481734");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("FKcotizacion92412");

                entity.HasOne(d => d.IdTipoTractorNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdTipoTractor)
                    .HasConstraintName("FKcotizacion751603");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizacion79624");
            });

            modelBuilder.Entity<CotizacionParametros>(entity =>
            {
                entity.ToTable("cotizacionParametros");

                entity.HasComment(@"Comportamiento:
1. Cuando se configuran los parámetros en una Cotización, se copiará la versión activa del catálogo de Parámetros.
2. Si el usario cambia el valor de algún parámetro, el sistema deberá crear un nuevo registro de dicho parámetro, y poniendo active = false del anterior.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.IdCotizacion).HasColumnName("idCotizacion");

                entity.Property(e => e.IdParametroCotizacion).HasColumnName("idParametroCotizacion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCotizacionNavigation)
                    .WithMany(p => p.CotizacionParametros)
                    .HasForeignKey(d => d.IdCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizacion414639");

                entity.HasOne(d => d.IdParametroCotizacionNavigation)
                    .WithMany(p => p.CotizacionParametros)
                    .HasForeignKey(d => d.IdParametroCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcotizacion876786");
            });

            modelBuilder.Entity<DealerTelefonos>(entity =>
            {
                entity.ToTable("dealerTelefonos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EsFax).HasColumnName("esFax");

                entity.Property(e => e.EsPrincipal).HasColumnName("esPrincipal");

                entity.Property(e => e.IdPuntoEntrega).HasColumnName("idPuntoEntrega");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPuntoEntregaNavigation)
                    .WithMany(p => p.DealerTelefonos)
                    .HasForeignKey(d => d.IdPuntoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdealerTele697909");
            });

            modelBuilder.Entity<Destinos>(entity =>
            {
                entity.ToTable("destinos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.Destinos)
                    .HasForeignKey(d => d.Ciudadesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdestinos21415");
            });

            modelBuilder.Entity<DetalleRuta>(entity =>
            {
                entity.ToTable("detalleRuta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.CostoCasetas)
                    .HasColumnName("costoCasetas")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.IdRutaInnovaLinks).HasColumnName("idRutaInnovaLinks");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.RutaTipoTractorid).HasColumnName("rutaTipoTractorid");

                entity.Property(e => e.TiempoTotal).HasColumnName("tiempoTotal");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.RutaTipoTractor)
                    .WithMany(p => p.DetalleRuta)
                    .HasForeignKey(d => d.RutaTipoTractorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdetalleRut639089");
            });

            modelBuilder.Entity<DistanciasRegresos>(entity =>
            {
                entity.ToTable("distanciasRegresos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CalculadoGlobalMap)
                    .IsRequired()
                    .HasColumnName("calculadoGlobalMap")
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.CostoCasetas)
                    .HasColumnName("costoCasetas")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Destinosid).HasColumnName("destinosid");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Oficinasid).HasColumnName("oficinasid");

                entity.Property(e => e.Tiempo).HasColumnName("tiempo");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Destinos)
                    .WithMany(p => p.DistanciasRegresos)
                    .HasForeignKey(d => d.Destinosid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdistancias689127");

                entity.HasOne(d => d.Oficinas)
                    .WithMany(p => p.DistanciasRegresos)
                    .HasForeignKey(d => d.Oficinasid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdistancias579946");
            });

            modelBuilder.Entity<DocumentosCotizacion>(entity =>
            {
                entity.ToTable("documentosCotizacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdContrato).HasColumnName("idContrato");

                entity.Property(e => e.IdCotizacion).HasColumnName("idCotizacion");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaDocumento)
                    .IsRequired()
                    .HasColumnName("referenciaDocumento")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.DocumentosCotizacion)
                    .HasForeignKey(d => d.IdContrato)
                    .HasConstraintName("FKdocumentos753237");

                entity.HasOne(d => d.IdCotizacionNavigation)
                    .WithMany(p => p.DocumentosCotizacion)
                    .HasForeignKey(d => d.IdCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdocumentos583936");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.DocumentosCotizacion)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdocumentos850895");
            });

            modelBuilder.Entity<ErroresGlobalMaps>(entity =>
            {
                entity.ToTable("erroresGlobalMaps");

                entity.HasComment("Errores que se especifican al consumir servicio Global Maps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasColumnName("mensaje")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.ToTable("estados");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Countriesid).HasColumnName("countriesid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Countries)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.Countriesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKestados526887");

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.IdZona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKestados356094");
            });

            modelBuilder.Entity<EstatusCliente>(entity =>
            {
                entity.ToTable("estatusCliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<EstatusContrato>(entity =>
            {
                entity.ToTable("estatusContrato");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<EstatusCotizacion>(entity =>
            {
                entity.ToTable("estatusCotizacion");

                entity.HasComment(@"Esto solo es el catálogo:

   
id
nombre
descripción
1
inicial
Iniciada
2
datos
Datos cotización
3
parametros
Parámetros Cotizador
4
rutas
Configuración Rutas
5
cotizando
Cotizando
6
analizando
Proceso Análisis
7
enAprobDC
En Aprobación Dirección Comercial
8
aprobadaDC
Aprobada Dir Comercial
9
rechazadaDC
Rechazada Dir Comercial
10
enAprobDA
En Aprobación Director Administrativo
11
aprobadaDA
Aprobada Dir Administrativo
12
rechazadaDA
Rechazada Dir Administrativo
13
enAprobDAG
En Aprobación Dirección Administrativo y General
14
aprobadaDAG
Aprobada Dirección Administrativo y General
15
rechazadaDAG
Rechazada Dirección Administrativo y General
16
aprobDA-rechDG
Aprobada Dirección Administrativa, rechaazada Dirección General
17
rechDA-aprobDG
Rechazada Dirección Administrativa, aprobada Dirección General
18
aprobadoTC
Aprobado Transportes Cuauthémoc
19
enviado
Enviado a Cliente
20
aprobadaCliente
Aprobada Cliente
21
ajustesCliente
Solicitud ajustes por Cliente
22
rechazadaCliente
No aprobada por cliente
23
cancelada
Cancelada

Se tiene que revisar, en qué momentos se hace un duplicado de la cotización. Ejemplo: cuando el cliente la rechaza por ajustes, o cuando algún director la rechaza.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdFaseEstatusCotizacion).HasColumnName("idFaseEstatusCotizacion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdFaseEstatusCotizacionNavigation)
                    .WithMany(p => p.EstatusCotizacion)
                    .HasForeignKey(d => d.IdFaseEstatusCotizacion)
                    .HasConstraintName("FKestatusCot489359");
            });

            modelBuilder.Entity<EstatusCotizacionHistory>(entity =>
            {
                entity.ToTable("estatusCotizacionHistory");

                entity.HasComment(@"En active = true estará únicamente el estatus en el cual se encuentre la cotización

Cada vez que haya un cambio de estutus, aquí debe quedar guardado.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.IdCotizacion).HasColumnName("idCotizacion");

                entity.Property(e => e.IdEstatusCotizacion).HasColumnName("idEstatusCotizacion");

                entity.HasOne(d => d.IdCotizacionNavigation)
                    .WithMany(p => p.EstatusCotizacionHistory)
                    .HasForeignKey(d => d.IdCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKestatusCot250127");

                entity.HasOne(d => d.IdEstatusCotizacionNavigation)
                    .WithMany(p => p.EstatusCotizacionHistory)
                    .HasForeignKey(d => d.IdEstatusCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKestatusCot46594");
            });

            modelBuilder.Entity<EstructuraCostosFijos>(entity =>
            {
                entity.ToTable("estructuraCostosFijos");

                entity.HasComment("Esto es un Catálogo que se va actualizando en el tiempo.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AceitesFiltros)
                    .HasColumnName("aceitesFiltros")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Combustible)
                    .HasColumnName("combustible")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Comunicacion)
                    .HasColumnName("comunicacion")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CostoLlantasKmRecorrido)
                    .HasColumnName("costoLlantasKmRecorrido")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Depreciacion)
                    .HasColumnName("depreciacion")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DiversosGastosAdministrativos)
                    .HasColumnName("diversosGastosAdministrativos")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.DiversosGastosMantenimiento)
                    .HasColumnName("diversosGastosMantenimiento")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.DiversosGastosTransportacion)
                    .HasColumnName("diversosGastosTransportacion")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HonorariosServicios)
                    .HasColumnName("honorariosServicios")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.KmsRecorridosAnuales)
                    .HasColumnName("kmsRecorridosAnuales")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LlantasNuevas)
                    .HasColumnName("llantasNuevas")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MantenimientoEdificios)
                    .HasColumnName("mantenimientoEdificios")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PrestacionesDeLeyPersonalTaller)
                    .HasColumnName("prestacionesDeLeyPersonalTaller")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrestacionesLeyPersonalAdministrativo)
                    .HasColumnName("prestacionesLeyPersonalAdministrativo")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RefaccionesAccesorios)
                    .HasColumnName("refaccionesAccesorios")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Remuneraciones)
                    .HasColumnName("remuneraciones")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RentaInmuebles)
                    .HasColumnName("rentaInmuebles")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RentaTerminales)
                    .HasColumnName("rentaTerminales")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SeguroEquipoTransporte)
                    .HasColumnName("seguroEquipoTransporte")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.SeguroPersonalTaller)
                    .HasColumnName("seguroPersonalTaller")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TotalCostos)
                    .HasColumnName("totalCostos")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Utilidad)
                    .HasColumnName("utilidad")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<FasesEstatusCotizacion>(entity =>
            {
                entity.ToTable("fasesEstatusCotizacion");

                entity.HasComment(@"Catálogo de Fases:

   
id
nombre
descripcion
1
En Progreso
En Progreso
2
En Aprobación
En Aprobación
3
Aprobado TC
Aprobado TC
4
Enviado a Cliente
Enviado a Cliente
5
Aprobada Cliente
Aprobada Cliente
6
Ajustes por Cliente
Ajustes por Cliente
7
Rechazada por cliente
Rechazada por cliente
8
Cancelada
Cancelada
 ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<FlujoEstatusCotizacion>(entity =>
            {
                entity.ToTable("flujoEstatusCotizacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstatusActual)
                    .HasColumnName("idEstatusActual")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.IdEstatusAnterior)
                    .HasColumnName("idEstatusAnterior")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.IdEstatusSiguiente)
                    .HasColumnName("idEstatusSiguiente")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<FormaPago>(entity =>
            {
                entity.ToTable("formaPago");

                entity.HasComment(@"Totalidad
Parcialidades");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<FormulasCotizacion>(entity =>
            {
                entity.ToTable("formulasCotizacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Funcionalidad>(entity =>
            {
                entity.ToTable("funcionalidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdModulo).HasColumnName("idModulo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.Funcionalidad)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKfuncionali768258");
            });

            modelBuilder.Entity<HorasRecepcion>(entity =>
            {
                entity.ToTable("horasRecepcion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IdPuntoEntrega).HasColumnName("idPuntoEntrega");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPuntoEntregaNavigation)
                    .WithMany(p => p.HorasRecepcion)
                    .HasForeignKey(d => d.IdPuntoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKhorasRecep664464");
            });

            modelBuilder.Entity<InfoDb>(entity =>
            {
                entity.ToTable("infoDB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.ToTable("marcas");

                entity.HasComment(@"Catálogo:
Nissan
Toyota
KIA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.ToTable("metodoPago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Modulos>(entity =>
            {
                entity.ToTable("modulos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<MotivosRechazoCliente>(entity =>
            {
                entity.ToTable("motivosRechazoCliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.ToTable("municipios");

                entity.HasComment("Este catalogo se usara como el catalogo de ciudades");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Statesid).HasColumnName("statesid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.States)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.Statesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKmunicipios718870");
            });

            modelBuilder.Entity<OficinaDisponibilidad>(entity =>
            {
                entity.ToTable("oficinaDisponibilidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdOficina).HasColumnName("idOficina");

                entity.Property(e => e.IdOficinaRazonDisponibilidad).HasColumnName("idOficinaRazonDisponibilidad");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdOficinaNavigation)
                    .WithMany(p => p.OficinaDisponibilidad)
                    .HasForeignKey(d => d.IdOficina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoficinaDis261038");

                entity.HasOne(d => d.IdOficinaRazonDisponibilidadNavigation)
                    .WithMany(p => p.OficinaDisponibilidad)
                    .HasForeignKey(d => d.IdOficinaRazonDisponibilidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoficinaDis402190");
            });

            modelBuilder.Entity<OficinaRazonesDisponibilidad>(entity =>
            {
                entity.ToTable("oficinaRazonesDisponibilidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oficinas>(entity =>
            {
                entity.ToTable("oficinas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Calendario).HasColumnType("datetime");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EsRegreso)
                    .IsRequired()
                    .HasColumnName("esRegreso")
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.HoraLimiteLlegada).HasColumnType("datetime");

                entity.Property(e => e.IdOficinaZam).HasColumnName("idOficinaZAM");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdOficinaZamNavigation)
                    .WithMany(p => p.Oficinas)
                    .HasForeignKey(d => d.IdOficinaZam)
                    .HasConstraintName("FKoficinas849741");
            });

            modelBuilder.Entity<OficinasOperativas>(entity =>
            {
                entity.ToTable("oficinasOperativas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Clientesid).HasColumnName("clientesid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.HoraLimiteLlegada).HasColumnType("datetime");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Oficinasid).HasColumnName("oficinasid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.Clientes)
                    .WithMany(p => p.OficinasOperativas)
                    .HasForeignKey(d => d.Clientesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoficinasOp575761");

                entity.HasOne(d => d.Oficinas)
                    .WithMany(p => p.OficinasOperativas)
                    .HasForeignKey(d => d.Oficinasid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoficinasOp780276");
            });

            modelBuilder.Entity<Origenes>(entity =>
            {
                entity.ToTable("origenes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.Origenes)
                    .HasForeignKey(d => d.Ciudadesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKorigenes676121");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.ToTable("paises");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Alpha3)
                    .IsRequired()
                    .HasColumnName("alpha3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Paradas>(entity =>
            {
                entity.ToTable("paradas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Casetas)
                    .HasColumnName("casetas")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CasetasAcum)
                    .HasColumnName("casetasAcum")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EsReparto)
                    .HasColumnName("esReparto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.KmsAcum)
                    .HasColumnName("kmsAcum")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.RutaTipoTractorid).HasColumnName("rutaTipoTractorid");

                entity.Property(e => e.TiempoTotal)
                    .HasColumnName("tiempoTotal")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TiempoTotalAcum)
                    .HasColumnName("tiempoTotalAcum")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.Paradas)
                    .HasForeignKey(d => d.Ciudadesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKparadas863694");

                entity.HasOne(d => d.RutaTipoTractor)
                    .WithMany(p => p.Paradas)
                    .HasForeignKey(d => d.RutaTipoTractorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKparadas131461");
            });

            modelBuilder.Entity<ParametrosSistema>(entity =>
            {
                entity.ToTable("parametrosSistema");

                entity.HasComment(@"Todos los parámetros de configuración
innovalinkEndPoint
innovalinkToken (Si se necesita algún token para conectarse).
tmstcEndPoint
zamEndPoint
zamToken
globalMapEndPoint
globalMapToken
emailServer
cuentaEmail
nombreEmail
passwordEmail
nombre
puerto
etc
 ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permisos>(entity =>
            {
                entity.ToTable("permisos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.IdFuncionalidad).HasColumnName("idFuncionalidad");

                entity.Property(e => e.IdPermisoRef).HasColumnName("idPermisoRef");

                entity.Property(e => e.R).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.W).HasDefaultValueSql("((0))");

                entity.Property(e => e.X).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdFuncionalidadNavigation)
                    .WithMany(p => p.Permisos)
                    .HasForeignKey(d => d.IdFuncionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpermisos193280");
            });

            modelBuilder.Entity<PreciosHistoricosRutas>(entity =>
            {
                entity.ToTable("preciosHistoricosRutas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.RutaTipoTractorid).HasColumnName("rutaTipoTractorid");

                entity.HasOne(d => d.RutaTipoTractor)
                    .WithMany(p => p.PreciosHistoricosRutas)
                    .HasForeignKey(d => d.RutaTipoTractorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpreciosHis629853");
            });

            modelBuilder.Entity<ProcesoEnvioNotificaciones>(entity =>
            {
                entity.ToTable("procesoEnvioNotificaciones");

                entity.HasComment("Tabla para controlar el envio de notificaciones según se defina");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.DiasPorVencer).HasColumnName("diasPorVencer");

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("fechaFinal")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicial)
                    .HasColumnName("fechaInicial")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAplicacion).HasColumnName("idAplicacion");

                entity.Property(e => e.IdObjeto).HasColumnName("idObjeto");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<ProductoTransportar>(entity =>
            {
                entity.ToTable("productoTransportar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Proyectos>(entity =>
            {
                entity.ToTable("proyectos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<PuntosEntrega>(entity =>
            {
                entity.ToTable("puntosEntrega");

                entity.HasComment("Esta entidad NO DEBEN DE HACERSE BORRADOS FÍSICOS. SOLO LÓGICOS!");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CalculoSeguroEspecial).HasColumnName("calculoSeguroEspecial");

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Cuenta)
                    .HasColumnName("cuenta")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCiudades).HasColumnName("idCiudades");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdTipoPuntoEntrega).HasColumnName("idTipoPuntoEntrega");

                entity.Property(e => e.KmsNegociados)
                    .HasColumnName("kmsNegociados")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("numExterior")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("numInterior")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdCiudadesNavigation)
                    .WithMany(p => p.PuntosEntrega)
                    .HasForeignKey(d => d.IdCiudades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpuntosEntr697215");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.PuntosEntrega)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpuntosEntr785313");

                entity.HasOne(d => d.IdTipoPuntoEntregaNavigation)
                    .WithMany(p => p.PuntosEntrega)
                    .HasForeignKey(d => d.IdTipoPuntoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpuntosEntr285852");
            });

            modelBuilder.Entity<RegistrosActividad>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CantidadRegistrosAfectados).HasColumnName("cantidadRegistrosAfectados");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Mensaje)
                    .HasColumnName("mensaje")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RealizaProceso).HasColumnName("realizaProceso");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.HasComment(@"Catálogo:
Estos roles, deben de ser los mismos que existan en el Active Directory.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdActiveDirectory)
                    .IsRequired()
                    .HasColumnName("idActiveDirectory")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<RolesPermisos>(entity =>
            {
                entity.HasKey(e => new { e.IdRol, e.IdPermiso })
                    .HasName("PK__rolesPer__4CED773E4A2A69DC");

                entity.ToTable("rolesPermisos");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.IdPermiso).HasColumnName("idPermiso");

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany(p => p.RolesPermisos)
                    .HasForeignKey(d => d.IdPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrolesPermi788616");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.RolesPermisos)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrolesPermi149451");
            });

            modelBuilder.Entity<RutaTipoTractor>(entity =>
            {
                entity.ToTable("rutaTipoTractor");

                entity.HasIndex(e => new { e.TiposTractorid, e.Rutasid })
                    .HasName("rutaTipoTractorUnique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rutasid).HasColumnName("rutasid");

                entity.Property(e => e.TiposTractorid).HasColumnName("tiposTractorid");

                entity.HasOne(d => d.Rutas)
                    .WithMany(p => p.RutaTipoTractor)
                    .HasForeignKey(d => d.Rutasid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrutaTipoTr519011");

                entity.HasOne(d => d.TiposTractor)
                    .WithMany(p => p.RutaTipoTractor)
                    .HasForeignKey(d => d.TiposTractorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrutaTipoTr496771");
            });

            modelBuilder.Entity<Rutas>(entity =>
            {
                entity.ToTable("rutas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.CalculadoGlobalMap)
                    .IsRequired()
                    .HasColumnName("calculadoGlobalMap")
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Destinosid).HasColumnName("destinosid");

                entity.Property(e => e.IdRutaZam).HasColumnName("idRutaZam");

                entity.Property(e => e.KmNegociados).HasColumnName("kmNegociados");

                entity.Property(e => e.Origenesid).HasColumnName("origenesid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Destinos)
                    .WithMany(p => p.Rutas)
                    .HasForeignKey(d => d.Destinosid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrutas215312");

                entity.HasOne(d => d.Origenes)
                    .WithMany(p => p.Rutas)
                    .HasForeignKey(d => d.Origenesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrutas387605");
            });

            modelBuilder.Entity<Seguros>(entity =>
            {
                entity.ToTable("seguros");

                entity.HasComment("Catálogo para almacenar informacioón de seguros por año.");

                entity.HasIndex(e => e.ModeloAnio)
                    .HasName("UQ__seguros__BBBC799795D0C253")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CostoSeguroRemolque1)
                    .HasColumnName("costoSeguroRemolque1")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CostoSeguroRemolque1UpdatedAt)
                    .HasColumnName("costoSeguroRemolque1UpdatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CostoSeguroRemolque2)
                    .HasColumnName("costoSeguroRemolque2")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CostoSeguroRemolque2UpdatedAt)
                    .HasColumnName("costoSeguroRemolque2UpdatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CostoSeguroTr)
                    .HasColumnName("costoSeguroTr")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CostoSeguroTrupdatedAt)
                    .HasColumnName("costoSeguroTRUpdatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.ModeloAnio).HasColumnName("modeloAnio");

                entity.Property(e => e.UnidadesRemolque1).HasColumnName("unidadesRemolque1");

                entity.Property(e => e.UnidadesRemolque1UpdatedAt)
                    .HasColumnName("unidadesRemolque1UpdatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UnidadesRemolque2).HasColumnName("unidadesRemolque2");

                entity.Property(e => e.UnidadesRemolque2UpdatedAt)
                    .HasColumnName("unidadesRemolque2UpdatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UnidadesTr).HasColumnName("unidadesTR");

                entity.Property(e => e.UnidadesTrupdatedAt)
                    .HasColumnName("unidadesTRUpdatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<SesionHistory>(entity =>
            {
                entity.ToTable("sesionHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            });

            modelBuilder.Entity<TarifasContratos>(entity =>
            {
                entity.ToTable("tarifasContratos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdContrato).HasColumnName("idContrato");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TarifaCalculada).HasColumnName("tarifaCalculada");

                entity.Property(e => e.TarifaFinal).HasColumnName("tarifaFinal");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.TarifasContratos)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtarifasCon47699");
            });

            modelBuilder.Entity<TemplateConfig>(entity =>
            {
                entity.ToTable("templateConfig");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.LayoutCustomizerHidden).HasColumnName("layoutCustomizerHidden");

                entity.Property(e => e.LayoutMenuPosition)
                    .IsRequired()
                    .HasColumnName("layoutMenuPosition")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LayoutVariant)
                    .IsRequired()
                    .HasColumnName("layoutVariant")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NavbarType)
                    .IsRequired()
                    .HasColumnName("navbarType")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SidebarBackgroundColor)
                    .IsRequired()
                    .HasColumnName("sidebarBackgroundColor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SidebarBackgroundImage).HasColumnName("sidebarBackgroundImage");

                entity.Property(e => e.SidebarBackgroundImageUrl)
                    .IsRequired()
                    .HasColumnName("sidebarBackgroundImageURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SidebarCollapsed).HasColumnName("sidebarCollapsed");

                entity.Property(e => e.SidebarSize)
                    .IsRequired()
                    .HasColumnName("sidebarSize")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TemplateCorreos>(entity =>
            {
                entity.ToTable("templateCorreos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Bcc)
                    .HasColumnName("bcc")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("text");

                entity.Property(e => e.Cc)
                    .HasColumnName("cc")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TipoPuntoEntrega>(entity =>
            {
                entity.ToTable("tipoPuntoEntrega");

                entity.HasComment(@"Catálogo: i.e.
Dealer
Patio
Puerto
etc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposCredito>(entity =>
            {
                entity.ToTable("tiposCredito");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DiasCredito).HasColumnName("diasCredito");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposDocumento>(entity =>
            {
                entity.ToTable("tiposDocumento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposFormula>(entity =>
            {
                entity.ToTable("tiposFormula");

                entity.HasComment(@"  
tipo_formula
desc_tipo_formula
0
SIN ASIGNAR
1
ORIGEN-DESTINO
2
CATEGORÍA-ORIGEN-DESTINO
3
RANGO DE KILÓMETROS
4
TIPO DE UNIDAD
5
CANTIDAD DE UNIDADES
6
ORIGEN-DESTINO-DEALER TIER
7
ORIGEN-DESTINO LF
10
provisional
 ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SincronizarZam).HasColumnName("sincronizarZAM");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposGirosCliente>(entity =>
            {
                entity.ToTable("tiposGirosCliente");

                entity.HasComment(@"Catálogo: i.e.
Autos
Secos (papa)
Refrigerado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposIva>(entity =>
            {
                entity.ToTable("tiposIVA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(20, 0)");
            });

            modelBuilder.Entity<TiposMoneda>(entity =>
            {
                entity.ToTable("tiposMoneda");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposPago>(entity =>
            {
                entity.ToTable("tiposPago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TiposPago)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtiposPago241392");
            });

            modelBuilder.Entity<TiposRetencion>(entity =>
            {
                entity.ToTable("tiposRetencion");

                entity.HasComment(@"Catálogo: i.e
Flete
Subtotal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposTractor>(entity =>
            {
                entity.ToTable("tiposTractor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Configuracion)
                    .IsRequired()
                    .HasColumnName("configuracion")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ejes).HasColumnName("ejes");

                entity.Property(e => e.Llantas).HasColumnName("llantas");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Ubicaciones>(entity =>
            {
                entity.ToTable("ubicaciones");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EsDealer).HasColumnName("esDealer");

                entity.Property(e => e.EsDestino).HasColumnName("esDestino");

                entity.Property(e => e.EsOrigen).HasColumnName("esOrigen");

                entity.Property(e => e.EsRegreso).HasColumnName("esRegreso");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMunicipios).HasColumnName("idMunicipios");

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasColumnName("latitud")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasColumnName("longitud")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("numExterior")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("numInterior")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdMunicipiosNavigation)
                    .WithMany(p => p.Ubicaciones)
                    .HasForeignKey(d => d.IdMunicipios)
                    .HasConstraintName("FKubicacione34004");
            });

            modelBuilder.Entity<UsosCfdi>(entity =>
            {
                entity.ToTable("usosCFDI");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasComment(@"Esta tabla se debe ir cargando confirme se hacen los primeros logins existosos con el AD.

ToDo:
Se tiene que hacer algún mecanismo posteriormente (después de fase 1), para mantener esta tabla actualizada.

ACTUALIZAR el campo Active. Siempre que haya un cambio en el catálogo.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ApellidoMaterno)
                    .HasColumnName("apellidoMaterno")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasColumnName("apellidoPaterno")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacionSesion)
                    .HasColumnName("fechaCreacionSesion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaActividadSesion)
                    .HasColumnName("fechaUltimaActividadSesion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdActiveDirectory).HasColumnName("idActiveDirectory");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("image");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SesionFechaHora)
                    .HasColumnName("sesionFechaHora")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SesionMinutos).HasColumnName("sesionMinutos");

                entity.Property(e => e.SesionToken)
                    .HasColumnName("sesionToken")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<UsuariosRoles>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.IdRol })
                    .HasName("PK__usuarios__179F515193D81894");

                entity.ToTable("usuariosRoles");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.UsuariosRoles)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKusuariosRo345412");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuariosRoles)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKusuariosRo423246");
            });

            modelBuilder.Entity<VwCiudades>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Ciudades");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasColumnName("latitud")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasColumnName("longitud")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwColonias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Colonias");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwContratos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Contratos");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ClaveContrato)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusContrato)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdCotizacion).HasColumnName("idCotizacion");

                entity.Property(e => e.IdEstatusContrato).HasColumnName("idEstatusContrato");
            });

            modelBuilder.Entity<VwCotizacionParametrosPermisos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CotizacionParametrosPermisos");

                entity.Property(e => e.Funcionalidad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdFuncionalidad).HasColumnName("idFuncionalidad");

                entity.Property(e => e.IdModulo).HasColumnName("idModulo");

                entity.Property(e => e.IdPermiso).HasColumnName("idPermiso");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Modulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCotizaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Cotizaciones");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.EstatusCotizacion)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFinServicio).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioServicio).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdContrato).HasColumnName("idContrato");

                entity.Property(e => e.IdEstatusCotizacion).HasColumnName("idEstatusCotizacion");

                entity.Property(e => e.IdEstructuraCostosFijos).HasColumnName("idEstructuraCostosFijos");

                entity.Property(e => e.IdFormulaCotizacion).HasColumnName("idFormulaCotizacion");

                entity.Property(e => e.IdParametroCotizacion).HasColumnName("idParametroCotizacion");

                entity.Property(e => e.IdProductoTransportar).HasColumnName("idProductoTransportar");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdTipoTractor).HasColumnName("idTipoTractor");

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionVersion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioTotalCotizacion).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ProductoTransportar)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RespuestaDa).HasColumnName("respuestaDA");

                entity.Property(e => e.RespuestaDg).HasColumnName("respuestaDG");

                entity.Property(e => e.TasaTiie).HasColumnName("TasaTIIE");

                entity.Property(e => e.TipoTractor)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Version)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDashBoardContratos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_DashBoardContratos");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCadena)
                    .HasColumnName("fechaCadena")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRegistros).HasColumnName("totalRegistros");
            });

            modelBuilder.Entity<VwDashBoardCotizacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_DashBoardCotizacion");

                entity.Property(e => e.AprobadaCliente).HasColumnName("Aprobada Cliente");

                entity.Property(e => e.AprobadoTransportesCuauthémoc).HasColumnName("Aprobado Transportes Cuauthémoc");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EnAprobaciónDirecciónAdministrativoYGeneral).HasColumnName("En Aprobación Dirección Administrativo y General");

                entity.Property(e => e.EnAprobaciónDirecciónComercial).HasColumnName("En Aprobación Dirección Comercial");

                entity.Property(e => e.EnAprobaciónDirectorAdministrativo).HasColumnName("En Aprobación Director Administrativo");

                entity.Property(e => e.EnviadoACliente).HasColumnName("Enviado a Cliente");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("date");

                entity.Property(e => e.NoAprobadaPorCliente).HasColumnName("No aprobada por cliente");

                entity.Property(e => e.ProcesoAnálisis).HasColumnName("Proceso Análisis");

                entity.Property(e => e.SolicitudAjustesPorCliente).HasColumnName("Solicitud ajustes por Cliente");
            });

            modelBuilder.Entity<VwDashBoardListadoCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_DashBoardListadoCliente");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NombreComercial)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDestinos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Destinos");

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadPlanta)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPlanta)
                    .HasColumnName("descripcionPlanta")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdDestino).HasColumnName("idDestino");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LatitudDestino)
                    .HasColumnName("latitudDestino")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LongitudDestino)
                    .HasColumnName("longitudDestino")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePlanta)
                    .IsRequired()
                    .HasColumnName("nombrePlanta")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("plantaId");

                entity.Property(e => e.Zona)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDocumentosContrato>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_DocumentosContrato");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ClaveContrato)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.DescripcionDocumento)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusContrato)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fechaFin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.IdContrato).HasColumnName("idContrato");

                entity.Property(e => e.IdCotizacion).HasColumnName("idCotizacion");

                entity.Property(e => e.IdDocumento).HasColumnName("idDocumento");

                entity.Property(e => e.IdEstatusContrato).HasColumnName("idEstatusContrato");

                entity.Property(e => e.NombreDocumento)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaDocumento)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<VwMaquinaEstados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_MaquinaEstados");

                entity.Property(e => e.EstadoActual)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSiguiente)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstadoActual).HasColumnName("idEstadoActual");

                entity.Property(e => e.IdEstadoSig).HasColumnName("idEstadoSig");
            });

            modelBuilder.Entity<VwObtenerCondicionesEspecialesPuntosEntrega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ObtenerCondicionesEspecialesPuntosEntrega");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCondicionEspecial).HasColumnName("idCondicionEspecial");

                entity.Property(e => e.IdPuntoEntrega).HasColumnName("idPuntoEntrega");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 0)");
            });

            modelBuilder.Entity<VwOficinasTc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_OficinasTC");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EsRegreso).HasColumnName("esRegreso");

                entity.Property(e => e.IdOficinaTc)
                    .HasColumnName("idOficinaTC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOrigenes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Origenes");

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadPlanta)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPlanta)
                    .HasColumnName("descripcionPlanta")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdOrigen).HasColumnName("idOrigen");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LatitudOrigen)
                    .HasColumnName("latitudOrigen")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LongitudOrigen)
                    .HasColumnName("longitudOrigen")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePlanta)
                    .IsRequired()
                    .HasColumnName("nombrePlanta")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlantaId).HasColumnName("plantaId");

                entity.Property(e => e.Zona)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwParadas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Paradas");

                entity.Property(e => e.CiudadPlanta)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPlanta)
                    .HasColumnName("descripcionPlanta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EsReparto).HasColumnName("esReparto");

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.IdParada).HasColumnName("idParada");

                entity.Property(e => e.LatitudParada)
                    .HasColumnName("latitudParada")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongitudParada)
                    .HasColumnName("longitudParada")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePlanta)
                    .HasColumnName("nombrePlanta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.PlantaId).HasColumnName("plantaId");

                entity.Property(e => e.Rutasid).HasColumnName("rutasid");
            });

            modelBuilder.Entity<VwParadasRutaTipoTractor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ParadasRutaTipoTractor");

                entity.Property(e => e.Casetas)
                    .HasColumnName("casetas")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CasetasAcum)
                    .HasColumnName("casetasAcum")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CiudadesId).HasColumnName("ciudadesId");

                entity.Property(e => e.CostoCasetasDetalleRuta)
                    .HasColumnName("costoCasetasDetalleRuta")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.EsReparto).HasColumnName("esReparto");

                entity.Property(e => e.IdParada).HasColumnName("idParada");

                entity.Property(e => e.IdRutaDetalle).HasColumnName("idRutaDetalle");

                entity.Property(e => e.IdRutaInnovaLinksDetalleRuta).HasColumnName("idRutaInnovaLinksDetalleRuta");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.KmsAcum)
                    .HasColumnName("kmsAcum")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.KmsDetalleRuta)
                    .HasColumnName("kmsDetalleRuta")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.RutasId).HasColumnName("rutasId");

                entity.Property(e => e.TiempoTotal)
                    .HasColumnName("tiempoTotal")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TiempoTotalAcum)
                    .HasColumnName("tiempoTotalAcum")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TiempoTotalDetalleRuta).HasColumnName("tiempoTotalDetalleRuta");

                entity.Property(e => e.TiposTractorId).HasColumnName("tiposTractorId");
            });

            modelBuilder.Entity<VwPuntosEntrega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PuntosEntrega");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(102)
                    .IsUnicode(false);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(257)
                    .IsUnicode(false);

                entity.Property(e => e.Horas)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.IdPlazaCliente).HasColumnName("idPlazaCliente");

                entity.Property(e => e.IdTipoPuntoEntrega).HasColumnName("idTipoPuntoEntrega");

                entity.Property(e => e.KmsNegociados).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(257)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.PlazaCliente)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPuntoEntrega)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRolesFuncionalidadesPermisos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_RolesFuncionalidadesPermisos");

                entity.Property(e => e.Funcionalidad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdFuncionalidad).HasColumnName("idFuncionalidad");

                entity.Property(e => e.IdModulo).HasColumnName("idModulo");

                entity.Property(e => e.IdPermiso).HasColumnName("idPermiso");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Modulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRutas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Rutas");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CostoCasetas7Ejes)
                    .HasColumnName("costoCasetas7Ejes")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CostoCasetas9Ejes).HasColumnName("costoCasetas9Ejes");

                entity.Property(e => e.DestinoCdDes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdDestino).HasColumnName("idDestino");

                entity.Property(e => e.IdOrigen).HasColumnName("idOrigen");

                entity.Property(e => e.IdRuta).HasColumnName("idRuta");

                entity.Property(e => e.Kilometros7Ejes)
                    .HasColumnName("kilometros7Ejes")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Kilometros9Ejes)
                    .HasColumnName("kilometros9Ejes")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.OrigenCdDes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoTotal7Ejes).HasColumnName("tiempoTotal7Ejes");

                entity.Property(e => e.TiempoTotal9Ejes).HasColumnName("tiempoTotal9Ejes");

                entity.Property(e => e.TiposTractorid).HasColumnName("tiposTractorid");
            });

            modelBuilder.Entity<VwUbicaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Ubicaciones");

                entity.Property(e => e.Calle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zonas>(entity =>
            {
                entity.ToTable("zonas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
