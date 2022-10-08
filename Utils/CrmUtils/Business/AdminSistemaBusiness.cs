using Core.Api.BLL.Enum;
using Core.Api.BLL.Interface;
using CrmTcAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmsTcAPI.DAL.Models;
using static Core.Api.BLL.Enum.ErrorEnum;

namespace Core.Api.BLL.Business
{
    public class AdminSistemaBusiness : IAdminSistema
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly TmsTcEntities db;

        public AdminSistemaBusiness(TmsTcEntities context)
        {
            this.db = context;
        }

        public JsonResult ObtenerBitacora(int idUsuario = -1)
        {
            HelperConsultasCatalogos helperConsulta = new HelperConsultasCatalogos();
            helperConsulta.nombreProcedimientoAlmacenado = "SP_ObtenerBitacora";
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<BitacoraCustom> lista = new List<BitacoraCustom>();
            try
            {
                var con = (SqlConnection)db.Database.GetDbConnection();
                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(helperConsulta.nombreProcedimientoAlmacenado, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        BitacoraCustom objBitacora = new BitacoraCustom();
                        objBitacora.id = int.Parse(dr[0].ToString());
                        objBitacora.idUsuario = int.Parse(dr[1].ToString());
                        objBitacora.fecha = Convert.ToDateTime(dr[2].ToString());
                        objBitacora.hora = Convert.ToDateTime(dr[3].ToString());
                        objBitacora.entity = dr[4].ToString();
                        objBitacora.idObject = int.Parse(dr[5].ToString());
                        objBitacora.descripcionFuncionalidad = dr[6].ToString();
                        objBitacora.idModulo = int.Parse(dr[7].ToString());
                        objBitacora.nombreModulo = dr[8].ToString();
                        objBitacora.idTipoEntradaBitacora = int.Parse(dr[9].ToString());
                        objBitacora.DescrpcionTipoEntradaBitacora = dr[10].ToString();
                        lista.Add(objBitacora);
                    }
                    helperConsulta.valorRegresa = lista;
                }
            }
            catch (Exception ex)
            {
                helperConsulta.AsignaError(ErrorEnum.TypeofError.ErrorAlObtenerConsulta, ex);
                Logger.Error(ex, helperConsulta.mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = helperConsulta.valorRegresa, Mensaje = helperConsulta.mensaje };
            }

