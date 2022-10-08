using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            ClientesFacturacion = new HashSet<ClientesFacturacion>();
            ClientesTipoGirosCliente = new HashSet<ClientesTipoGirosCliente>();
            ContactosCliente = new HashSet<ContactosCliente>();
            Cotizacion = new HashSet<Cotizacion>();
            OficinasOperativas = new HashSet<OficinasOperativas>();
            PuntosEntrega = new HashSet<PuntosEntrega>();
            TiposPago = new HashSet<TiposPago>();
        }

        public int Id { get; set; }
        public int? IdClienteZam { get; set; }
        public string NombreComercial { get; set; }
        public bool Holdings { get; set; }
        public string HoldingNombre { get; set; }
        public float? HoldingPorcentaje { get; set; }
        public float? HoldingVolumen { get; set; }
        public bool? AutosNuevos { get; set; }
        public bool SeguroUnidades { get; set; }
        public string NoCliente { get; set; }
        public string ClaveCliente { get; set; }
        public string Domicilio { get; set; }
        public string Cp { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string CuentaCliente { get; set; }
        public string SubcuentaCliente { get; set; }
        public string Observaciones { get; set; }
        public float? MontoLimiteCredito { get; set; }
        public float? MontoAdvertenciaLimite { get; set; }
        public string AuxiliarContable { get; set; }
        public bool CalculaSeguroCarga { get; set; }
        public float? ValorSurcharge { get; set; }
        public bool FuelSurcharge { get; set; }
        public bool EsLead { get; set; }
        public string NombreAreaCobranza { get; set; }
        public string DescripcionAreaCobranza { get; set; }
        public int? ConsecutivoCobranza { get; set; }
        public string Alias { get; set; }
        public bool EsPersonaMoral { get; set; }
        public int? FrecuenciaNotificacion { get; set; }
        public int IdMarca { get; set; }
        public int IdTipoMoneda { get; set; }
        public int IdPlazaCliente { get; set; }
        public int IdTipoIva { get; set; }
        public int IdUsoCfdi { get; set; }
        public int IdTipoCredito { get; set; }
        public int IdTipoRetencion { get; set; }
        public int IdTipoGiroPrincipalCliente { get; set; }
        public int IdEstatusCliente { get; set; }
        public int IdColonia { get; set; }
        public int IdAreaCobranza { get; set; }
        public int IdTipoFormula { get; set; }
        public int? IdClienteFacturacionPrincipal { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Curp { get; set; }
        public int? IdOtrosGirosCliente { get; set; }
        public int Prioridad { get; set; }
        public byte[] Logo { get; set; }

        public virtual AreasCobranza IdAreaCobranzaNavigation { get; set; }
        public virtual Colonias IdColoniaNavigation { get; set; }
        public virtual EstatusCliente IdEstatusClienteNavigation { get; set; }
        public virtual Marcas IdMarcaNavigation { get; set; }
        public virtual TiposCredito IdTipoCreditoNavigation { get; set; }
        public virtual TiposFormula IdTipoFormulaNavigation { get; set; }
        public virtual TiposGirosCliente IdTipoGiroPrincipalClienteNavigation { get; set; }
        public virtual TiposIva IdTipoIvaNavigation { get; set; }
        public virtual TiposMoneda IdTipoMonedaNavigation { get; set; }
        public virtual TiposRetencion IdTipoRetencionNavigation { get; set; }
        public virtual UsosCfdi IdUsoCfdiNavigation { get; set; }
        public virtual ICollection<ClientesFacturacion> ClientesFacturacion { get; set; }
        public virtual ICollection<ClientesTipoGirosCliente> ClientesTipoGirosCliente { get; set; }
        public virtual ICollection<ContactosCliente> ContactosCliente { get; set; }
        public virtual ICollection<Cotizacion> Cotizacion { get; set; }
        public virtual ICollection<OficinasOperativas> OficinasOperativas { get; set; }
        public virtual ICollection<PuntosEntrega> PuntosEntrega { get; set; }
        public virtual ICollection<TiposPago> TiposPago { get; set; }
    }
}
