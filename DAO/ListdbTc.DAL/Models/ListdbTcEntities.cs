using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ListdbTc.DAL.Models
{
    public partial class ListdbTcEntities : DbContext
    {
        public ListdbTcEntities()
        {
        }

        public ListdbTcEntities(DbContextOptions<ListdbTcEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<DespTarifaEspecial> DespTarifaEspecial { get; set; }
        public virtual DbSet<DespTarifaEspecialdet> DespTarifaEspecialdet { get; set; }
        public virtual DbSet<GastosFijosCrm> GastosFijosCrm { get; set; }
        public virtual DbSet<GastosFijosCrm20210301> GastosFijosCrm20210301 { get; set; }
        public virtual DbSet<GeneralArea> GeneralArea { get; set; }
        public virtual DbSet<GeneralTipocambio> GeneralTipocambio { get; set; }
        public virtual DbSet<MttoOrden> MttoOrden { get; set; }
        public virtual DbSet<MttoUnidades> MttoUnidades { get; set; }
        public virtual DbSet<TablaKmsRecorridoViajeCrm> TablaKmsRecorridoViajeCrm { get; set; }
        public virtual DbSet<TraficoCliente> TraficoCliente { get; set; }
        public virtual DbSet<TraficoGuia> TraficoGuia { get; set; }
        public virtual DbSet<TraficoPlaza> TraficoPlaza { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=51.143.12.226;Database=ListdbTC_pruebas;User Id=softmsa; Password=Dsy-2Sa-2S5-fuA;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DespTarifaEspecial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("desp_tarifa_especial");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdIngreso)
                    .IsRequired()
                    .HasColumnName("id_ingreso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdModifico)
                    .IsRequired()
                    .HasColumnName("id_modifico")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdTarifa).HasColumnName("id_tarifa");

                entity.Property(e => e.TipoFormula).HasColumnName("tipo_formula");
            });

            modelBuilder.Entity<DespTarifaEspecialdet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("desp_tarifa_especialdet");

                entity.Property(e => e.BaseFuel)
                    .HasColumnName("base_fuel")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CantUnidades).HasColumnName("cant_unidades");

                entity.Property(e => e.Casetas)
                    .HasColumnName("casetas")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("categoria")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dealer)
                    .HasColumnName("dealer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Factor)
                    .HasColumnName("factor")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FactorVariable)
                    .HasColumnName("factor_variable")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinVigencia)
                    .HasColumnName("fin_vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdDestino).HasColumnName("id_destino");

                entity.Property(e => e.IdFormula).HasColumnName("id_formula");

                entity.Property(e => e.IdIngreso)
                    .IsRequired()
                    .HasColumnName("id_ingreso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdModifico)
                    .IsRequired()
                    .HasColumnName("id_modifico")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdOrigen).HasColumnName("id_origen");

                entity.Property(e => e.IdTarifa).HasColumnName("id_tarifa");

                entity.Property(e => e.IdTarifadet)
                    .HasColumnName("id_tarifadet")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdTipoOperacion).HasColumnName("id_tipo_operacion");

                entity.Property(e => e.IdTipoUnidad).HasColumnName("id_tipo_unidad");

                entity.Property(e => e.IniVigencia)
                    .HasColumnName("ini_vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.KmsNegociados)
                    .HasColumnName("kms_negociados")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Maximo).HasColumnName("maximo");

                entity.Property(e => e.Minimo).HasColumnName("minimo");

                entity.Property(e => e.Seguro)
                    .HasColumnName("seguro")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TarifaConvenio).HasColumnName("tarifa_convenio");
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

                entity.Property(e => e.Subcuenta)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GastosFijosCrm20210301>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Gastos_Fijos_CRM_20210301");

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
                entity.HasNoKey();

                entity.ToTable("general_area");

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

                entity.Property(e => e.IdArea).HasColumnName("id_area");

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

            modelBuilder.Entity<GeneralTipocambio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("general_tipocambio");

                entity.Property(e => e.IdBanco).HasColumnName("id_banco");

                entity.Property(e => e.IdFecha)
                    .HasColumnName("id_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdModulo).HasColumnName("id_modulo");

                entity.Property(e => e.IdTipocambio).HasColumnName("id_tipocambio");

                entity.Property(e => e.IdTipomoneda).HasColumnName("id_tipomoneda");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<MttoOrden>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mtto_orden");

                entity.Property(e => e.AdvertenciaGarantiaComponentes)
                    .HasColumnName("advertencia_garantia_componentes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AdvertenciaGarantiaRefacciones)
                    .HasColumnName("advertencia_garantia_refacciones")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Archivo)
                    .HasColumnName("archivo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CostoManoObra)
                    .HasColumnName("costo_mano_obra")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CostoRefacciones)
                    .HasColumnName("costo_refacciones")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CostoTallerExterno)
                    .HasColumnName("costo_taller_externo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DuracionEstimada)
                    .HasColumnName("duracion_estimada")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DuracionReal)
                    .HasColumnName("duracion_real")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoFacturacion)
                    .HasColumnName("estado_facturacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Express)
                    .HasColumnName("express")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FactIdCliente).HasColumnName("fact_id_cliente");

                entity.Property(e => e.FacturaStatus).HasColumnName("factura_status");

                entity.Property(e => e.FechaCierre)
                    .HasColumnName("fecha_cierre")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEdoDoc)
                    .HasColumnName("fecha_edo_doc")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLiberacion)
                    .HasColumnName("fecha_liberacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPrometida)
                    .HasColumnName("fecha_prometida")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaServicioSig)
                    .HasColumnName("fecha_servicio_sig")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorasRazon).HasColumnName("horas_razon");

                entity.Property(e => e.HrsApertura)
                    .HasColumnName("hrs_apertura")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HrsCierre)
                    .HasColumnName("hrs_cierre")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HrsEntrada)
                    .HasColumnName("hrs_entrada")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.IdAreaFactura).HasColumnName("id_area_factura");

                entity.Property(e => e.IdAreaguia).HasColumnName("id_areaguia");

                entity.Property(e => e.IdAreaunidad).HasColumnName("id_areaunidad");

                entity.Property(e => e.IdConjunto)
                    .HasColumnName("id_conjunto")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdDeptounidad).HasColumnName("id_deptounidad");

                entity.Property(e => e.IdEntrada).HasColumnName("id_entrada");

                entity.Property(e => e.IdEvaluacionorden).HasColumnName("id_evaluacionorden");

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.IdIngreso)
                    .HasColumnName("id_ingreso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdLinea)
                    .IsRequired()
                    .HasColumnName("id_linea")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdModifico)
                    .HasColumnName("id_modifico")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IdMultiEmpresa).HasColumnName("id_multi_empresa");

                entity.Property(e => e.IdMultiEmpresaUnidad).HasColumnName("id_multi_empresa_unidad");

                entity.Property(e => e.IdOperador).HasColumnName("id_operador");

                entity.Property(e => e.IdOrden).HasColumnName("id_orden");

                entity.Property(e => e.IdRazon).HasColumnName("id_razon");

                entity.Property(e => e.IdRazonCierre).HasColumnName("id_razon_cierre");

                entity.Property(e => e.IdRecepcion).HasColumnName("id_recepcion");

                entity.Property(e => e.IdRemolque)
                    .IsRequired()
                    .HasColumnName("id_remolque")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdServicio)
                    .HasColumnName("id_servicio")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");

                entity.Property(e => e.IdSupervisoEntrada).HasColumnName("id_superviso_entrada");

                entity.Property(e => e.IdSupervisoSalida).HasColumnName("id_superviso_salida");

                entity.Property(e => e.IdTipoOperacion).HasColumnName("id_tipo_operacion");

                entity.Property(e => e.IdUnidad)
                    .IsRequired()
                    .HasColumnName("id_unidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnidadConta)
                    .HasColumnName("id_unidad_conta")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KmsEntrada).HasColumnName("kms_entrada");

                entity.Property(e => e.KmsFin).HasColumnName("kms_fin");

                entity.Property(e => e.KmsInicio).HasColumnName("kms_inicio");

                entity.Property(e => e.KmsServicioSig)
                    .HasColumnName("kms_servicio_sig")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NoGuia).HasColumnName("no_guia");

                entity.Property(e => e.NoMedidor).HasColumnName("no_medidor");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioMoFactura)
                    .HasColumnName("precio_mo_factura")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioOsteFactura)
                    .HasColumnName("precio_oste_factura")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioRefFactura)
                    .HasColumnName("precio_ref_factura")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioTotalFactura)
                    .HasColumnName("precio_total_factura")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Reliberada)
                    .HasColumnName("reliberada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Secuencia).HasColumnName("secuencia");

                entity.Property(e => e.UnidadReclamada)
                    .HasColumnName("unidad_reclamada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MttoUnidades>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mtto_unidades");

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

                entity.Property(e => e.IdUnidad)
                    .IsRequired()
                    .HasColumnName("id_unidad")
                    .HasMaxLength(10)
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

            modelBuilder.Entity<TablaKmsRecorridoViajeCrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabla_Kms_Recorrido_Viaje_CRM");

                entity.Property(e => e.KmsRecorridoxViaje).HasColumnType("decimal(19, 2)");
            });

            modelBuilder.Entity<TraficoCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trafico_cliente");

                entity.Property(e => e.AddendaAmece).HasColumnName("addenda_amece");

                entity.Property(e => e.AreaCobranza).HasColumnName("area_cobranza");

                entity.Property(e => e.Asegurado).HasColumnName("asegurado");

                entity.Property(e => e.AuxiliarCliente)
                    .HasColumnName("auxiliar_cliente")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BitacoraLibre).HasColumnName("bitacora_libre");

                entity.Property(e => e.CalculaSeguro).HasColumnName("calcula_seguro");

                entity.Property(e => e.Cartacobroauto).HasColumnName("cartacobroauto");

                entity.Property(e => e.ClienteQuePaga).HasColumnName("cliente_que_paga");

                entity.Property(e => e.ClienteScmt)
                    .IsRequired()
                    .HasColumnName("cliente_scmt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

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
                    .IsUnicode(false);

                entity.Property(e => e.Contacto4)
                    .HasColumnName("contacto4")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto5)
                    .HasColumnName("contacto5")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto6)
                    .HasColumnName("contacto6")
                    .HasMaxLength(80)
                    .IsUnicode(false);

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

                entity.Property(e => e.EnvioEvidenciasAuto).HasColumnName("envio_evidencias_auto");

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

                entity.Property(e => e.FacturaCpSinliq).HasColumnName("factura_cp_sinliq");

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
                    .HasMaxLength(1);

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

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdClientePemex).HasColumnName("id_cliente_pemex");

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

                entity.Property(e => e.IdUsoCfdi).HasColumnName("id_uso_cfdi");

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
                    .IsFixedLength();

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
                    .IsFixedLength();

                entity.Property(e => e.OcultaFleteHojains)
                    .HasColumnName("oculta_flete_hojains")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Omnionline)
                    .HasColumnName("omnionline")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Pension)
                    .HasColumnName("pension")
                    .HasMaxLength(1);

                entity.Property(e => e.PensionValor)
                    .HasColumnName("pension_valor")
                    .HasColumnType("money");

                entity.Property(e => e.Personafisica).HasColumnName("personafisica");

                entity.Property(e => e.PolizaSeguro)
                    .HasColumnName("poliza_seguro")
                    .HasMaxLength(40)
                    .IsUnicode(false);

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

                entity.Property(e => e.ReferenciaCliente).HasColumnName("referencia_cliente");

                entity.Property(e => e.RepetirRemision).HasColumnName("repetir_remision");

                entity.Property(e => e.ResponsableCliente).HasColumnName("responsable_cliente");

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
                    .HasMaxLength(1);

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
                    .HasMaxLength(1);

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
                entity.HasNoKey();

                entity.ToTable("trafico_guia");

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

                entity.Property(e => e.IdArea).HasColumnName("id_area");

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

                entity.Property(e => e.NoGuia).HasColumnName("no_guia");

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

            modelBuilder.Entity<TraficoPlaza>(entity =>
            {
                entity.HasKey(e => e.IdPlaza);

                entity.ToTable("trafico_plaza");

                entity.Property(e => e.IdPlaza)
                    .HasColumnName("id_plaza")
                    .ValueGeneratedNever();

                entity.Property(e => e.Base).HasColumnName("base");

                entity.Property(e => e.Cell)
                    .HasColumnName("cell")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cuenta)
                    .HasColumnName("cuenta")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DescPlaza)
                    .IsRequired()
                    .HasColumnName("desc_plaza")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DieselAdicional)
                    .HasColumnName("diesel_adicional")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPlazaMatriz).HasColumnName("id_plaza_matriz");

                entity.Property(e => e.IdZona).HasColumnName("id_zona");

                entity.Property(e => e.Importacion).HasColumnName("importacion");

                entity.Property(e => e.Matriz)
                    .IsRequired()
                    .HasColumnName("matriz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nacional).HasColumnName("nacional");

                entity.Property(e => e.Nombrext)
                    .HasColumnName("nombrext")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NumPlaza)
                    .IsRequired()
                    .HasColumnName("num_plaza")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumPlazaext)
                    .HasColumnName("num_plazaext")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OnuCd)
                    .HasColumnName("ONU_CD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OnuEdo)
                    .HasColumnName("ONU_EDO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OnuPais)
                    .HasColumnName("ONU_PAIS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Procesado).HasColumnName("procesado");

                entity.Property(e => e.RadioGeocerca).HasColumnName("radio_geocerca");

                entity.Property(e => e.RegresoAutomatico).HasColumnName("regreso_automatico");

                entity.Property(e => e.Subcuenta)
                    .HasColumnName("subcuenta")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
