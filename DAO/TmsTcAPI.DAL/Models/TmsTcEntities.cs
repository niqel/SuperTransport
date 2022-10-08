using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TmsTcAPI.DAL.Models
{
    public partial class TmsTcEntities : DbContext
    {
        public TmsTcEntities()
        {
        }

        public TmsTcEntities(DbContextOptions<TmsTcEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<ApprovalStatus> ApprovalStatus { get; set; }
        public virtual DbSet<AreasCobranza> AreasCobranza { get; set; }
        public virtual DbSet<AutosCategorias> AutosCategorias { get; set; }
        public virtual DbSet<AutosFamilias> AutosFamilias { get; set; }
        public virtual DbSet<AutosModelos> AutosModelos { get; set; }
        public virtual DbSet<BitacoraTiposEntrada> BitacoraTiposEntrada { get; set; }
        public virtual DbSet<CAddressType> CAddressType { get; set; }
        public virtual DbSet<CEmployeeType> CEmployeeType { get; set; }
        public virtual DbSet<CEmployeeUnavailableReasonType> CEmployeeUnavailableReasonType { get; set; }
        public virtual DbSet<CNonBudgetedExpenseStatus> CNonBudgetedExpenseStatus { get; set; }
        public virtual DbSet<CNonBudgetedExpenseType> CNonBudgetedExpenseType { get; set; }
        public virtual DbSet<CPlannedExpensesType> CPlannedExpensesType { get; set; }
        public virtual DbSet<CTruckUnavailableReasonType> CTruckUnavailableReasonType { get; set; }
        public virtual DbSet<CalendarEmployee> CalendarEmployee { get; set; }
        public virtual DbSet<CalendarTruck> CalendarTruck { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<ClavesCliente> ClavesCliente { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ClientesFacturacion> ClientesFacturacion { get; set; }
        public virtual DbSet<ClientesTipoGirosCliente> ClientesTipoGirosCliente { get; set; }
        public virtual DbSet<Colonias> Colonias { get; set; }
        public virtual DbSet<CondicionesEspeciales> CondicionesEspeciales { get; set; }
        public virtual DbSet<CondicionesEspecialesPuntosEntrega> CondicionesEspecialesPuntosEntrega { get; set; }
        public virtual DbSet<ConfigZam> ConfigZam { get; set; }
        public virtual DbSet<Configuracioncorreos> Configuracioncorreos { get; set; }
        public virtual DbSet<ContactosCliente> ContactosCliente { get; set; }
        public virtual DbSet<Contratos> Contratos { get; set; }
        public virtual DbSet<DailyOperatorStatusHistory> DailyOperatorStatusHistory { get; set; }
        public virtual DbSet<DailyTruckStatusHistory> DailyTruckStatusHistory { get; set; }
        public virtual DbSet<DealerTelefonos> DealerTelefonos { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Destinos> Destinos { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<ErroresGlobalMaps> ErroresGlobalMaps { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<EstatusCliente> EstatusCliente { get; set; }
        public virtual DbSet<EstatusContrato> EstatusContrato { get; set; }
        public virtual DbSet<EstructuraCostosFijos> EstructuraCostosFijos { get; set; }
        public virtual DbSet<EvidenceNonBudgetedExpense> EvidenceNonBudgetedExpense { get; set; }
        public virtual DbSet<FactorParaCalculoFlete> FactorParaCalculoFlete { get; set; }
        public virtual DbSet<FlujoEstatusCotizacion> FlujoEstatusCotizacion { get; set; }
        public virtual DbSet<Forecast> Forecast { get; set; }
        public virtual DbSet<FormaPago> FormaPago { get; set; }
        public virtual DbSet<FormulasCotizacion> FormulasCotizacion { get; set; }
        public virtual DbSet<Funcionalidad> Funcionalidad { get; set; }
        public virtual DbSet<GastosFijosCrm> GastosFijosCrm { get; set; }
        public virtual DbSet<GeneralArea> GeneralArea { get; set; }
        public virtual DbSet<GeneralParameters> GeneralParameters { get; set; }
        public virtual DbSet<GeneralParametersHistory> GeneralParametersHistory { get; set; }
        public virtual DbSet<GeneralTipocambio> GeneralTipocambio { get; set; }
        public virtual DbSet<HorasRecepcion> HorasRecepcion { get; set; }
        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<InfoDb> InfoDb { get; set; }
        public virtual DbSet<InternalTransfer> InternalTransfer { get; set; }
        public virtual DbSet<InternalTransferHistory> InternalTransferHistory { get; set; }
        public virtual DbSet<InternalTransferTruck> InternalTransferTruck { get; set; }
        public virtual DbSet<Liquidacion> Liquidacion { get; set; }
        public virtual DbSet<LiquidacionStatus> LiquidacionStatus { get; set; }
        public virtual DbSet<LoadPlan> LoadPlan { get; set; }
        public virtual DbSet<LogLiquidaciones> LogLiquidaciones { get; set; }
        public virtual DbSet<LogSps> LogSps { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<MarketType> MarketType { get; set; }
        public virtual DbSet<MetodoPago> MetodoPago { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<MotivosRechazoCliente> MotivosRechazoCliente { get; set; }
        public virtual DbSet<MttoUnidades> MttoUnidades { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<NonBudgetedExpense> NonBudgetedExpense { get; set; }
        public virtual DbSet<OficinasTc> OficinasTc { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<OperatorLog> OperatorLog { get; set; }
        public virtual DbSet<OperatorStatus> OperatorStatus { get; set; }
        public virtual DbSet<OperatorStatusZam> OperatorStatusZam { get; set; }
        public virtual DbSet<Origenes> Origenes { get; set; }
        public virtual DbSet<Origenestmp> Origenestmp { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<ParametrosSistema> ParametrosSistema { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<PreciosHistoricosRutas> PreciosHistoricosRutas { get; set; }
        public virtual DbSet<ProcesoEnvioNotificaciones> ProcesoEnvioNotificaciones { get; set; }
        public virtual DbSet<ProductoTransportar> ProductoTransportar { get; set; }
        public virtual DbSet<Proyectos> Proyectos { get; set; }
        public virtual DbSet<PruebaDos> PruebaDos { get; set; }
        public virtual DbSet<PruebaUno> PruebaUno { get; set; }
        public virtual DbSet<PuntosEntrega> PuntosEntrega { get; set; }
        public virtual DbSet<RTripsOperator> RTripsOperator { get; set; }
        public virtual DbSet<RegistrosActividad> RegistrosActividad { get; set; }
        public virtual DbSet<Regresos> Regresos { get; set; }
        public virtual DbSet<Repartos> Repartos { get; set; }
        public virtual DbSet<Repartos20201130> Repartos20201130 { get; set; }
        public virtual DbSet<RestingPlaces> RestingPlaces { get; set; }
        public virtual DbSet<RestingPlacesSchedules> RestingPlacesSchedules { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesHistory> RolesHistory { get; set; }
        public virtual DbSet<RolesPermisos> RolesPermisos { get; set; }
        public virtual DbSet<RolesUsuarios> RolesUsuarios { get; set; }
        public virtual DbSet<RoutesHotels> RoutesHotels { get; set; }
        public virtual DbSet<Rutas> Rutas { get; set; }
        public virtual DbSet<Rutas20201130> Rutas20201130 { get; set; }
        public virtual DbSet<SuggestionStatus> SuggestionStatus { get; set; }
        public virtual DbSet<SuggestionType> SuggestionType { get; set; }
        public virtual DbSet<Suggestions> Suggestions { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<TarifasContratos> TarifasContratos { get; set; }
        public virtual DbSet<TcOperacionDiaria> TcOperacionDiaria { get; set; }
        public virtual DbSet<TemplateConfig> TemplateConfig { get; set; }
        public virtual DbSet<Templatecorreos> Templatecorreos { get; set; }
        public virtual DbSet<TipoPuntoEntrega> TipoPuntoEntrega { get; set; }
        public virtual DbSet<TiposCredito> TiposCredito { get; set; }
        public virtual DbSet<TiposDocumento> TiposDocumento { get; set; }
        public virtual DbSet<TiposGirosCliente> TiposGirosCliente { get; set; }
        public virtual DbSet<TiposIva> TiposIva { get; set; }
        public virtual DbSet<TiposMoneda> TiposMoneda { get; set; }
        public virtual DbSet<TiposPago> TiposPago { get; set; }
        public virtual DbSet<TiposRetencion> TiposRetencion { get; set; }
        public virtual DbSet<TiposTractor> TiposTractor { get; set; }
        public virtual DbSet<Towing> Towing { get; set; }
        public virtual DbSet<TraficoCliente> TraficoCliente { get; set; }
        public virtual DbSet<TraficoGuia> TraficoGuia { get; set; }
        public virtual DbSet<TripPlannedExpenses> TripPlannedExpenses { get; set; }
        public virtual DbSet<Trips> Trips { get; set; }
        public virtual DbSet<TripsLog> TripsLog { get; set; }
        public virtual DbSet<TripsStatus> TripsStatus { get; set; }
        public virtual DbSet<TripsStatusZam> TripsStatusZam { get; set; }
        public virtual DbSet<TripsType> TripsType { get; set; }
        public virtual DbSet<Truck> Truck { get; set; }
        public virtual DbSet<TruckPlanDetails> TruckPlanDetails { get; set; }
        public virtual DbSet<TruckStatus> TruckStatus { get; set; }
        public virtual DbSet<TruckStatusHistory> TruckStatusHistory { get; set; }
        public virtual DbSet<TruckType> TruckType { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
        public virtual DbSet<UsosCfdi> UsosCfdi { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<VwCiudades> VwCiudades { get; set; }
        public virtual DbSet<VwColonias> VwColonias { get; set; }
        public virtual DbSet<VwDashBoardContratos> VwDashBoardContratos { get; set; }
        public virtual DbSet<VwDashBoardCotizacion> VwDashBoardCotizacion { get; set; }
        public virtual DbSet<VwDashBoardListadoCliente> VwDashBoardListadoCliente { get; set; }
        public virtual DbSet<VwDestinos> VwDestinos { get; set; }
        public virtual DbSet<VwDocumentosContrato> VwDocumentosContrato { get; set; }
        public virtual DbSet<VwMaquinaEstados> VwMaquinaEstados { get; set; }
        public virtual DbSet<VwObtenerCondicionesEspecialesPuntosEntrega> VwObtenerCondicionesEspecialesPuntosEntrega { get; set; }
        public virtual DbSet<VwOficinasTc> VwOficinasTc { get; set; }
        public virtual DbSet<VwOrigenes> VwOrigenes { get; set; }
        public virtual DbSet<VwPlanCarga> VwPlanCarga { get; set; }
        public virtual DbSet<VwPlanCargaTrFull> VwPlanCargaTrFull { get; set; }
        public virtual DbSet<VwPlanCargaTrSemiFull> VwPlanCargaTrSemiFull { get; set; }
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
                optionsBuilder.UseSqlServer("Server=51.143.12.226;Database=TmsTCDev;User Id=softmsa; Password=Dsy-2Sa-2S5-fuA;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.ToTable("addresses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CAddressTypeid).HasColumnName("cAddressTypeid");

                entity.Property(e => e.Coloniasid).HasColumnName("coloniasid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.ExternalNumber)
                    .IsRequired()
                    .HasColumnName("externalNumber")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InternalNumber)
                    .HasColumnName("internalNumber")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode).HasColumnName("postalCode");

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnName("street")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.CAddressType)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CAddressTypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKaddresses242696");

                entity.HasOne(d => d.Colonias)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.Coloniasid)
                    .HasConstraintName("FKaddresses459365");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKaddresses917974");
            });

            modelBuilder.Entity<Answers>(entity =>
            {
                entity.ToTable("answers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Answers1).HasColumnName("answers");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.GastoNoPresupuestadoid).HasColumnName("gasto_no_presupuestadoid");
            });

            modelBuilder.Entity<ApprovalStatus>(entity =>
            {
                entity.ToTable("approval_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<AreasCobranza>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<AutosCategorias>(entity =>
            {
                entity.HasComment(@"Catálogo: i.e.
Nombre: Categoria 1
Descripción: autos chicos

Nombre: Categoria 2
Descripción: autos medianos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdLinea).HasColumnName("idLinea");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AutosCategorias)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FKAutosCateg625938");
            });

            modelBuilder.Entity<AutosFamilias>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.Nombre)
                    .IsRequired()
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
                    .HasConstraintName("FKAutosFamil737935");
            });

            modelBuilder.Entity<AutosModelos>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.Nombre)
                    .IsRequired()
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
                    .HasConstraintName("FKAutosModel346803");
            });

            modelBuilder.Entity<BitacoraTiposEntrada>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<CAddressType>(entity =>
            {
                entity.ToTable("cAddressType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<CEmployeeType>(entity =>
            {
                entity.ToTable("cEmployeeType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<CEmployeeUnavailableReasonType>(entity =>
            {
                entity.ToTable("cEmployeeUnavailableReasonType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetimeoffset(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetimeoffset(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<CNonBudgetedExpenseStatus>(entity =>
            {
                entity.ToTable("cNonBudgetedExpenseStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<CNonBudgetedExpenseType>(entity =>
            {
                entity.ToTable("cNonBudgetedExpenseType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<CPlannedExpensesType>(entity =>
            {
                entity.ToTable("cPlannedExpensesType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdZam).HasColumnName("idZam");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<CTruckUnavailableReasonType>(entity =>
            {
                entity.ToTable("cTruckUnavailableReasonType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetimeoffset(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetimeoffset(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<CalendarEmployee>(entity =>
            {
                entity.ToTable("calendarEmployee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasColumnName("available")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CEmployeeUnavailableReasonTypeid).HasColumnName("cEmployeeUnavailableReasonTypeid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetimeoffset(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.HasOne(d => d.CEmployeeUnavailableReasonType)
                    .WithMany(p => p.CalendarEmployee)
                    .HasForeignKey(d => d.CEmployeeUnavailableReasonTypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcalendarEm82810");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CalendarEmployee)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcalendarEm695726");
            });

            modelBuilder.Entity<CalendarTruck>(entity =>
            {
                entity.ToTable("calendarTruck");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasColumnName("available")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CTruckUnavailableReasonTypeid).HasColumnName("cTruckUnavailableReasonTypeid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetimeoffset(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Truckid).HasColumnName("truckid");

                entity.HasOne(d => d.CTruckUnavailableReasonType)
                    .WithMany(p => p.CalendarTruck)
                    .HasForeignKey(d => d.CTruckUnavailableReasonTypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcalendarTr961097");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.CalendarTruck)
                    .HasForeignKey(d => d.Truckid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKcalendarTr670059");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
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
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdZona).HasDefaultValueSql("((0))");

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasColumnName("latitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasColumnName("longitud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.IdZona)
                    .HasConstraintName("FKCiudades374283");

                entity.HasOne(d => d.Municipios)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.Municipiosid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKCiudades24057");
            });

            modelBuilder.Entity<ClavesCliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Alias)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AutosNuevos)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AuxiliarContable)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveCliente)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CuentaCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAreaCobranza)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EsPersonaMoral).HasColumnName("esPersonaMoral");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FrecuenciaNotificacion).HasColumnName("frecuenciaNotificacion");

                entity.Property(e => e.HoldingNombre)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IdAreaCobranza).HasColumnName("idAreaCobranza");

                entity.Property(e => e.IdClienteFacturacionPrincipal).HasColumnName("idClienteFacturacionPrincipal");

                entity.Property(e => e.IdClienteZam).HasColumnName("idClienteZam");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstatusCliente).HasColumnName("idEstatusCliente");

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.IdPlazaCliente).HasColumnName("idPlazaCliente");

                entity.Property(e => e.IdTipoCredito).HasColumnName("idTipoCredito");

                entity.Property(e => e.IdTipoGiroPrincipalCliente).HasColumnName("idTipoGiroPrincipalCliente");

                entity.Property(e => e.IdTipoIva).HasColumnName("idTipoIVA");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.IdTipoRetencion).HasColumnName("idTipoRetencion");

                entity.Property(e => e.IdUsoCfdi).HasColumnName("idUsoCFDI");

                entity.Property(e => e.NoCliente)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAreaCobranza)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComercial)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubcuentaCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdAreaCobranzaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdAreaCobranza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes994024");

                entity.HasOne(d => d.IdColoniaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdColonia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes179426");

                entity.HasOne(d => d.IdEstatusClienteNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdEstatusCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes170996");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes245327");

                entity.HasOne(d => d.IdTipoCreditoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes888970");

                entity.HasOne(d => d.IdTipoGiroPrincipalClienteNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoGiroPrincipalCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes774563");

                entity.HasOne(d => d.IdTipoIvaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoIva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes308046");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes922601");

                entity.HasOne(d => d.IdTipoRetencionNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoRetencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes881305");

                entity.HasOne(d => d.IdUsoCfdiNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdUsoCfdi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes558853");
            });

            modelBuilder.Entity<ClientesFacturacion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ApellidoMat)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPat)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdFormaPago).HasColumnName("idFormaPago");

                entity.Property(e => e.IdMetodoPago).HasColumnName("idMetodoPago");

                entity.Property(e => e.IdTipoCliente).HasColumnName("idTipoCliente");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
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
                    .HasConstraintName("FKClientesFa283250");

                entity.HasOne(d => d.IdColoniaNavigation)
                    .WithMany(p => p.ClientesFacturacion)
                    .HasForeignKey(d => d.IdColonia)
                    .HasConstraintName("FKClientesFa106902");

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.ClientesFacturacion)
                    .HasForeignKey(d => d.IdFormaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientesFa929602");

                entity.HasOne(d => d.IdMetodoPagoNavigation)
                    .WithMany(p => p.ClientesFacturacion)
                    .HasForeignKey(d => d.IdMetodoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientesFa575651");
            });

            modelBuilder.Entity<ClientesTipoGirosCliente>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoGiroCliente })
                    .HasName("PK__Clientes__5DF044B0A974D770");

                entity.ToTable("Clientes_TipoGirosCliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdTipoGiroCliente).HasColumnName("idTipoGiroCliente");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesTipoGirosCliente)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes_T242077");

                entity.HasOne(d => d.IdTipoGiroClienteNavigation)
                    .WithMany(p => p.ClientesTipoGirosCliente)
                    .HasForeignKey(d => d.IdTipoGiroCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientes_T268866");
            });

            modelBuilder.Entity<Colonias>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Codigo)
                    .IsRequired()
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
                    .HasConstraintName("FKColonias400600");
            });

            modelBuilder.Entity<CondicionesEspeciales>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
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
                    .HasName("PK__Condicio__6DC44202261952B4");

                entity.Property(e => e.IdCondicionesEspeciales).HasColumnName("idCondicionesEspeciales");

                entity.Property(e => e.IdPuntoEntrega).HasColumnName("idPuntoEntrega");

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 0)");

                entity.HasOne(d => d.IdCondicionesEspecialesNavigation)
                    .WithMany(p => p.CondicionesEspecialesPuntosEntrega)
                    .HasForeignKey(d => d.IdCondicionesEspeciales)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKCondicione27179");

                entity.HasOne(d => d.IdPuntoEntregaNavigation)
                    .WithMany(p => p.CondicionesEspecialesPuntosEntrega)
                    .HasForeignKey(d => d.IdPuntoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKCondicione289071");
            });

            modelBuilder.Entity<ConfigZam>(entity =>
            {
                entity.ToTable("ConfigZAM");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Database)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Servername)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Configuracioncorreos>(entity =>
            {
                entity.ToTable("configuracioncorreos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BPassword).HasColumnName("b_password");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.IncomingPort).HasColumnName("incoming_port");

                entity.Property(e => e.IncomingServer)
                    .IsRequired()
                    .HasColumnName("incoming_server")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OutgoingPort).HasColumnName("outgoing_port");

                entity.Property(e => e.OutgoingServer)
                    .IsRequired()
                    .HasColumnName("outgoing_server")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactosCliente>(entity =>
            {
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
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

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

                entity.Property(e => e.Puesto)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
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
                    .HasConstraintName("FKContactosC955266");
            });

            modelBuilder.Entity<Contratos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ClaveContrato)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.IdEstatusContrato).HasColumnName("idEstatusContrato");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdEstatusContratoNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.IdEstatusContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKContratos166156");
            });

            modelBuilder.Entity<DailyOperatorStatusHistory>(entity =>
            {
                entity.ToTable("dailyOperatorStatusHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.OperatorStatusid).HasColumnName("operator_statusid");

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.HasOne(d => d.OperatorStatus)
                    .WithMany(p => p.DailyOperatorStatusHistory)
                    .HasForeignKey(d => d.OperatorStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdailyOpera102263");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.DailyOperatorStatusHistory)
                    .HasForeignKey(d => d.Operatorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdailyOpera165654");
            });

            modelBuilder.Entity<DailyTruckStatusHistory>(entity =>
            {
                entity.ToTable("dailyTruckStatusHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.TruckStatusid).HasColumnName("truck_statusid");

                entity.Property(e => e.Truckid).HasColumnName("truckid");

                entity.HasOne(d => d.TruckStatus)
                    .WithMany(p => p.DailyTruckStatusHistory)
                    .HasForeignKey(d => d.TruckStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdailyTruck7937");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.DailyTruckStatusHistory)
                    .HasForeignKey(d => d.Truckid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdailyTruck573869");
            });

            modelBuilder.Entity<DealerTelefonos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPuntoEntrega).HasColumnName("idPuntoEntrega");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPuntoEntregaNavigation)
                    .WithMany(p => p.DealerTelefonos)
                    .HasForeignKey(d => d.IdPuntoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKDealerTele754107");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("departamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
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

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.Destinos)
                    .HasForeignKey(d => d.Ciudadesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdestinos665607");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BirthPlace)
                    .HasColumnName("birthPlace")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date");

                entity.Property(e => e.CEmployeeTypeid).HasColumnName("cEmployeeTypeid");

                entity.Property(e => e.CompensationIncluded).HasColumnName("compensationIncluded");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Curp)
                    .HasColumnName("curp")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DailyIntegratedSalary).HasColumnName("dailyIntegratedSalary");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyPhone)
                    .HasColumnName("emergencyPhone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.FatherName)
                    .HasColumnName("fatherName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasColumnName("genre")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GivenName)
                    .IsRequired()
                    .HasColumnName("given_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HiringDate)
                    .HasColumnName("hiringDate")
                    .HasColumnType("date");

                entity.Property(e => e.HoldDiscountPercentage).HasColumnName("holdDiscountPercentage");

                entity.Property(e => e.IaveCardNumber).HasColumnName("iaveCardNumber");

                entity.Property(e => e.Imss)
                    .HasColumnName("imss")
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasColumnName("maritalStatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaternalSurname)
                    .IsRequired()
                    .HasColumnName("maternal_surname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumSalaryQuantity).HasColumnName("minimumSalaryQuantity");

                entity.Property(e => e.MotherName)
                    .HasColumnName("motherName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NumEmpleyeeZam).HasColumnName("num_empleyee_zam");

                entity.Property(e => e.PaternalSurname)
                    .IsRequired()
                    .HasColumnName("paternal_surname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pensionpercentage).HasColumnName("pensionpercentage");

                entity.Property(e => e.PerdiemIncluded).HasColumnName("perdiemIncluded");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.QuitDate)
                    .HasColumnName("quitDate")
                    .HasColumnType("date");

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryIncluded).HasColumnName("salaryIncluded");

                entity.Property(e => e.Sar)
                    .HasColumnName("sar")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureUrl)
                    .HasColumnName("signatureURL")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Sindicalizado).HasColumnName("sindicalizado");

                entity.Property(e => e.StaysIncluded).HasColumnName("staysIncluded");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.CEmployeeType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.CEmployeeTypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKemployee747402");
            });

            modelBuilder.Entity<ErroresGlobalMaps>(entity =>
            {
                entity.HasComment("Errores que se especifican al consumir servicio Global Maps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Codigo)
                    .IsRequired()
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
                    .HasConstraintName("FKEstados48084");

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.IdZona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKEstados513253");
            });

            modelBuilder.Entity<EstatusCliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<EstatusContrato>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<EstructuraCostosFijos>(entity =>
            {
                entity.HasComment("Esto es un Catálogo que se va actualizando en el tiempo.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Combustible).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Comunicacion).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Depreciacion).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DiversosGastosAdministrativos).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.HonorariosServicios).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MantenimientoEdificios).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Remuneraciones).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RentaInmuebles).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SeguroEquipoTransporte).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SeguroPersonalTaller).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalCostos)
                    .HasColumnName("totalCostos")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Utilidad).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<EvidenceNonBudgetedExpense>(entity =>
            {
                entity.ToTable("evidenceNonBudgetedExpense");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Guid).HasColumnName("guid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.NonBudgetedExpense)
                    .WithMany(p => p.EvidenceNonBudgetedExpense)
                    .HasForeignKey(d => d.NonBudgetedExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKevidenceNo606605");
            });

            modelBuilder.Entity<FactorParaCalculoFlete>(entity =>
            {
                entity.HasComment(@"Factores utilizados en el Cálculo del Precio de Flete:
Dias 26
Horas 24
SueldoOp 1.8
Proyeccion 0.2
CombustibleSinIva 1.6
PeajeSinIva 1.6
Llantas 0.75
RefaccionesAccesorios 1.7
CalcularPrecioFlete 1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlujoEstatusCotizacion>(entity =>
            {
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

            modelBuilder.Entity<Forecast>(entity =>
            {
                entity.HasKey(e => new { e.Customer, e.Origin, e.Date, e.MarketType, e.TruckType })
                    .HasName("PK__forecast__EB734E12CABB5E07");

                entity.ToTable("forecast");

                entity.Property(e => e.Customer).HasColumnName("customer");

                entity.Property(e => e.Origin).HasColumnName("origin");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.MarketType).HasColumnName("market_type");

                entity.Property(e => e.TruckType).HasColumnName("truck_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.TrucksQuantity).HasColumnName("trucks_quantity");

                entity.Property(e => e.TrucksQuantityEdited).HasColumnName("trucks_quantity_edited");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.MarketTypeNavigation)
                    .WithMany(p => p.Forecast)
                    .HasForeignKey(d => d.MarketType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKforecast684189");

                entity.HasOne(d => d.TruckTypeNavigation)
                    .WithMany(p => p.Forecast)
                    .HasForeignKey(d => d.TruckType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKforecast394745");
            });

            modelBuilder.Entity<FormaPago>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<FormulasCotizacion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Funcionalidad>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FuncionalidadPadre).HasColumnName("funcionalidadPadre");

                entity.Property(e => e.IdModulo).HasColumnName("idModulo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
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
                    .HasConstraintName("FKFuncionali585956");
            });

            modelBuilder.Entity<GastosFijosCrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Gastos_Fijos_CRM");

                entity.Property(e => e.Abono)
                    .HasColumnName("abono")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.CMescalculo).HasColumnName("c_mescalculo");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Cta)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescRango)
                    .IsRequired()
                    .HasColumnName("desc_Rango")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");

                entity.Property(e => e.SaldoFinal)
                    .HasColumnName("saldo_final")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SaldoInicial)
                    .HasColumnName("saldo_inicial")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SaldoMes)
                    .HasColumnName("saldo_mes")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneralArea>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.ToTable("general_area");

                entity.Property(e => e.IdArea)
                    .HasColumnName("id_area")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activa)
                    .HasColumnName("activa")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Areacont).HasColumnName("areacont");

                entity.Property(e => e.Auxiliar1)
                    .HasColumnName("auxiliar1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConsecutivoPoliza).HasColumnName("consecutivo_poliza");

                entity.Property(e => e.Cp).HasColumnName("cp");

                entity.Property(e => e.Cuenta)
                    .HasColumnName("cuenta")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EsEmpresa).HasColumnName("es_empresa");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompania).HasColumnName("id_compania");

                entity.Property(e => e.IdMultiEmpresa).HasColumnName("id_multi_empresa");

                entity.Property(e => e.IdNivel1).HasColumnName("id_nivel1");

                entity.Property(e => e.IdNivel2).HasColumnName("id_nivel2");

                entity.Property(e => e.IdNivel4).HasColumnName("id_nivel4");

                entity.Property(e => e.IdNivel5).HasColumnName("id_nivel5");

                entity.Property(e => e.IdNivel6).HasColumnName("id_nivel6");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.IdPlaza).HasColumnName("id_plaza");

                entity.Property(e => e.IdPlazaTarifa).HasColumnName("id_plaza_tarifa");

                entity.Property(e => e.IdRazon).HasColumnName("id_razon");

                entity.Property(e => e.Idcia).HasColumnName("idcia");

                entity.Property(e => e.Idsuc).HasColumnName("idsuc");

                entity.Property(e => e.Liquida)
                    .HasColumnName("liquida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Montosm)
                    .HasColumnName("montosm")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrecorto)
                    .IsRequired()
                    .HasColumnName("nombrecorto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasColumnName("oficina")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Segmento)
                    .IsRequired()
                    .HasColumnName("segmento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subcuenta)
                    .HasColumnName("subcuenta")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneralParameters>(entity =>
            {
                entity.ToTable("general_parameters");

                entity.HasIndex(e => new { e.Module, e.Name })
                    .HasName("uc_module_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.Regex)
                    .IsRequired()
                    .HasColumnName("regex")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.GeneralParametersCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__general_p__creat__1F70F794");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GeneralParametersUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__general_p__updat__21594006");
            });

            modelBuilder.Entity<GeneralParametersHistory>(entity =>
            {
                entity.ToTable("general_parameters_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralParameterId).HasColumnName("general_parameter_id");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.Regex)
                    .IsRequired()
                    .HasColumnName("regex")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.GeneralParametersHistory)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__general_p__creat__261DF523");

                entity.HasOne(d => d.GeneralParameter)
                    .WithMany(p => p.GeneralParametersHistory)
                    .HasForeignKey(d => d.GeneralParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__general_p__gener__2529D0EA");
            });

            modelBuilder.Entity<GeneralTipocambio>(entity =>
            {
                entity.HasKey(e => new { e.IdFecha, e.IdModulo, e.IdBanco, e.IdTipocambio, e.IdTipomoneda });

                entity.ToTable("general_tipocambio");

                entity.Property(e => e.IdFecha)
                    .HasColumnName("id_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdModulo).HasColumnName("id_modulo");

                entity.Property(e => e.IdBanco).HasColumnName("id_banco");

                entity.Property(e => e.IdTipocambio).HasColumnName("id_tipocambio");

                entity.Property(e => e.IdTipomoneda).HasColumnName("id_tipomoneda");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<HorasRecepcion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IdPuntoEntrega).HasColumnName("idPuntoEntrega");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPuntoEntregaNavigation)
                    .WithMany(p => p.HorasRecepcion)
                    .HasForeignKey(d => d.IdPuntoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKHorasRecep632709");
            });

            modelBuilder.Entity<Hotels>(entity =>
            {
                entity.ToTable("hotels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfoDb>(entity =>
            {
                entity.ToTable("InfoDB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InternalTransfer>(entity =>
            {
                entity.ToTable("internal_transfer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.ApprovalStatusNavigation)
                    .WithMany(p => p.InternalTransfer)
                    .HasForeignKey(d => d.ApprovalStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKinternal_t965516");
            });

            modelBuilder.Entity<InternalTransferHistory>(entity =>
            {
                entity.ToTable("internal_transfer_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.InternalTransfer).HasColumnName("internal_transfer");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.ApprovalStatusNavigation)
                    .WithMany(p => p.InternalTransferHistory)
                    .HasForeignKey(d => d.ApprovalStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKinternal_t825428");

                entity.HasOne(d => d.InternalTransferNavigation)
                    .WithMany(p => p.InternalTransferHistory)
                    .HasForeignKey(d => d.InternalTransfer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKinternal_t432675");
            });

            modelBuilder.Entity<InternalTransferTruck>(entity =>
            {
                entity.ToTable("internal_transfer_truck");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Destination).HasColumnName("destination");

                entity.Property(e => e.InternalTransfer).HasColumnName("internal_transfer");

                entity.Property(e => e.Origin).HasColumnName("origin");

                entity.Property(e => e.Truck).HasColumnName("truck");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.InternalTransferNavigation)
                    .WithMany(p => p.InternalTransferTruck)
                    .HasForeignKey(d => d.InternalTransfer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKinternal_t430160");

                entity.HasOne(d => d.TruckNavigation)
                    .WithMany(p => p.InternalTransferTruck)
                    .HasForeignKey(d => d.Truck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKinternal_t552820");
            });

            modelBuilder.Entity<Liquidacion>(entity =>
            {
                entity.ToTable("liquidacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.LiquidacionStatusid).HasColumnName("liquidacionStatusid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.LiquidacionStatus)
                    .WithMany(p => p.Liquidacion)
                    .HasForeignKey(d => d.LiquidacionStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKliquidacio830873");
            });

            modelBuilder.Entity<LiquidacionStatus>(entity =>
            {
                entity.ToTable("liquidacionStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<LoadPlan>(entity =>
            {
                entity.HasKey(e => new { e.MarketType, e.Customer, e.Office, e.Date })
                    .HasName("PK__load_pla__02BC246A1AB6D135");

                entity.ToTable("load_plan");

                entity.Property(e => e.MarketType).HasColumnName("market_type");

                entity.Property(e => e.Customer).HasColumnName("customer");

                entity.Property(e => e.Office).HasColumnName("office");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.VinsLoaded).HasColumnName("vins_loaded");

                entity.Property(e => e.VinsPlanned).HasColumnName("vins_planned");

                entity.Property(e => e.VinsPositioned).HasColumnName("vins_positioned");

                entity.HasOne(d => d.MarketTypeNavigation)
                    .WithMany(p => p.LoadPlan)
                    .HasForeignKey(d => d.MarketType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKload_plan420959");
            });

            modelBuilder.Entity<LogLiquidaciones>(entity =>
            {
                entity.ToTable("logLiquidaciones");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.LiquidacionStatusid).HasColumnName("liquidacionStatusid");

                entity.Property(e => e.Liquidacionid).HasColumnName("liquidacionid");

                entity.HasOne(d => d.LiquidacionStatus)
                    .WithMany(p => p.LogLiquidaciones)
                    .HasForeignKey(d => d.LiquidacionStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKlogLiquida850031");

                entity.HasOne(d => d.Liquidacion)
                    .WithMany(p => p.LogLiquidaciones)
                    .HasForeignKey(d => d.Liquidacionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKlogLiquida12941");
            });

            modelBuilder.Entity<LogSps>(entity =>
            {
                entity.ToTable("LogSPs");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Sp)
                    .HasColumnName("SP")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<MarketType>(entity =>
            {
                entity.ToTable("market_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NameZam)
                    .HasColumnName("name_zam")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Modulos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<MttoUnidades>(entity =>
            {
                entity.HasKey(e => e.IdUnidad);

                entity.ToTable("mtto_unidades");

                entity.Property(e => e.IdUnidad)
                    .HasColumnName("id_unidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Alarmasnuevas).HasColumnName("alarmasnuevas");

                entity.Property(e => e.AnoFabricacion).HasColumnName("ano_fabricacion");

                entity.Property(e => e.Asignado)
                    .IsRequired()
                    .HasColumnName("asignado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CapacidadAliado)
                    .IsRequired()
                    .HasColumnName("capacidad_aliado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cargadovacio)
                    .IsRequired()
                    .HasColumnName("cargadovacio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CausaBaja)
                    .HasColumnName("causa_baja")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ccosto).HasColumnName("ccosto");

                entity.Property(e => e.ClasUni)
                    .HasColumnName("clas_uni")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostoCarroceria)
                    .HasColumnName("costo_carroceria")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CostoTenencia)
                    .HasColumnName("costo_tenencia")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CostoUnidad)
                    .HasColumnName("costo_unidad")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CtaConsumo)
                    .HasColumnName("cta_consumo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CtaMayor)
                    .HasColumnName("cta_mayor")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DatosGenerales)
                    .HasColumnName("datos_generales")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeducibleXdmateriales)
                    .HasColumnName("deducible_xdmateriales")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DeducibleXrobo)
                    .HasColumnName("deducible_xrobo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DerPoliza)
                    .HasColumnName("der_poliza")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DescMarcamotor)
                    .HasColumnName("desc_marcamotor")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DescProvcarroceria)
                    .HasColumnName("desc_provcarroceria")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DescProvunidad)
                    .HasColumnName("desc_provunidad")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Destino)
                    .HasColumnName("destino")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DimAltura)
                    .HasColumnName("dim_altura")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DimAncho)
                    .HasColumnName("dim_ancho")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DimLargo)
                    .HasColumnName("dim_largo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Disponibilidad)
                    .HasColumnName("disponibilidad")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DobleNoCircula).HasColumnName("doble_no_circula");

                entity.Property(e => e.EmEmail)
                    .HasColumnName("EM_email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EnPatio)
                    .HasColumnName("en_patio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EquipoOmnitracs)
                    .HasColumnName("equipo_omnitracs")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoAdquisicion)
                    .HasColumnName("estado_adquisicion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FEntradaPatio)
                    .HasColumnName("f_entrada_patio")
                    .HasColumnType("datetime");

                entity.Property(e => e.FMismapos)
                    .HasColumnName("f_mismapos")
                    .HasColumnType("datetime");

                entity.Property(e => e.FProgLlegada)
                    .HasColumnName("f_prog_llegada")
                    .HasColumnType("datetime");

                entity.Property(e => e.FRealSalida)
                    .HasColumnName("f_real_salida")
                    .HasColumnType("datetime");

                entity.Property(e => e.FStatusUnidad)
                    .HasColumnName("f_status_unidad")
                    .HasColumnType("datetime");

                entity.Property(e => e.Faset)
                    .HasColumnName("faset")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FechaAdqCarr)
                    .HasColumnName("fecha_adq_carr")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAdquisicion)
                    .HasColumnName("fecha_adquisicion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("fecha_baja")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("fecha_desde")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDisponible)
                    .HasColumnName("fecha_disponible")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("fecha_emision")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEstatus)
                    .HasColumnName("fecha_estatus")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFinGarantia)
                    .HasColumnName("fecha_fin_garantia")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("fecha_hasta")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicioCiclo)
                    .HasColumnName("fecha_inicio_ciclo")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInstalacion)
                    .HasColumnName("fecha_instalacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaKms)
                    .HasColumnName("fecha_kms")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLogistica)
                    .HasColumnName("FECHA_LOGISTICA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaServicioSig)
                    .HasColumnName("fecha_servicio_sig")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaServicioUltimo)
                    .HasColumnName("fecha_servicio_ultimo")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaRev)
                    .HasColumnName("fecha_ultima_rev")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVencePlacas)
                    .HasColumnName("fecha_vence_placas")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVenceSeguro)
                    .HasColumnName("fecha_vence_seguro")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVenceTenencia)
                    .HasColumnName("fecha_vence_tenencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVenceVerificacion)
                    .HasColumnName("fecha_vence_verificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasColumnName("forma_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hija)
                    .IsRequired()
                    .HasColumnName("hija")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HijaAsignada)
                    .IsRequired()
                    .HasColumnName("hija_asignada")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.HrsActuales)
                    .HasColumnName("hrs_actuales")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HrsAcumuladas)
                    .HasColumnName("hrs_acumuladas")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HrsAutomaticas)
                    .HasColumnName("hrs_automaticas")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HrsInicioCiclo)
                    .HasColumnName("hrs_inicio_ciclo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HrsPorDia)
                    .HasColumnName("hrs_por_dia")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HrsServicioSig)
                    .HasColumnName("hrs_servicio_sig")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HrsServicioUltimo)
                    .HasColumnName("hrs_servicio_ultimo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.IdAreaViaje).HasColumnName("id_area_viaje");

                entity.Property(e => e.IdAsignacion).HasColumnName("id_asignacion");

                entity.Property(e => e.IdCentroCosto).HasColumnName("id_centro_costo");

                entity.Property(e => e.IdCicloPreventivo)
                    .HasColumnName("id_ciclo_preventivo")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdCircuito).HasColumnName("id_circuito");

                entity.Property(e => e.IdCompania).HasColumnName("id_compania");

                entity.Property(e => e.IdDepto).HasColumnName("id_depto");

                entity.Property(e => e.IdDespachador)
                    .HasColumnName("id_despachador")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdDestinatario).HasColumnName("id_destinatario");

                entity.Property(e => e.IdDestino).HasColumnName("id_destino");

                entity.Property(e => e.IdDolly)
                    .HasColumnName("id_dolly")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstacion).HasColumnName("id_estacion");

                entity.Property(e => e.IdFlota).HasColumnName("id_flota");

                entity.Property(e => e.IdHistogramaSig).HasColumnName("id_histograma_sig");

                entity.Property(e => e.IdHistogramaUltimo).HasColumnName("id_histograma_ultimo");

                entity.Property(e => e.IdIngreso)
                    .HasColumnName("id_ingreso")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdLinearem1)
                    .HasColumnName("id_linearem1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdLinearem2)
                    .HasColumnName("id_linearem2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdLocalidaddestino).HasColumnName("id_localidaddestino");

                entity.Property(e => e.IdMacroUlt).HasColumnName("id_macro_ult");

                entity.Property(e => e.IdMarcaUnidad).HasColumnName("id_marca_unidad");

                entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");

                entity.Property(e => e.IdOperador).HasColumnName("id_operador");

                entity.Property(e => e.IdOperador2).HasColumnName("id_operador2");

                entity.Property(e => e.IdOperador3).HasColumnName("id_operador3");

                entity.Property(e => e.IdOrigen).HasColumnName("id_origen");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.IdPlazadestino).HasColumnName("id_plazadestino");

                entity.Property(e => e.IdPlazasigdestino).HasColumnName("id_plazasigdestino");

                entity.Property(e => e.IdProject).HasColumnName("id_project");

                entity.Property(e => e.IdRemitente).HasColumnName("id_remitente");

                entity.Property(e => e.IdRemolque1)
                    .HasColumnName("id_remolque1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdRemolque2)
                    .HasColumnName("id_remolque2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdRuta).HasColumnName("id_ruta");

                entity.Property(e => e.IdSector).HasColumnName("id_sector");

                entity.Property(e => e.IdServicioInicio)
                    .HasColumnName("id_servicio_inicio")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdServicioSig)
                    .HasColumnName("id_servicio_sig")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdServicioUltimo)
                    .HasColumnName("id_servicio_ultimo")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdStatusRem).HasColumnName("id_status_rem");

                entity.Property(e => e.IdSubflota).HasColumnName("id_subflota");

                entity.Property(e => e.IdTercero).HasColumnName("id_tercero");

                entity.Property(e => e.IdThermo)
                    .HasColumnName("id_thermo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoMotor).HasColumnName("id_tipo_motor");

                entity.Property(e => e.IdTipoOperacion).HasColumnName("id_tipo_operacion");

                entity.Property(e => e.IdTipoServicioUnidad).HasColumnName("id_tipo_servicio_unidad");

                entity.Property(e => e.IdTipoUnidad).HasColumnName("id_tipo_unidad");

                entity.Property(e => e.IdTransponder)
                    .HasColumnName("id_transponder")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnidadAs)
                    .HasColumnName("id_unidad_as")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idcia).HasColumnName("idcia");

                entity.Property(e => e.Iva)
                    .HasColumnName("iva")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.JefeFlota).HasColumnName("jefe_flota");

                entity.Property(e => e.KmsActuales).HasColumnName("kms_actuales");

                entity.Property(e => e.KmsAcumulados).HasColumnName("kms_acumulados");

                entity.Property(e => e.KmsArribo).HasColumnName("kms_arribo");

                entity.Property(e => e.KmsHrs)
                    .HasColumnName("kms_hrs")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KmsHrsActuales).HasColumnName("kms_hrs_actuales");

                entity.Property(e => e.KmsInicioCiclo).HasColumnName("kms_inicio_ciclo");

                entity.Property(e => e.KmsPorDia)
                    .HasColumnName("kms_por_dia")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.KmsServicioSig).HasColumnName("kms_servicio_sig");

                entity.Property(e => e.KmsServicioUltimo).HasColumnName("kms_servicio_ultimo");

                entity.Property(e => e.KmsUltimaRev).HasColumnName("kms_ultima_rev");

                entity.Property(e => e.Kmshrsinicialaparmed).HasColumnName("kmshrsinicialaparmed");

                entity.Property(e => e.LlantasExtras).HasColumnName("llantas_extras");

                entity.Property(e => e.LtsAceite)
                    .HasColumnName("lts_aceite")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LtsCombustible)
                    .HasColumnName("lts_combustible")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LtsRelleno)
                    .HasColumnName("lts_relleno")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LtsSaldocomb)
                    .HasColumnName("lts_saldocomb")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Madre)
                    .IsRequired()
                    .HasColumnName("madre")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarcaAliado)
                    .IsRequired()
                    .HasColumnName("marca_aliado")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaCapEjeDelantero)
                    .IsRequired()
                    .HasColumnName("marca_cap_eje_delantero")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaCapEjeTrasero)
                    .HasColumnName("marca_cap_eje_trasero")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaModeloTipoTransmision)
                    .IsRequired()
                    .HasColumnName("marca_modelo_tipo_transmision")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaSuspension)
                    .IsRequired()
                    .HasColumnName("marca_suspension")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Mctnumber)
                    .HasColumnName("mctnumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedidaLlanta)
                    .IsRequired()
                    .HasColumnName("medida_llanta")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Mensajesnuevos).HasColumnName("mensajesnuevos");

                entity.Property(e => e.Mismapos)
                    .HasColumnName("mismapos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloUnidad)
                    .HasColumnName("modelo_unidad")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modulo).HasColumnName("modulo");

                entity.Property(e => e.MsgPend).HasColumnName("msg_pend");

                entity.Property(e => e.Nacionalidad).HasColumnName("nacionalidad");

                entity.Property(e => e.NoCarroceria)
                    .HasColumnName("no_carroceria")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoCilindros).HasColumnName("no_cilindros");

                entity.Property(e => e.NoCircula).HasColumnName("no_circula");

                entity.Property(e => e.NoEconomico)
                    .HasColumnName("no_economico")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoFactura)
                    .HasColumnName("no_factura")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoIncisoSeguro).HasColumnName("no_inciso_seguro");

                entity.Property(e => e.NoKit)
                    .HasColumnName("no_kit")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoMedidor).HasColumnName("no_medidor");

                entity.Property(e => e.NoMotor)
                    .HasColumnName("no_motor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoOrsan)
                    .HasColumnName("no_orsan")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoPermiso).HasColumnName("no_permiso");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("no_serie")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoTarjetaLlave)
                    .HasColumnName("no_tarjeta_llave")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NoViaje).HasColumnName("no_viaje");

                entity.Property(e => e.NumSoporte)
                    .HasColumnName("num_soporte")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCarroceria)
                    .HasColumnName("obs_carroceria")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Operador)
                    .HasColumnName("operador")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasColumnName("origen")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenStatus).HasColumnName("origen_status");

                entity.Property(e => e.PesoBruto).HasColumnName("peso_bruto");

                entity.Property(e => e.PesoUnidades)
                    .HasColumnName("peso_unidades")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PlacaDer)
                    .HasColumnName("placa_der")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlacaIzq)
                    .HasColumnName("placa_izq")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Placas)
                    .HasColumnName("placas")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Poliza)
                    .HasColumnName("poliza")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PorcPagoOp1)
                    .HasColumnName("porc_pago_op1")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PorcPagoOp2)
                    .HasColumnName("porc_pago_op2")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PorcPagoOp3)
                    .HasColumnName("porc_pago_op3")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Posdate)
                    .HasColumnName("posdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Posicion)
                    .IsRequired()
                    .HasColumnName("posicion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Poslat)
                    .HasColumnName("poslat")
                    .HasColumnType("decimal(18, 7)");

                entity.Property(e => e.Poslon)
                    .HasColumnName("poslon")
                    .HasColumnType("decimal(18, 7)");

                entity.Property(e => e.PotenciaMotor)
                    .HasColumnName("potencia_motor")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaNeta)
                    .HasColumnName("prima_neta")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Procesado).HasColumnName("procesado");

                entity.Property(e => e.ProvCarroceria).HasColumnName("prov_carroceria");

                entity.Property(e => e.Proveedor)
                    .HasColumnName("proveedor")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PulgadasCubicas)
                    .HasColumnName("pulgadas_cubicas")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RFV).HasColumnName("r_f_v");

                entity.Property(e => e.Recargos)
                    .HasColumnName("recargos")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RendimientoAceite)
                    .HasColumnName("rendimiento_aceite")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RendimientoEsperado)
                    .HasColumnName("rendimiento_esperado")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Ruta)
                    .HasColumnName("ruta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoCombustible)
                    .HasColumnName("saldo_combustible")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SecuenciaInicio).HasColumnName("secuencia_inicio");

                entity.Property(e => e.SecuenciaSig).HasColumnName("secuencia_sig");

                entity.Property(e => e.SecuenciaUlt).HasColumnName("secuencia_ult");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusCaja1)
                    .HasColumnName("status_caja1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusCaja2)
                    .HasColumnName("status_caja2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusComm).HasColumnName("status_comm");

                entity.Property(e => e.StatusUnidad)
                    .HasColumnName("status_unidad")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Subcta)
                    .HasColumnName("subcta")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TarjetaCirculacion)
                    .HasColumnName("tarjeta_circulacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TarjetaLlave)
                    .HasColumnName("tarjeta_llave")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tea)
                    .HasColumnName("TEA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tercero)
                    .HasColumnName("tercero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCombustible)
                    .IsRequired()
                    .HasColumnName("tipo_combustible")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEjes)
                    .IsRequired()
                    .HasColumnName("tipo_ejes")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMedida)
                    .HasColumnName("tipo_medida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoMoneda)
                    .HasColumnName("tipo_moneda")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoMotor)
                    .HasColumnName("tipo_motor")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProgramacion)
                    .HasColumnName("tipo_programacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoSuspension)
                    .IsRequired()
                    .HasColumnName("tipo_suspension")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUnidad).HasColumnName("tipo_unidad");

                entity.Property(e => e.TipomacroUlt)
                    .HasColumnName("tipomacro_ult")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalLlantas).HasColumnName("total_llantas");

                entity.Property(e => e.UltimaTenencia)
                    .HasColumnName("ultima_tenencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.UltimoIdAreaViaje).HasColumnName("ultimo_id_area_viaje");

                entity.Property(e => e.UltimoIdAreapedido).HasColumnName("ultimo_id_areapedido");

                entity.Property(e => e.UltimoIdDestinatario).HasColumnName("ultimo_id_destinatario");

                entity.Property(e => e.UltimoIdPedido).HasColumnName("ultimo_id_pedido");

                entity.Property(e => e.UltimoIdPedidopk).HasColumnName("ultimo_id_pedidopk");

                entity.Property(e => e.UltimoNoViaje).HasColumnName("ultimo_no_viaje");

                entity.Property(e => e.UltimoPermiso)
                    .HasColumnName("ultimo_permiso")
                    .HasColumnType("datetime");

                entity.Property(e => e.UltimoRefrendo)
                    .HasColumnName("ultimo_refrendo")
                    .HasColumnType("datetime");

                entity.Property(e => e.UnidadAsignado)
                    .IsRequired()
                    .HasColumnName("unidad_asignado")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ValidaCargacomb).HasColumnName("valida_cargacomb");

                entity.Property(e => e.ValorConvenido)
                    .HasColumnName("valor_convenido")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Vehunitnum)
                    .HasColumnName("vehunitnum")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.VenceSeguro)
                    .HasColumnName("vence_seguro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Viaje)
                    .HasColumnName("viaje")
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasComment("Este catalogo se usara como el catalogo de ciudades");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Codigo)
                    .IsRequired()
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
                    .HasConstraintName("FKMunicipios568659");
            });

            modelBuilder.Entity<NonBudgetedExpense>(entity =>
            {
                entity.ToTable("nonBudgetedExpense");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.TripId).HasColumnName("tripId");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.NonBudgetedExpenseStatus)
                    .WithMany(p => p.NonBudgetedExpense)
                    .HasForeignKey(d => d.NonBudgetedExpenseStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKnonBudgete921970");

                entity.HasOne(d => d.NonBudgetedExpenseType)
                    .WithMany(p => p.NonBudgetedExpense)
                    .HasForeignKey(d => d.NonBudgetedExpenseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKnonBudgete961870");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.NonBudgetedExpense)
                    .HasForeignKey(d => d.OperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKnonBudgete958530");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.NonBudgetedExpense)
                    .HasForeignKey(d => d.TripId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKnonBudgete310091");
            });

            modelBuilder.Entity<OficinasTc>(entity =>
            {
                entity.ToTable("OficinasTC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.ToTable("operator");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.NumOperadorZam).HasColumnName("num_operador_zam");

                entity.Property(e => e.OperatorStatusid).HasColumnName("operator_statusid");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Truckid).HasColumnName("truckid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Operator)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoperator954642");

                entity.HasOne(d => d.OperatorStatus)
                    .WithMany(p => p.Operator)
                    .HasForeignKey(d => d.OperatorStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoperator964406");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.Operator)
                    .HasForeignKey(d => d.Truckid)
                    .HasConstraintName("FKoperator836166");
            });

            modelBuilder.Entity<OperatorLog>(entity =>
            {
                entity.ToTable("operator_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.OperatorStatusid).HasColumnName("operator_statusid");

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.HasOne(d => d.OperatorStatus)
                    .WithMany(p => p.OperatorLog)
                    .HasForeignKey(d => d.OperatorStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoperator_l458810");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.OperatorLog)
                    .HasForeignKey(d => d.Operatorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoperator_l190893");
            });

            modelBuilder.Entity<OperatorStatus>(entity =>
            {
                entity.ToTable("operator_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<OperatorStatusZam>(entity =>
            {
                entity.ToTable("operator_status_zam");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdStatusZam).HasColumnName("idStatusZam");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorStatusid).HasColumnName("operator_statusid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.OperatorStatus)
                    .WithMany(p => p.OperatorStatusZam)
                    .HasForeignKey(d => d.OperatorStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKoperator_s890557");
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

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.Origenes)
                    .HasForeignKey(d => d.Ciudadesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKorigenes31929");
            });

            modelBuilder.Entity<Origenestmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("origenestmp");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Alpha3)
                    .IsRequired()
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

            modelBuilder.Entity<Parameters>(entity =>
            {
                entity.ToTable("parameters");

                entity.HasComment("Catálogo para guardar las diferentes configuraciones que existe para el algoritmo de plan de viajes.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Datails)
                    .HasColumnName("datails")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParametrosSistema>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permisos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.IdFuncionalidad).HasColumnName("idFuncionalidad");

                entity.Property(e => e.IdPermisoRef).HasColumnName("idPermisoRef");

                entity.Property(e => e.R).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.W).HasDefaultValueSql("((0))");

                entity.Property(e => e.X).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PermisosCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Permisos__create__2A239031");

                entity.HasOne(d => d.IdFuncionalidadNavigation)
                    .WithMany(p => p.Permisos)
                    .HasForeignKey(d => d.IdFuncionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Permisos__idFunc__237692A2");

                entity.HasOne(d => d.IdPermisoRefNavigation)
                    .WithMany(p => p.InverseIdPermisoRefNavigation)
                    .HasForeignKey(d => d.IdPermisoRef)
                    .HasConstraintName("FK__Permisos__idPerm__283B47BF");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.PermisosUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Permisos__update__2C0BD8A3");
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
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Rutasid).HasColumnName("rutasid");

                entity.HasOne(d => d.Rutas)
                    .WithMany(p => p.PreciosHistoricosRutas)
                    .HasForeignKey(d => d.Rutasid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpreciosHis829760");
            });

            modelBuilder.Entity<ProcesoEnvioNotificaciones>(entity =>
            {
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

                entity.Property(e => e.Fechainicial)
                    .HasColumnName("fechainicial")
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
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Proyectos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<PruebaDos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pruebaDos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PruebaUno>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PuntosEntrega>(entity =>
            {
                entity.HasComment("Esta entidad NO DEBEN DE HACERSE BORRADOS FÍSICOS. SOLO LÓGICOS!");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Alias)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoPuntoEntrega).HasColumnName("idTipoPuntoEntrega");

                entity.Property(e => e.NumExterior)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.PuntosEntrega)
                    .HasForeignKey(d => d.Ciudadesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPuntosEntr680371");

                entity.HasOne(d => d.IdTipoPuntoEntregaNavigation)
                    .WithMany(p => p.PuntosEntrega)
                    .HasForeignKey(d => d.IdTipoPuntoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPuntosEntr471920");
            });

            modelBuilder.Entity<RTripsOperator>(entity =>
            {
                entity.HasKey(e => new { e.Tripsid, e.Operatorid })
                    .HasName("PK__traffic___40A8554229810920");

                entity.ToTable("rTripsOperator");

                entity.Property(e => e.Tripsid).HasColumnName("tripsid");

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.RTripsOperator)
                    .HasForeignKey(d => d.Operatorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrTripsOper565777");

                entity.HasOne(d => d.Trips)
                    .WithMany(p => p.RTripsOperator)
                    .HasForeignKey(d => d.Tripsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtripsOpera338999");
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

            modelBuilder.Entity<Regresos>(entity =>
            {
                entity.ToTable("regresos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Autopistas).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DestinoId).HasColumnName("destinoId");

                entity.Property(e => e.PorcDeCargado).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PorcDeVacio).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.RegresoId).HasColumnName("regresoId");

                entity.Property(e => e.Tiempo).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedGloblaMap)
                    .HasColumnName("updatedGloblaMap")
                    .HasDefaultValueSql("('false')");

                entity.HasOne(d => d.Destino)
                    .WithMany(p => p.Regresos)
                    .HasForeignKey(d => d.DestinoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrepartodestinos111");

                entity.HasOne(d => d.Regreso)
                    .WithMany(p => p.Regresos)
                    .HasForeignKey(d => d.RegresoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrepartosRegresos222");
            });

            modelBuilder.Entity<Repartos>(entity =>
            {
                entity.ToTable("repartos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Casetas)
                    .HasColumnName("casetas")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.CasetasAcum)
                    .HasColumnName("casetasAcum")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.KmsAcum)
                    .HasColumnName("kmsAcum")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Rutasid).HasColumnName("rutasid");

                entity.Property(e => e.TiempoTotal)
                    .HasColumnName("tiempoTotal")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TiempoTotalAcum)
                    .HasColumnName("tiempoTotalAcum")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.Repartos)
                    .HasForeignKey(d => d.Ciudadesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrepartos44581");

                entity.HasOne(d => d.Rutas)
                    .WithMany(p => p.Repartos)
                    .HasForeignKey(d => d.Rutasid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrepartos864846");
            });

            modelBuilder.Entity<Repartos20201130>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("repartos_20201130");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Casetas)
                    .HasColumnName("casetas")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.CasetasAcum)
                    .HasColumnName("casetasAcum")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.KmsAcum)
                    .HasColumnName("kmsAcum")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Rutasid).HasColumnName("rutasid");

                entity.Property(e => e.TiempoTotal)
                    .HasColumnName("tiempoTotal")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TiempoTotalAcum)
                    .HasColumnName("tiempoTotalAcum")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<RestingPlaces>(entity =>
            {
                entity.ToTable("restingPlaces");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Routesid).HasColumnName("routesid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<RestingPlacesSchedules>(entity =>
            {
                entity.ToTable("restingPlacesSchedules");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.DayOfWeek).HasColumnName("dayOfWeek");

                entity.Property(e => e.FinalTime)
                    .HasColumnName("finalTime")
                    .HasColumnType("time(0)");

                entity.Property(e => e.InitialTime)
                    .HasColumnName("initialTime")
                    .HasColumnType("time(0)");

                entity.Property(e => e.RestingPlacesid).HasColumnName("restingPlacesid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
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
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdActiveDirectory)
                    .IsRequired()
                    .HasColumnName("idActiveDirectory")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<RolesHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdActiveDirectory)
                    .IsRequired()
                    .HasColumnName("idActiveDirectory")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RolesHistory)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolesHist__creat__2C75ECF7");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolesHistory)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolesHist__roleI__2B81C8BE");
            });

            modelBuilder.Entity<RolesPermisos>(entity =>
            {
                entity.HasKey(e => new { e.IdRol, e.IdPermiso })
                    .HasName("PK__RolesPer__4CED773E556703C1");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.IdPermiso).HasColumnName("idPermiso");

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany(p => p.RolesPermisos)
                    .HasForeignKey(d => d.IdPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolesPerm__idPer__30D08DC0");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.RolesPermisos)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolesPerm__idRol__2FDC6987");
            });

            modelBuilder.Entity<RolesUsuarios>(entity =>
            {
                entity.HasKey(e => new { e.UsuariosId, e.Rolesid })
                    .HasName("PK__Usuarios__179F515146C632DA");

                entity.ToTable("roles_usuarios");

                entity.Property(e => e.UsuariosId).HasColumnName("usuariosId");

                entity.Property(e => e.Rolesid).HasColumnName("rolesid");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.RolesUsuarios)
                    .HasForeignKey(d => d.Rolesid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKUsuariosRo216449");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.RolesUsuarios)
                    .HasForeignKey(d => d.UsuariosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKUsuariosRo29870");
            });

            modelBuilder.Entity<RoutesHotels>(entity =>
            {
                entity.ToTable("routesHotels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hotelsid).HasColumnName("hotelsid");

                entity.Property(e => e.RouteId).HasColumnName("routeId");

                entity.HasOne(d => d.Hotels)
                    .WithMany(p => p.RoutesHotels)
                    .HasForeignKey(d => d.Hotelsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKroutesHote418073");
            });

            modelBuilder.Entity<Rutas>(entity =>
            {
                entity.ToTable("rutas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.CostoCasetas)
                    .HasColumnName("costoCasetas")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Destinosid).HasColumnName("destinosid");

                entity.Property(e => e.IdRutaInnovaLinks).HasColumnName("idRutaInnovaLinks");

                entity.Property(e => e.IdRutaZam).HasColumnName("idRutaZam");

                entity.Property(e => e.Kilometros).HasColumnName("kilometros");

                entity.Property(e => e.KmNegociados).HasColumnName("kmNegociados");

                entity.Property(e => e.Origenesid).HasColumnName("origenesid");

                entity.Property(e => e.TiempoTotal).HasColumnName("tiempoTotal");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedGlobalMap).HasColumnName("updatedGlobalMap");

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

            modelBuilder.Entity<Rutas20201130>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rutas_20201130");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CostoCasetas)
                    .HasColumnName("costoCasetas")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Destinosid).HasColumnName("destinosid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdRutaInnovaLinks).HasColumnName("idRutaInnovaLinks");

                entity.Property(e => e.IdRutaZam).HasColumnName("idRutaZam");

                entity.Property(e => e.Kilometros).HasColumnName("kilometros");

                entity.Property(e => e.KmNegociados).HasColumnName("kmNegociados");

                entity.Property(e => e.Origenesid).HasColumnName("origenesid");

                entity.Property(e => e.TiempoTotal).HasColumnName("tiempoTotal");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.UpdatedGlobalMap).HasColumnName("updatedGlobalMap");
            });

            modelBuilder.Entity<SuggestionStatus>(entity =>
            {
                entity.ToTable("suggestionStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<SuggestionType>(entity =>
            {
                entity.ToTable("suggestionType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<Suggestions>(entity =>
            {
                entity.ToTable("suggestions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Duid)
                    .HasColumnName("duid")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.Property(e => e.SuggestionStatusid).HasColumnName("suggestionStatusid");

                entity.Property(e => e.SuggestionTypeid).HasColumnName("suggestionTypeid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.Suggestions)
                    .HasForeignKey(d => d.Operatorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKsuggestion506680");

                entity.HasOne(d => d.SuggestionStatus)
                    .WithMany(p => p.Suggestions)
                    .HasForeignKey(d => d.SuggestionStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKsuggestion961293");

                entity.HasOne(d => d.SuggestionType)
                    .WithMany(p => p.Suggestions)
                    .HasForeignKey(d => d.SuggestionTypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKsuggestion308394");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.ToTable("survey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Questions).HasColumnName("questions");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<TarifasContratos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdContrato).HasColumnName("idContrato");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.TarifasContratos)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKTarifasCon241308");
            });

            modelBuilder.Entity<TcOperacionDiaria>(entity =>
            {
                entity.ToTable("TC_OperacionDiaria");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasMaxLength(350);

                entity.Property(e => e.Cumplido).HasColumnName("CUMPLIDO");

                entity.Property(e => e.Embarcados).HasColumnName("EMBARCADOS");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModif)
                    .HasColumnName("FECHA_MODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Oficina)
                    .HasColumnName("OFICINA")
                    .HasMaxLength(100);

                entity.Property(e => e.Posicionado).HasColumnName("POSICIONADO");

                entity.Property(e => e.ProgEmba).HasColumnName("PROG_EMBA");

                entity.Property(e => e.ProgPos).HasColumnName("PROG_POS");

                entity.Property(e => e.Programado).HasColumnName("PROGRAMADO");

                entity.Property(e => e.UsuarioAlta)
                    .HasColumnName("USUARIO_ALTA")
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioModif)
                    .HasColumnName("USUARIO_MODIF")
                    .HasMaxLength(100);

                entity.Property(e => e.Viajes).HasColumnName("VIAJES");
            });

            modelBuilder.Entity<TemplateConfig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.LayoutCustomizerHidden).HasColumnName("layout_customizer_hidden");

                entity.Property(e => e.LayoutMenuPosition)
                    .IsRequired()
                    .HasColumnName("layout_menuPosition")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LayoutVariant)
                    .IsRequired()
                    .HasColumnName("layout_variant")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NavbarType)
                    .IsRequired()
                    .HasColumnName("navbar_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SidebarBackgroundColor)
                    .IsRequired()
                    .HasColumnName("sidebar_backgroundColor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SidebarBackgroundImage).HasColumnName("sidebar_backgroundImage");

                entity.Property(e => e.SidebarBackgroundImageUrl)
                    .IsRequired()
                    .HasColumnName("sidebar_backgroundImageURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SidebarCollapsed).HasColumnName("sidebar_collapsed");

                entity.Property(e => e.SidebarSize)
                    .IsRequired()
                    .HasColumnName("sidebar_size")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Templatecorreos>(entity =>
            {
                entity.ToTable("templatecorreos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Bcc)
                    .HasColumnName("bcc")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("text");

                entity.Property(e => e.Cc)
                    .HasColumnName("cc")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<TipoPuntoEntrega>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposCredito>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposDocumento>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposGirosCliente>(entity =>
            {
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposIva>(entity =>
            {
                entity.ToTable("TiposIVA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.Valor).HasColumnType("decimal(20, 0)");
            });

            modelBuilder.Entity<TiposMoneda>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<TiposPago>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Nombre)
                    .IsRequired()
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
                    .HasConstraintName("FKTiposPago372772");
            });

            modelBuilder.Entity<TiposRetencion>(entity =>
            {
                entity.HasComment(@"Catálogo: i.e
Flete
Subtotal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposTractor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Configuracion)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Towing>(entity =>
            {
                entity.ToTable("towing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Truckid).HasColumnName("truckid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.Towing)
                    .HasForeignKey(d => d.Truckid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtowing108372");
            });

            modelBuilder.Entity<TraficoCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("trafico_cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddendaAmece).HasColumnName("addenda_amece");

                entity.Property(e => e.AreaCobranza).HasColumnName("area_cobranza");

                entity.Property(e => e.Asegurado).HasColumnName("asegurado");

                entity.Property(e => e.AuxiliarCliente)
                    .HasColumnName("auxiliar_cliente")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BitacoraLibre).HasColumnName("bitacora_libre");

                entity.Property(e => e.CalculaSeguro).HasColumnName("calcula_seguro");

                entity.Property(e => e.Cartacobroauto)
                    .HasColumnName("cartacobroauto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClienteQuePaga).HasColumnName("cliente_que_paga");

                entity.Property(e => e.ClienteScmt)
                    .IsRequired()
                    .HasColumnName("cliente_scmt")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClienteSincobro).HasColumnName("cliente_sincobro");

                entity.Property(e => e.CodigoDinet)
                    .IsRequired()
                    .HasColumnName("codigo_dinet")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comentarios)
                    .HasColumnName("comentarios")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConsecCobranza).HasColumnName("consec_cobranza");

                entity.Property(e => e.Contacto1)
                    .HasColumnName("contacto1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto2)
                    .HasColumnName("contacto2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto3)
                    .HasColumnName("contacto3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contacto4)
                    .HasColumnName("contacto4")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contacto5)
                    .HasColumnName("contacto5")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contacto6)
                    .HasColumnName("contacto6")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContribuyenteRif).HasColumnName("contribuyente_RIF");

                entity.Property(e => e.ControlarPago)
                    .HasColumnName("controlar_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("cp")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreditoActivo)
                    .IsRequired()
                    .HasColumnName("credito_activo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CteAseguradora)
                    .IsRequired()
                    .HasColumnName("cte_aseguradora")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaCliente)
                    .HasColumnName("cuenta_cliente")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CveMarca).HasColumnName("cve_marca");

                entity.Property(e => e.Dealer)
                    .IsRequired()
                    .HasColumnName("dealer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiasCredito).HasColumnName("dias_credito");

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasColumnName("domicilio")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnvioEvidenciasAuto)
                    .HasColumnName("envio_evidencias_auto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Extranjero).HasColumnName("extranjero");

                entity.Property(e => e.FactorIva)
                    .HasColumnName("factor_iva")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FactorKmscobro)
                    .HasColumnName("factor_kmscobro")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FacturaCpSinliq)
                    .HasColumnName("factura_cp_sinliq")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ferrie)
                    .HasColumnName("ferrie")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FerrieValor)
                    .HasColumnName("ferrie_valor")
                    .HasColumnType("money");

                entity.Property(e => e.HorariosRecepcion)
                    .HasColumnName("horarios_recepcion")
                    .HasMaxLength(1);

                entity.Property(e => e.HorariosRecepcion1)
                    .HasColumnName("horarios_recepcion_1")
                    .HasMaxLength(10);

                entity.Property(e => e.HorariosRecepcion2)
                    .HasColumnName("horarios_recepcion_2")
                    .HasMaxLength(10);

                entity.Property(e => e.HorariosRecepcion3)
                    .HasColumnName("horarios_recepcion_3")
                    .HasMaxLength(10);

                entity.Property(e => e.HorariosRecepcion4)
                    .HasColumnName("horarios_recepcion_4")
                    .HasMaxLength(10);

                entity.Property(e => e.HorasCarga).HasColumnName("horas_carga");

                entity.Property(e => e.HorasDescarga).HasColumnName("horas_descarga");

                entity.Property(e => e.IdAddenda).HasColumnName("id_addenda");

                entity.Property(e => e.IdClientePemex)
                    .HasColumnName("id_cliente_pemex")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdClientePerm).HasColumnName("id_cliente_perm");

                entity.Property(e => e.IdClienteplanta).HasColumnName("id_clienteplanta");

                entity.Property(e => e.IdCobrador).HasColumnName("id_cobrador");

                entity.Property(e => e.IdCompania).HasColumnName("id_compania");

                entity.Property(e => e.IdDesctofide).HasColumnName("id_desctofide");

                entity.Property(e => e.IdDesctosuterm).HasColumnName("id_desctosuterm");

                entity.Property(e => e.IdEjecutivo).HasColumnName("id_ejecutivo");

                entity.Property(e => e.IdGpocliente).HasColumnName("id_gpocliente");

                entity.Property(e => e.IdIngreso)
                    .HasColumnName("id_ingreso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdIva).HasColumnName("id_iva");

                entity.Property(e => e.IdModifico)
                    .HasColumnName("id_modifico")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlaza).HasColumnName("id_plaza");

                entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");

                entity.Property(e => e.IdSeguro).HasColumnName("id_seguro");

                entity.Property(e => e.IdTipoArmadora).HasColumnName("id_tipo_armadora");

                entity.Property(e => e.IdUsoCfdi)
                    .HasColumnName("id_uso_cfdi")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Instrucciones)
                    .HasColumnName("instrucciones")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Instrucciones1)
                    .IsRequired()
                    .HasColumnName("instrucciones1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Instrucciones2)
                    .IsRequired()
                    .HasColumnName("instrucciones2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntegranteSistemaFinanciero).HasColumnName("integrante_sistema_financiero");

                entity.Property(e => e.Jueves)
                    .HasColumnName("jueves")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Latpos)
                    .HasColumnName("latpos")
                    .HasColumnType("decimal(19, 12)");

                entity.Property(e => e.Lonpos)
                    .HasColumnName("lonpos")
                    .HasColumnType("decimal(19, 12)");

                entity.Property(e => e.Lunes)
                    .HasColumnName("lunes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Martes)
                    .HasColumnName("martes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Matriz).HasColumnName("matriz");

                entity.Property(e => e.Miercoles)
                    .HasColumnName("miercoles")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MontoAdvertencia)
                    .HasColumnName("monto_advertencia")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoAdvertenciaUsd)
                    .HasColumnName("monto_advertencia_usd")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoCredito)
                    .HasColumnName("monto_credito")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoCreditoUsd)
                    .HasColumnName("monto_credito_usd")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoManiobras)
                    .HasColumnName("monto_maniobras")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MostrarBanco)
                    .HasColumnName("mostrar_banco")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MostrarIeps)
                    .IsRequired()
                    .HasColumnName("mostrar_ieps")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrext)
                    .HasColumnName("nombrext")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nra)
                    .IsRequired()
                    .HasColumnName("nra")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliente)
                    .IsRequired()
                    .HasColumnName("num_cliente")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumClientext)
                    .HasColumnName("num_clientext")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefonos)
                    .HasColumnName("num_telefonos")
                    .HasMaxLength(250);

                entity.Property(e => e.ObservacionesCliente)
                    .HasColumnName("observaciones_cliente")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.OcultaFlete)
                    .HasColumnName("oculta_flete")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.OcultaFleteHojains)
                    .HasColumnName("oculta_flete_hojains")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Omnionline)
                    .HasColumnName("omnionline")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Pension)
                    .HasColumnName("pension")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PensionValor)
                    .HasColumnName("pension_valor")
                    .HasColumnType("money");

                entity.Property(e => e.Personafisica).HasColumnName("personafisica");

                entity.Property(e => e.PolizaSeguro)
                    .HasColumnName("poliza_seguro")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PorcDesctofide)
                    .HasColumnName("porc_desctofide")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PorcDesctosuterm)
                    .HasColumnName("porc_desctosuterm")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrNombre)
                    .HasColumnName("pr_nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Prioridad).HasColumnName("prioridad");

                entity.Property(e => e.Procesado).HasColumnName("procesado");

                entity.Property(e => e.Redondeo)
                    .IsRequired()
                    .HasColumnName("redondeo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaCliente)
                    .HasColumnName("referencia_cliente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RepetirRemision).HasColumnName("repetir_remision");

                entity.Property(e => e.ResponsableCliente)
                    .HasColumnName("responsable_cliente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RestriccionCirculacion)
                    .HasColumnName("restriccion_circulacion")
                    .HasMaxLength(1);

                entity.Property(e => e.RestriccionCirculacion1)
                    .HasColumnName("restriccion_circulacion_1")
                    .HasMaxLength(10);

                entity.Property(e => e.RestriccionCirculacion2)
                    .HasColumnName("restriccion_circulacion_2")
                    .HasMaxLength(10);

                entity.Property(e => e.RestriccionCirculacion3)
                    .HasColumnName("restriccion_circulacion_3")
                    .HasMaxLength(10);

                entity.Property(e => e.RestriccionCirculacion4)
                    .HasColumnName("restriccion_circulacion_4")
                    .HasMaxLength(10);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("rfc")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sabado)
                    .HasColumnName("sabado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SectorPrimario).HasColumnName("sector_primario");

                entity.Property(e => e.SistOrigen)
                    .HasColumnName("sist_origen")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubctaCliente)
                    .HasColumnName("subcta_cliente")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Taxis)
                    .HasColumnName("taxis")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TaxisValor)
                    .HasColumnName("taxis_valor")
                    .HasColumnType("money");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoCarga)
                    .HasColumnName("tiempo_carga")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TiempoDescarga)
                    .HasColumnName("tiempo_descarga")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoCliente)
                    .HasColumnName("tipo_cliente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCredito)
                    .HasColumnName("tipo_credito")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("tipo_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoRetencion).HasColumnName("tipo_retencion");

                entity.Property(e => e.TipoXml).HasColumnName("tipo_xml");

                entity.Property(e => e.Ubicacion1)
                    .IsRequired()
                    .HasColumnName("ubicacion1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion2)
                    .IsRequired()
                    .HasColumnName("ubicacion2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion3)
                    .IsRequired()
                    .HasColumnName("ubicacion3")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UsoGuia)
                    .HasColumnName("uso_guia")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UsoGuiaValor)
                    .HasColumnName("uso_guia_valor")
                    .HasColumnType("money");

                entity.Property(e => e.ValorPagoOperador)
                    .HasColumnName("valor_pago_operador")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Viernes)
                    .HasColumnName("viernes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TraficoGuia>(entity =>
            {
                entity.HasKey(e => new { e.IdArea, e.NoGuia });

                entity.ToTable("trafico_guia");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.NoGuia).HasColumnName("no_guia");

                entity.Property(e => e.Autopistas)
                    .HasColumnName("autopistas")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BanderaFletefracion).HasColumnName("bandera_fletefracion");

                entity.Property(e => e.Bl)
                    .HasColumnName("bl")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BloqDemora).HasColumnName("bloq_demora");

                entity.Property(e => e.Campo1)
                    .HasColumnName("campo1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo2)
                    .HasColumnName("campo2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo3)
                    .HasColumnName("campo3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo4)
                    .HasColumnName("campo4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo5)
                    .HasColumnName("campo5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo6)
                    .HasColumnName("campo6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo7)
                    .HasColumnName("campo7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo8)
                    .IsRequired()
                    .HasColumnName("campo8")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Campo9)
                    .IsRequired()
                    .HasColumnName("campo9")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CantMovguia).HasColumnName("cant_movguia");

                entity.Property(e => e.Castigo).HasColumnName("castigo");

                entity.Property(e => e.CedulaPago)
                    .IsRequired()
                    .HasColumnName("cedula_pago")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionDoc).HasColumnName("clasificacion_doc");

                entity.Property(e => e.ClavePorteador)
                    .IsRequired()
                    .HasColumnName("clave_porteador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CobroViajeKms)
                    .HasColumnName("cobro_viaje_kms")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComplementoDemora)
                    .IsRequired()
                    .HasColumnName("complemento_demora")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConducirA).HasColumnName("conducir_a");

                entity.Property(e => e.ConducirDe).HasColumnName("conducir_de");

                entity.Property(e => e.ContratoEstimacion)
                    .HasColumnName("contrato_estimacion")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContratoFechaFin)
                    .HasColumnName("contrato_fecha_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaIni)
                    .HasColumnName("contrato_fecha_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContratoNo)
                    .HasColumnName("contrato_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ControlPago)
                    .HasColumnName("control_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConvOperador)
                    .HasColumnName("conv_operador")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConvPermisionario)
                    .HasColumnName("conv_permisionario")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConvPermisionarioorigen)
                    .HasColumnName("conv_permisionarioorigen")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConvenidoTonelada)
                    .HasColumnName("convenido_tonelada")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Cpac)
                    .HasColumnName("cpac")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Cruces)
                    .HasColumnName("cruces")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DescFlete)
                    .HasColumnName("desc_flete")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Dollyplaca)
                    .HasColumnName("dollyplaca")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Entregado).HasColumnName("entregado");

                entity.Property(e => e.EntregarEn)
                    .HasColumnName("entregar_en")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.FactorCpac)
                    .HasColumnName("factor_cpac")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FactorIva)
                    .HasColumnName("factor_iva")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Facturado).HasColumnName("facturado");

                entity.Property(e => e.FechaCancelacion)
                    .HasColumnName("fecha_cancelacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaConfirmacion)
                    .HasColumnName("fecha_confirmacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaContabilizado)
                    .HasColumnName("fecha_contabilizado")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDocumentador)
                    .HasColumnName("fecha_documentador")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEntregado)
                    .HasColumnName("fecha_entregado")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFacturacion)
                    .HasColumnName("fecha_facturacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaGuia)
                    .HasColumnName("fecha_guia")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("fecha_pago")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fecha_vencimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Flete)
                    .HasColumnName("flete")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FleteBruto)
                    .HasColumnName("flete_bruto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.IdAduanal).HasColumnName("id_aduanal");

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.IdAreaFacturacion).HasColumnName("id_area_facturacion");

                entity.Property(e => e.IdAreaTrans).HasColumnName("id_area_trans");

                entity.Property(e => e.IdAreaconvenio).HasColumnName("id_areaconvenio");

                entity.Property(e => e.IdAreapagoperm).HasColumnName("id_areapagoperm");

                entity.Property(e => e.IdCausaMerma).HasColumnName("id_causa_merma");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdCompania).HasColumnName("id_compania");

                entity.Property(e => e.IdCondujo).HasColumnName("id_condujo");

                entity.Property(e => e.IdContrato).HasColumnName("id_contrato");

                entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");

                entity.Property(e => e.IdDepositoFactoraje).HasColumnName("id_deposito_factoraje");

                entity.Property(e => e.IdDestinatario).HasColumnName("id_destinatario");

                entity.Property(e => e.IdDestino).HasColumnName("id_destino");

                entity.Property(e => e.IdDolly)
                    .HasColumnName("id_dolly")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.IdFraccion).HasColumnName("id_fraccion");

                entity.Property(e => e.IdIngreso)
                    .HasColumnName("id_ingreso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdIva).HasColumnName("id_iva");

                entity.Property(e => e.IdLinearem1)
                    .HasColumnName("id_linearem1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdLinearem2)
                    .HasColumnName("id_linearem2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdModifico)
                    .IsRequired()
                    .HasColumnName("id_modifico")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdMonedaPermisionario).HasColumnName("id_moneda_permisionario");

                entity.Property(e => e.IdOperador2).HasColumnName("id_operador2");

                entity.Property(e => e.IdOrigen).HasColumnName("id_origen");

                entity.Property(e => e.IdPago).HasColumnName("id_pago");

                entity.Property(e => e.IdPersonal).HasColumnName("id_personal");

                entity.Property(e => e.IdRecibio)
                    .HasColumnName("id_recibio")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdRemitente).HasColumnName("id_remitente");

                entity.Property(e => e.IdRemolque1)
                    .HasColumnName("id_remolque1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdRemolque2)
                    .HasColumnName("id_remolque2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");

                entity.Property(e => e.IdSector).HasColumnName("id_sector");

                entity.Property(e => e.IdSeguro).HasColumnName("id_seguro");

                entity.Property(e => e.IdSerieguia).HasColumnName("id_serieguia");

                entity.Property(e => e.IdSerieguia2).HasColumnName("id_serieguia2");

                entity.Property(e => e.IdSubsector).HasColumnName("id_subsector");

                entity.Property(e => e.IdTarifa).HasColumnName("id_tarifa");

                entity.Property(e => e.IdTercero).HasColumnName("id_tercero");

                entity.Property(e => e.IdTipoFactura).HasColumnName("id_tipo_factura");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("id_tipo_moneda");

                entity.Property(e => e.IdTipoOperacion).HasColumnName("id_tipo_operacion");

                entity.Property(e => e.IdUnidad)
                    .HasColumnName("id_unidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");

                entity.Property(e => e.Ieps)
                    .HasColumnName("ieps")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Incentivo).HasColumnName("incentivo");

                entity.Property(e => e.IvaGuia)
                    .HasColumnName("iva_guia")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.KmsConvenio).HasColumnName("kms_convenio");

                entity.Property(e => e.KmsCpac).HasColumnName("kms_cpac");

                entity.Property(e => e.KmsGuia).HasColumnName("kms_guia");

                entity.Property(e => e.LocalForaneo).HasColumnName("local_foraneo");

                entity.Property(e => e.Maniobras)
                    .HasColumnName("maniobras")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("medida")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontoAplicadoCxp)
                    .HasColumnName("monto_aplicado_cxp")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoComisiontercero)
                    .HasColumnName("monto_comisiontercero")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoDescto)
                    .HasColumnName("monto_descto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoFaltante)
                    .HasColumnName("monto_faltante")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoIvadescto)
                    .HasColumnName("monto_ivadescto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoIvaflete)
                    .HasColumnName("monto_ivaflete")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoIvancargo)
                    .HasColumnName("monto_ivancargo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoIvancredito)
                    .HasColumnName("monto_ivancredito")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoMerma)
                    .HasColumnName("monto_merma")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoNcargo)
                    .HasColumnName("monto_ncargo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoNcredito)
                    .HasColumnName("monto_ncredito")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoPagado)
                    .HasColumnName("monto_pagado")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoPago)
                    .HasColumnName("monto_pago")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoRetdescto)
                    .HasColumnName("monto_retdescto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoRetencion)
                    .HasColumnName("monto_retencion")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoRetenciontercero)
                    .HasColumnName("monto_retenciontercero")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoTipoCambio)
                    .HasColumnName("monto_tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoTipoCambioDlls)
                    .HasColumnName("monto_tipo_cambio_dlls")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MotivoCancelacion)
                    .HasColumnName("motivo_cancelacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NoCarta)
                    .HasColumnName("no_carta")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NoDeposito).HasColumnName("no_deposito");

                entity.Property(e => e.NoKit)
                    .HasColumnName("no_kit")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoRemision)
                    .HasColumnName("no_remision")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoTransferencia).HasColumnName("no_transferencia");

                entity.Property(e => e.NoTransferenciaCobranza).HasColumnName("no_transferencia_cobranza");

                entity.Property(e => e.NoViaje).HasColumnName("no_viaje");

                entity.Property(e => e.NumGuia)
                    .IsRequired()
                    .HasColumnName("num_guia")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumGuiaAsignado)
                    .HasColumnName("num_guia_asignado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumGuiaIncentivo)
                    .HasColumnName("num_guia_incentivo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumGuiacancel)
                    .HasColumnName("num_guiacancel")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumOrden)
                    .HasColumnName("num_orden")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumVapor)
                    .HasColumnName("num_vapor")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContrato)
                    .IsRequired()
                    .HasColumnName("numero_contrato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRelacion)
                    .IsRequired()
                    .HasColumnName("numero_relacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranza)
                    .HasColumnName("obs_cobranza")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesArchivado)
                    .HasColumnName("observaciones_archivado")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesGuia)
                    .HasColumnName("observaciones_guia")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OrdenFact).HasColumnName("orden_fact");

                entity.Property(e => e.Otros)
                    .HasColumnName("otros")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PagoParcialidades).HasColumnName("pago_parcialidades");

                entity.Property(e => e.Pedimento)
                    .HasColumnName("pedimento")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoFacturacion).HasColumnName("periodo_facturacion");

                entity.Property(e => e.Personalnombre)
                    .HasColumnName("personalnombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PlazaEmision).HasColumnName("plaza_emision");

                entity.Property(e => e.PlazaEntregado).HasColumnName("plaza_entregado");

                entity.Property(e => e.Prestamo)
                    .IsRequired()
                    .HasColumnName("prestamo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecogerEn)
                    .HasColumnName("recoger_en")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroEstatal)
                    .IsRequired()
                    .HasColumnName("registro_estatal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rem1placa)
                    .HasColumnName("rem1placa")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rem1tipo)
                    .HasColumnName("rem1tipo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Rem2placa)
                    .HasColumnName("rem2placa")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rem2tipo)
                    .HasColumnName("rem2tipo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RevisadoMerma).HasColumnName("revisado_merma");

                entity.Property(e => e.Seguro)
                    .HasColumnName("seguro")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StatusGuia)
                    .IsRequired()
                    .HasColumnName("status_guia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusPago)
                    .HasColumnName("status_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SubtotalIeps)
                    .HasColumnName("Subtotal_ieps")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SucursalPosicion).HasColumnName("sucursal_posicion");

                entity.Property(e => e.SustituyeDocumento)
                    .HasColumnName("sustituye_documento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambioOperador)
                    .HasColumnName("tipo_cambio_operador")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoCambioPermisionario)
                    .HasColumnName("tipo_cambio_permisionario")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoCobro)
                    .IsRequired()
                    .HasColumnName("tipo_cobro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCpac).HasColumnName("tipo_cpac");

                entity.Property(e => e.TipoDetalle).HasColumnName("tipo_detalle");

                entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");

                entity.Property(e => e.TipoFacturacion)
                    .HasColumnName("tipo_facturacion")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMovimiento)
                    .HasColumnName("tipo_movimiento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrigen).HasColumnName("tipo_origen");

                entity.Property(e => e.TipoPago)
                    .IsRequired()
                    .HasColumnName("tipo_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago02).HasColumnName("tipo_pago02");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("tipo_producto")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServ)
                    .HasColumnName("tipo_serv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoViaje).HasColumnName("tipo_viaje");

                entity.Property(e => e.Tipocambioconvenio).HasColumnName("tipocambioconvenio");

                entity.Property(e => e.Unidadplaca)
                    .HasColumnName("unidadplaca")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Unidadtipo)
                    .HasColumnName("unidadtipo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ValeCarga)
                    .HasColumnName("vale_carga")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDeclarado)
                    .HasColumnName("valor_declarado")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ValorUnitario)
                    .HasColumnName("valor_unitario")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Zona)
                    .HasColumnName("zona")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TripPlannedExpenses>(entity =>
            {
                entity.ToTable("tripPlannedExpenses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CPlannedExpensesTypeid).HasColumnName("cPlannedExpensesTypeid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.IdPezam).HasColumnName("idPEZam");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issueDate")
                    .HasColumnType("date");

                entity.Property(e => e.Tripsid).HasColumnName("tripsid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.CPlannedExpensesType)
                    .WithMany(p => p.TripPlannedExpenses)
                    .HasForeignKey(d => d.CPlannedExpensesTypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtripPlanne200347");

                entity.HasOne(d => d.Trips)
                    .WithMany(p => p.TripPlannedExpenses)
                    .HasForeignKey(d => d.Tripsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtripPlanne209063");
            });

            modelBuilder.Entity<Trips>(entity =>
            {
                entity.ToTable("trips");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CartaPorte)
                    .HasColumnName("cartaPorte")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Customer).HasColumnName("customer");

                entity.Property(e => e.Destination).HasColumnName("destination");

                entity.Property(e => e.ExpectedPerformance).HasColumnName("expectedPerformance");

                entity.Property(e => e.Idtravelzam).HasColumnName("idtravelzam");

                entity.Property(e => e.Kms)
                    .HasColumnName("kms")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.LiquidacionId).HasColumnName("liquidacionId");

                entity.Property(e => e.MarketType).HasColumnName("market_type");

                entity.Property(e => e.Origin).HasColumnName("origin");

                entity.Property(e => e.RealPerformance).HasColumnName("realPerformance");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTo).HasColumnName("return_to");

                entity.Property(e => e.SetManually)
                    .IsRequired()
                    .HasColumnName("setManually")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TripsStatusid).HasColumnName("tripsStatusid");

                entity.Property(e => e.TripsTypeid).HasColumnName("tripsTypeid");

                entity.Property(e => e.Truck).HasColumnName("truck");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.VinsQuantity).HasColumnName("vinsQuantity");

                entity.HasOne(d => d.Liquidacion)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.LiquidacionId)
                    .HasConstraintName("FKtrips912857");

                entity.HasOne(d => d.MarketTypeNavigation)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.MarketType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtraffic_pl15169");

                entity.HasOne(d => d.TripsStatus)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.TripsStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKTrips421804");

                entity.HasOne(d => d.TripsType)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.TripsTypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtrips694188");

                entity.HasOne(d => d.TruckNavigation)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.Truck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtraffic_pl349031");
            });

            modelBuilder.Entity<TripsLog>(entity =>
            {
                entity.ToTable("tripsLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.TripsStatusid).HasColumnName("tripsStatusid");

                entity.Property(e => e.Tripsid).HasColumnName("tripsid");

                entity.HasOne(d => d.TripsStatus)
                    .WithMany(p => p.TripsLog)
                    .HasForeignKey(d => d.TripsStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtripsLog764582");

                entity.HasOne(d => d.Trips)
                    .WithMany(p => p.TripsLog)
                    .HasForeignKey(d => d.Tripsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtripsLog352406");
            });

            modelBuilder.Entity<TripsStatus>(entity =>
            {
                entity.ToTable("tripsStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdStatusZam).HasColumnName("id_status_zam");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<TripsStatusZam>(entity =>
            {
                entity.ToTable("tripsStatusZam");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Cartaporte).HasColumnName("cartaporte");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idzam).HasColumnName("idzam");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorStatusid).HasColumnName("operator_statusid");

                entity.Property(e => e.TripsStatusid).HasColumnName("tripsStatusid");

                entity.Property(e => e.TruckStatusid).HasColumnName("truck_statusid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.HasOne(d => d.OperatorStatus)
                    .WithMany(p => p.TripsStatusZam)
                    .HasForeignKey(d => d.OperatorStatusid)
                    .HasConstraintName("FKtravel_sta356746");

                entity.HasOne(d => d.TripsStatus)
                    .WithMany(p => p.TripsStatusZam)
                    .HasForeignKey(d => d.TripsStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtripsStatu165576");

                entity.HasOne(d => d.TruckStatus)
                    .WithMany(p => p.TripsStatusZam)
                    .HasForeignKey(d => d.TruckStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtravel_sta9760");
            });

            modelBuilder.Entity<TripsType>(entity =>
            {
                entity.ToTable("tripsType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<Truck>(entity =>
            {
                entity.ToTable("truck");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EconomicNumber)
                    .HasColumnName("economicNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EngineNumber)
                    .HasColumnName("engine_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EngineTypeId).HasColumnName("engineTypeId");

                entity.Property(e => e.ExtraTires).HasColumnName("extraTires");

                entity.Property(e => e.FuelCapacity).HasColumnName("fuelCapacity");

                entity.Property(e => e.FuelType)
                    .HasColumnName("fuelType")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HasIaveCard)
                    .HasColumnName("hasIaveCard")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HourForNextService).HasColumnName("hourForNextService");

                entity.Property(e => e.IaveCardNumber)
                    .HasColumnName("iaveCardNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IdTruckTypeZam).HasColumnName("idTruckTypeZam");

                entity.Property(e => e.InsurancePolicy)
                    .HasColumnName("insurancePolicy")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceSubsectionNumber).HasColumnName("insuranceSubsectionNumber");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("invoiceNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KmsAccumulated)
                    .HasColumnName("kmsAccumulated")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.KmsLastReview)
                    .HasColumnName("kmsLastReview")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.KmsLastService)
                    .HasColumnName("kmsLastService")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.KmsNewCicle)
                    .HasColumnName("kmsNewCicle")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.KmsNextService)
                    .HasColumnName("kmsNextService")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastCheckDate)
                    .HasColumnName("lastCheckDate")
                    .HasColumnType("date");

                entity.Property(e => e.LicensePlate)
                    .HasColumnName("license_plate")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NewCicleDate)
                    .HasColumnName("newCicleDate")
                    .HasColumnType("date");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("purchaseDate")
                    .HasColumnType("date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("registrationDate")
                    .HasColumnType("date");

                entity.Property(e => e.SellerId).HasColumnName("sellerId");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalTires).HasColumnName("totalTires");

                entity.Property(e => e.TrackingId).HasColumnName("tracking_id");

                entity.Property(e => e.TransitCard)
                    .HasColumnName("transitCard")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TruckCost)
                    .HasColumnName("truckCost")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TruckStatus).HasColumnName("truck_status");

                entity.Property(e => e.TruckType).HasColumnName("truck_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.TruckStatusNavigation)
                    .WithMany(p => p.Truck)
                    .HasForeignKey(d => d.TruckStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtruck65650");

                entity.HasOne(d => d.TruckTypeNavigation)
                    .WithMany(p => p.Truck)
                    .HasForeignKey(d => d.TruckType)
                    .HasConstraintName("FKtruck488441");
            });

            modelBuilder.Entity<TruckPlanDetails>(entity =>
            {
                entity.ToTable("truck_plan_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("arrival_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarketType).HasColumnName("market_type");

                entity.Property(e => e.OfficeAssigned).HasColumnName("office_assigned");

                entity.Property(e => e.Truckid).HasColumnName("truckid");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.TruckPlanDetails)
                    .HasForeignKey(d => d.Truckid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtruck_plan283213");
            });

            modelBuilder.Entity<TruckStatus>(entity =>
            {
                entity.ToTable("truck_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<TruckStatusHistory>(entity =>
            {
                entity.ToTable("truckStatusHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("arrivalTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarketTypeId).HasColumnName("marketTypeId");

                entity.Property(e => e.OfficeAssigned).HasColumnName("officeAssigned");

                entity.Property(e => e.PositionedDate)
                    .HasColumnName("positionedDate")
                    .HasColumnType("date");

                entity.Property(e => e.TruckId).HasColumnName("truckId");

                entity.Property(e => e.TruckStatusId).HasColumnName("truckStatusId");

                entity.HasOne(d => d.MarketType)
                    .WithMany(p => p.TruckStatusHistory)
                    .HasForeignKey(d => d.MarketTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtruckStatu719065");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.TruckStatusHistory)
                    .HasForeignKey(d => d.TruckId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtruckStatu951722");

                entity.HasOne(d => d.TruckStatus)
                    .WithMany(p => p.TruckStatusHistory)
                    .HasForeignKey(d => d.TruckStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtruckStatu197972");
            });

            modelBuilder.Entity<TruckType>(entity =>
            {
                entity.ToTable("truck_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdTruckTypeZam).HasColumnName("idTruckTypeZam");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<Ubicaciones>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Calle)
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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMunicipios).HasColumnName("idMunicipios");

                entity.Property(e => e.Latitud)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasMaxLength(32)
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

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.IdMunicipiosNavigation)
                    .WithMany(p => p.Ubicaciones)
                    .HasForeignKey(d => d.IdMunicipios)
                    .HasConstraintName("FKUbicacione303161");
            });

            modelBuilder.Entity<UsosCfdi>(entity =>
            {
                entity.ToTable("UsosCFDI");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasComment(@"Esta tabla se debe ir cargando confirme se hacen los primeros logins existosos con el AD.

ToDo:
Se tiene que hacer algún mecanismo posteriormente (después de fase 1), para mantener esta tabla actualizada.

ACTUALIZAR el campo Active. Siempre que haya un cambio en el catálogo.");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.IdActiveDirectory).HasColumnName("idActiveDirectory");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.SesionFechaHora).HasColumnType("smalldatetime");

                entity.Property(e => e.SesionToken)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKusuarios288921");
            });

            modelBuilder.Entity<VwCiudades>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Ciudades");

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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .IsRequired()
                    .HasColumnName("longitud")
                    .HasMaxLength(50)
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
                    .HasMaxLength(255)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(1)
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

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 0)");
            });

            modelBuilder.Entity<VwOficinasTc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_OficinasTC");

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(1)
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

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.IdOficinaTc)
                    .HasColumnName("idOficinaTC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.Latitude).HasColumnType("numeric(1, 1)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(1, 1)");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(1)
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
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(1)
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
                    .HasMaxLength(255)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(1)
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

                entity.Property(e => e.Zona)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPlanCarga>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PlanCarga");

                entity.Property(e => e.Arribo).HasColumnName("arribo");

                entity.Property(e => e.Cargado).HasColumnName("cargado");

                entity.Property(e => e.Cliente).HasColumnName("cliente");

                entity.Property(e => e.Demanda).HasColumnName("demanda");

                entity.Property(e => e.Faltante).HasColumnName("faltante");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Mercado).HasColumnName("mercado");

                entity.Property(e => e.Oficina).HasColumnName("oficina");

                entity.Property(e => e.Posicionado).HasColumnName("posicionado");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<VwPlanCargaTrFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PlanCargaTR_Full");

                entity.Property(e => e.Arribo).HasColumnName("arribo");

                entity.Property(e => e.Demanda).HasColumnName("demanda");

                entity.Property(e => e.Faltante).HasColumnName("faltante");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Mercado).HasColumnName("mercado");

                entity.Property(e => e.Oficina).HasColumnName("oficina");

                entity.Property(e => e.Posicionado).HasColumnName("posicionado");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<VwPlanCargaTrSemiFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PlanCargaTR_SemiFull");

                entity.Property(e => e.Arribo).HasColumnName("arribo");

                entity.Property(e => e.Demanda).HasColumnName("demanda");

                entity.Property(e => e.Faltante).HasColumnName("faltante");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Mercado).HasColumnName("mercado");

                entity.Property(e => e.Oficina).HasColumnName("oficina");

                entity.Property(e => e.Posicionado).HasColumnName("posicionado");

                entity.Property(e => e.Total).HasColumnName("total");
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
                    .IsRequired()
                    .HasMaxLength(1)
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

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdColonia).HasColumnName("idColonia");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMunicipio).HasColumnName("idMunicipio");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.IdPlazaCliente).HasColumnName("idPlazaCliente");

                entity.Property(e => e.IdPuntoEntrega).HasColumnName("idPuntoEntrega");

                entity.Property(e => e.IdTipoPuntoEntrega).HasColumnName("idTipoPuntoEntrega");

                entity.Property(e => e.IdUbicacion).HasColumnName("idUbicacion");

                entity.Property(e => e.IdZona).HasColumnName("idZona");

                entity.Property(e => e.Latitude).HasColumnType("numeric(1, 1)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(1, 1)");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(1)
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
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasMaxLength(1)
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

                entity.Property(e => e.FuncionalidadPadre).HasColumnName("funcionalidadPadre");

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

                entity.Property(e => e.CostoCasetas)
                    .HasColumnName("costoCasetas")
                    .HasColumnType("numeric(19, 2)");

                entity.Property(e => e.DestinoCdDes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdDestino).HasColumnName("idDestino");

                entity.Property(e => e.IdOrigen).HasColumnName("idOrigen");

                entity.Property(e => e.IdRuta).HasColumnName("idRuta");

                entity.Property(e => e.Kilometros).HasColumnName("kilometros");

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenCdDes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoTotal).HasColumnName("tiempoTotal");
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
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Codigo)
                    .IsRequired()
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