            return respuesta;
        }


        public string ObtenerActiveDirectoryInfo()
        {
            string sAD_info = "";

            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            try
            {
                string procedimiento = "SP_ObtenerActiveDirectoryInfo";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        sAD_info = dr[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlObtenerConsulta;
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {
                //sAD_info = new JsonResult { Data = valorRegresa, Mensaje = mensaje };
            }
            return sAD_info;
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////METODOS VERIFICADOS//////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////


        public JsonResult ActualizarPermisos(
     int idUsuario
    , string idPermiso
    , int iLeer
    , int iEscribir
    , int iEjecutar
    )
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };

            try
            {
                string procedimiento = "SP_ActualizaPermiso";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@idPermiso", idPermiso);
                    cmd.Parameters.AddWithValue("@Leer", iLeer);
                    cmd.Parameters.AddWithValue("@Escribir", iEscribir);
                    cmd.Parameters.AddWithValue("@Ejecutar", iEjecutar);

                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlObtenerConsulta;
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = null, Mensaje = mensaje };

            }
            return respuesta;
        }

        public JsonResult ObtenerPermisosHistory(int idPermiso)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<PermisosHistoryCustom> listaPermisosHistoryCustom = new List<PermisosHistoryCustom>();
            try
            {
                string procedimiento = "SP_ObtenerPermisosHistory";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPermiso", idPermiso);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        PermisosHistoryCustom oPermisosHistoryCustom = new PermisosHistoryCustom();
                        oPermisosHistoryCustom.campo = dr[0].ToString();
                        oPermisosHistoryCustom.usuario = dr[1].ToString();
                        oPermisosHistoryCustom.actual = dr[2].ToString();
                        oPermisosHistoryCustom.nuevo = dr[3].ToString();
                        oPermisosHistoryCustom.fechaMovimiento = (DateTime?)dr[4];

                        listaPermisosHistoryCustom.Add(oPermisosHistoryCustom);
                    }
                }
                valorRegresa = listaPermisosHistoryCustom;
            }
            catch (Exception ex)
            {
                valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlObtenerConsulta;
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = valorRegresa, Mensaje = mensaje };
            }
            return respuesta;
        }


        public JsonResult ObtenerParametrosSistema()
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            try
            {

                var lista = (from p in db.ParametrosSistema
                             where p.Active == true orderby p.Orden
                             select new ParametroSistemaCustom
                             {
                                 modulo = p.Descripcion.Split('.', StringSplitOptions.None)[0],
                                 nombre = p.Descripcion.Split('.', StringSplitOptions.None)[1],
                                 descripcion = p.Descripcion.Split('.', StringSplitOptions.None)[1],
                                 password = p.Password,
                                 valor = (p.Password & p.Valor.Length > 0)? "************" : p.Valor,
                                 orden = p.Orden,
                                 regex = "",
                                 longitud = p.Longitud
                             }).ToList();

                valorRegresa = lista;

            }
            catch (Exception ex)
            {
                valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlObtenerConsulta;
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = valorRegresa, Mensaje = mensaje };
            }
            return respuesta;
        }

        public JsonResult GrabarParametrosSistema(
     int idUsuario
    , string Correo_Cuenta
    , string Correo_Contrasena
    , string Correo_ServerSMTP
    , string Correo_Puerto
    , string Correo_Admin
    , string Correo_Notificaciones
    , string Correo_AsuntoCliente
    , string Correo_CuerpoCliente
    , string Endpoint_Innovalinks
    , string Endpoint_ZAM
    , string Endpoint_PowerBI
    , string GlobalMaps
    , string TMS
    , string ActiveDirectory
    , string AD_Domain
    , string AD_TenantId
    , string AD_ClientId
    , string AD_Callback
    , string AD_SignedOutCallbackPath
    , string AD_ClientSecret
    , string DB_ZAM
    , string DB_Usuario
    , string DB_Contrasena
    , string GlobalMaps_ClientKey
    , string NotifTerminoContrato
    , string Endpoint_SharePoint
    , string Usuario_SharePoint
    , string Contrasena_SharePoint
    , string Usuario_PowerBI
    , string Contrasena_PowerBI

    )
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };

            try
            {
                string procedimiento = "SP_GuardarParametrosSistema";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Correo_Cuenta", Correo_Cuenta);
                    cmd.Parameters.AddWithValue("@Correo_Contrasena", Correo_Contrasena);
                    cmd.Parameters.AddWithValue("@Correo_ServerSMTP", Correo_ServerSMTP);
                    cmd.Parameters.AddWithValue("@Correo_Puerto", Correo_Puerto);
                    cmd.Parameters.AddWithValue("@Correo_Admin", Correo_Admin);
                    cmd.Parameters.AddWithValue("@Correo_Notificaciones", Correo_Notificaciones);
                    cmd.Parameters.AddWithValue("@Correo_AsuntoCliente", Correo_AsuntoCliente);
                    cmd.Parameters.AddWithValue("@Correo_CuerpoCliente", Correo_CuerpoCliente);
                    cmd.Parameters.AddWithValue("@Endpoint_Innovalinks", Endpoint_Innovalinks);
                    cmd.Parameters.AddWithValue("@Endpoint_ZAM", Endpoint_ZAM);
                    cmd.Parameters.AddWithValue("@Endpoint_PowerBI", Endpoint_PowerBI);
                    cmd.Parameters.AddWithValue("@GlobalMaps", GlobalMaps);
                    cmd.Parameters.AddWithValue("@TMS", TMS);
                    cmd.Parameters.AddWithValue("@ActiveDirectory", ActiveDirectory);
                    cmd.Parameters.AddWithValue("@AD_Domain", AD_Domain);
                    cmd.Parameters.AddWithValue("@AD_TenantId", AD_TenantId);
                    cmd.Parameters.AddWithValue("@AD_ClientId", AD_ClientId);
                    cmd.Parameters.AddWithValue("@AD_Callback", AD_Callback);
                    cmd.Parameters.AddWithValue("@AD_SignedOutCallbackPath", AD_SignedOutCallbackPath);
                    cmd.Parameters.AddWithValue("@AD_ClientSecret", AD_ClientSecret);
                    cmd.Parameters.AddWithValue("@DB_ZAM", DB_ZAM);
                    cmd.Parameters.AddWithValue("@DB_Usuario", DB_Usuario);
                    cmd.Parameters.AddWithValue("@DB_Contrasena", DB_Contrasena);
                    cmd.Parameters.AddWithValue("@GlobalMaps_ClientKey", GlobalMaps_ClientKey);
                    cmd.Parameters.AddWithValue("@NotifTerminoContrato", NotifTerminoContrato);
                    cmd.Parameters.AddWithValue("@Endpoint_SharePoint", Endpoint_SharePoint);
                    cmd.Parameters.AddWithValue("@Usuario_SharePoint", Usuario_SharePoint);
                    cmd.Parameters.AddWithValue("@Contrasena_SharePoint", Contrasena_SharePoint);
                    cmd.Parameters.AddWithValue("@Usuario_PowerBI", Usuario_PowerBI);
                    cmd.Parameters.AddWithValue("@Contrasena_PowerBI", Contrasena_PowerBI);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlObtenerConsulta;
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = null, Mensaje = mensaje };

            }
            return respuesta;
        }

        public JsonResult ActualizaParametroSistema(
int idUsuario
, string descripcion
, string valor, int? orden, int? longitud, bool password
)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };

            try
            {
                string procedimiento = "SP_ActualizaParametroSistema";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Valor", valor);
                    cmd.Parameters.AddWithValue("@Orden", orden);
                    cmd.Parameters.AddWithValue("@Longitud", longitud);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlObtenerConsulta;
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = null, Mensaje = mensaje };

            }
            return respuesta;
        }


        public JsonResult ObtenerParametroSistemaHistory(string sParametro)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<ParametroSistemaHistoryCustom> listaParametrosSistemaHistory = new List<ParametroSistemaHistoryCustom>();
            try
            {

                string procedimiento = "SP_ObtenerParametrosSistemaHistory";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@campo", sParametro);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ParametroSistemaHistoryCustom oParametroSistemaHistory = new ParametroSistemaHistoryCustom();
                        oParametroSistemaHistory.campo = dr[0].ToString().Split('.', StringSplitOptions.None)[1];
                        oParametroSistemaHistory.usuario = dr[1].ToString();
                        oParametroSistemaHistory.actual = dr[2].ToString();
                        oParametroSistemaHistory.nuevo = dr[3].ToString();
                        oParametroSistemaHistory.fechaMovimiento = (DateTime)dr[4];

                        listaParametrosSistemaHistory.Add(oParametroSistemaHistory);
                    }
                }
                valorRegresa = listaParametrosSistemaHistory;
            }
            catch (Exception ex)
            {
                valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlObtenerConsulta;
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = valorRegresa, Mensaje = mensaje };
            }
            return respuesta;
        }

    }
}
