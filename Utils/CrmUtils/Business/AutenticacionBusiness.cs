using Core.Api.BLL.Enum;
using CrmTcAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static Core.Api.BLL.Enum.ErrorEnum;

using Core.Api.BLL.Other;
using System.Threading.Tasks;
using Core.Api.BLL.Interface;
using Core.Api.Other;
using EncryptionLibrary;
using TmsTcAPI.DAL.Models;

namespace Core.Api.BLL.Business
{
    public class AutenticacionBusiness : IAutenticacion
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly TmsTcEntities db;

        public AutenticacionBusiness(TmsTcEntities context)
        {
            this.db = context;
        }

        public JsonResult ObtenerPermisos(int identificadorId, EnumTipoEntrada.TipoConsulta consulta)
        {
            JsonResult jsonResult = new JsonResult { Data = null, Mensaje = "" };

            jsonResult.Data = EjecutarConsulta(identificadorId, consulta);

            return jsonResult;
        }

        private List<PermisosRol> EjecutarConsulta(int identificadorId, EnumTipoEntrada.TipoConsulta consulta)
        {
            string procedimiento = "SP_ObtenerPermisosPorUsuario";
            List<PermisosRol> lista = new List<PermisosRol>();
            var con = (SqlConnection)db.Database.GetDbConnection();
            if (consulta == EnumTipoEntrada.TipoConsulta.Rol)
                procedimiento = "SP_ObtenerPermisosPorRol";

            using (SqlConnection cn = new SqlConnection(con.ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(procedimiento, cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (consulta == EnumTipoEntrada.TipoConsulta.Rol)
                    cmd.Parameters.AddWithValue("@rolId", identificadorId);
                else
                    cmd.Parameters.AddWithValue("@usuarioId", identificadorId);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PermisosRol usuario = new PermisosRol();
                    usuario.usuariosId = int.Parse(dr[0].ToString());
                    usuario.rolesId = int.Parse(dr[1].ToString());
                    //usuario.nombre = dr[2].ToString();
                    //usuario.mail = dr[3].ToString();
                    usuario.nombreFuncionalidad = dr[4].ToString();
                    usuario.nombreModulo = dr[5].ToString();
                    usuario.descripcionModulo = dr[6].ToString();
                    usuario.idModulo = Int32.Parse(dr[7].ToString());
                    usuario.idFuncionalidad = Int32.Parse(dr[8].ToString());
                    lista.Add(usuario);
                }
            }
            return lista;
        }



        private List<param_idusuario> InicioSesionAD(string sUser, string sPassword)
        {
            List<param_idusuario> lista = new List<param_idusuario>();

            param_idusuario usuario = new param_idusuario();

            usuario.idUsuario = 10;  // Employeeid = employeeid
            usuario.NombreUsuario = "";
            usuario.Nombre = "FirstName = givenname & LastName = sn";
            usuario.ApellidoPaterno = "";
            usuario.ApellidoMaterno = "";
            usuario.Rol = "1";
            usuario.RolId = 1;
            usuario.Imagen = null;
            usuario.idActiveDirectory = 9;  // Employeeid = employeeid
            usuario.idRolAD = 50;

            lista.Add(usuario);

            return lista;
        }


        public JsonResult ObtenerPermisosParametrosCotizacionRol(int idRol)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<PermisosRol> listaPermisosRol = new List<PermisosRol>();
            try
            {
                string procedimiento = "SP_ObtenerCotizacionParametrosPermisos";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idRol", idRol);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        PermisosRol oPermisosRol = new PermisosRol();
                        oPermisosRol.rolesId = int.Parse(dr[0].ToString());
                        oPermisosRol.nombreRol = dr[1].ToString();
                        oPermisosRol.idModulo = int.Parse(dr[2].ToString());
                        oPermisosRol.nombreModulo = dr[3].ToString();
                        oPermisosRol.idFuncionalidad = int.Parse(dr[4].ToString());
                        oPermisosRol.nombreFuncionalidad = dr[5].ToString();
                        oPermisosRol.idPermiso = int.Parse(dr[6].ToString());
                        oPermisosRol.Leer = int.Parse(dr[7].ToString());
                        oPermisosRol.Escribir = int.Parse(dr[8].ToString());
                        oPermisosRol.Ejecutar = int.Parse(dr[9].ToString());

                        listaPermisosRol.Add(oPermisosRol);
                    }
                }
                valorRegresa = listaPermisosRol;
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

        public JsonResult ObtenerPermisosFuncionalidadesUsuario(int idUsuario)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<PermisosUsuario> listaPermisosUsuario = new List<PermisosUsuario>();
            try
            {
                string procedimiento = "SP_ObtenerFuncionalidadesPermisosXUsuario";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        PermisosUsuario oPermisosUsuario = new PermisosUsuario();

                        oPermisosUsuario.idModulo = int.Parse(dr[0].ToString());
                        oPermisosUsuario.nombreModulo = dr[1].ToString();
                        oPermisosUsuario.idFuncionalidad = int.Parse(dr[2].ToString());
                        oPermisosUsuario.nombreFuncionalidad = dr[3].ToString();
                        oPermisosUsuario.Leer = bool.Parse(dr[4].ToString());
                        oPermisosUsuario.Escribir = bool.Parse(dr[5].ToString());
                        oPermisosUsuario.Ejecutar = bool.Parse(dr[6].ToString());

                        listaPermisosUsuario.Add(oPermisosUsuario);
                    }
                }
                valorRegresa = listaPermisosUsuario;
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


        public JsonResult ObtenerCatalogos(string sUser, string sPassword)
        {
            HelperAutenticacion helperConsulta = new HelperAutenticacion();
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            CatalogosAutenticacion catalogos = new CatalogosAutenticacion();
            Utils util = new Utils();
            try
            {
                IAutenticacion catalogosBusiness = new AutenticacionBusiness(db);

                catalogos.Usuarios = util.validaCatalogoUsuarios(catalogosBusiness.Login(sUser, sPassword));

                param_idusuario oTmp = new param_idusuario();

                oTmp = catalogos.Usuarios[0];

                int idUsuario;

                idUsuario = catalogos.Usuarios.Count == 0 ? 0 : oTmp.idUsuario;

                catalogos.PermisosUsuario = util.validaCatalogoPermisosUsuario(catalogosBusiness.ObtenerPermisosFuncionalidadesUsuario(idUsuario));

                helperConsulta.valorRegresa = catalogos;

            }
            catch (Exception ex)
            {
                helperConsulta.AsignaError(ErrorEnum.TypeofError.ErrorAlIniciarSesion, ex);
                Logger.Error(ex, helperConsulta.mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = helperConsulta.valorRegresa, Mensaje = helperConsulta.mensaje };
            }
            return respuesta;
        }

        public JsonResult ObtenerConfiguracionTemplate(int idUsuario)
        {
            HelperConsultasCatalogos helperConsulta = new HelperConsultasCatalogos();
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<TemplateConfiguracionCustom> lista = new List<TemplateConfiguracionCustom>();
            try
            {
                List<TemplateConfig> list = new List<TemplateConfig>();
                if (idUsuario < 0)
                    list = db.TemplateConfig.Where(x => x.Active == true).ToList();
                else
                    list = db.TemplateConfig.Where(x => x.IdUsuario == idUsuario && x.Active == true).ToList();

                if (list.Count > 0)
                {
                    foreach (var objLista in list)
                    {
                        TemplateConfiguracionCustom template = new TemplateConfiguracionCustom();
                        template.layout.variant = objLista.LayoutVariant;
                        template.layout.menuPosition = objLista.LayoutMenuPosition;
                        template.layout.customizer.hidden = objLista.LayoutCustomizerHidden;
                        template.layout.navbar.type = objLista.NavbarType;
                        template.layout.sidebar.collapsed = objLista.SidebarCollapsed;
                        template.layout.sidebar.size = objLista.SidebarSize;
                        template.layout.sidebar.backgroundColor = objLista.SidebarBackgroundColor;
                        template.layout.sidebar.backgroundImage = objLista.SidebarBackgroundImage;
                        template.layout.sidebar.backgroundImageURL = objLista.SidebarBackgroundImageUrl;
                        lista.Add(template);
                    }
                }
                helperConsulta.valorRegresa = lista;
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

        public JsonResult AgregarActualizarTemplateConfiguracion(TemplateConfig template)
        {
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            object valorRegresa = null;
            string mensaje = String.Empty;
            try
            {
                var templateObject = db.TemplateConfig.Where(c => c.IdUsuario == template.IdUsuario).FirstOrDefault();
                if (templateObject == null)//insertar
                {
                    template.UpdatedAt = DateTime.Now;
                    template.CreatedAt = DateTime.Now;
                    db.Entry(template).State = EntityState.Added;
                }
                else
                {
                    templateObject.IdUsuario = template.IdUsuario;
                    templateObject.LayoutVariant = template.LayoutVariant;
                    templateObject.LayoutMenuPosition = template.LayoutMenuPosition;
                    templateObject.LayoutCustomizerHidden = template.LayoutCustomizerHidden;
                    templateObject.NavbarType = template.NavbarType;
                    templateObject.SidebarCollapsed = template.SidebarCollapsed;
                    templateObject.SidebarSize = template.SidebarSize;
                    templateObject.SidebarBackgroundColor = template.SidebarBackgroundColor;
                    templateObject.SidebarBackgroundImage = template.SidebarBackgroundImage;
                    templateObject.SidebarBackgroundImageUrl = template.SidebarBackgroundImageUrl;
                    templateObject.UpdatedBy = template.CreatedBy;
                    templateObject.UpdatedAt = DateTime.Now;
                }
                db.SaveChanges();
                valorRegresa = (int)template.Id;
                mensaje = "Ok";

            }
            catch (Exception ex)
            {
                valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlActualizarTemplateConfig;
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlActualizarTemplateConfig);
                Logger.Error(ex, mensaje);
            }
            finally
            {
                respuesta = new JsonResult { Data = valorRegresa, Mensaje = mensaje };
            }
            return respuesta;
        }

        //public JsonResult ValidarSesion(int idUsuario, string sSesionToken)
        //{
        //    try
        //    {
        //        object valorRegresa = null;
        //        string mensaje = String.Empty;
        //        JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
        //        List<SesionToken> listaSesionToken = new List<SesionToken>();
        //        try
        //        {
        //            string procedimiento = "SP_ValidarSesion";
        //            var con = (SqlConnection)db.Database.GetDbConnection();

        //            using (SqlConnection cn = new SqlConnection(con.ConnectionString))
        //            {
        //                cn.Open();
        //                SqlCommand cmd = new SqlCommand(procedimiento, cn);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
        //                cmd.Parameters.AddWithValue("@SesionToken", sSesionToken);

        //                SqlDataReader dr = cmd.ExecuteReader();

        //                while (dr.Read())
        //                {
        //                    SesionToken oSesionToken = new SesionToken();

        //                    oSesionToken.SesionOk = bool.Parse(dr[0].ToString());

        //                    listaSesionToken.Add(oSesionToken);

        //                }
        //            }
        //            valorRegresa = listaSesionToken;
        //        }
        //        catch (Exception ex)
        //        {
        //            valorRegresa = (int)ErrorEnum.TypeofError.ErrorAlObtenerConsulta;
        //            mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
        //            Logger.Error(ex, mensaje);
        //        }
        //        finally
        //        {
        //            respuesta = new JsonResult { Data = valorRegresa, Mensaje = mensaje };
        //        }
        //        return respuesta;
        //    }
        //}



        public JsonResult KeepAlive(string sSesionToken, int iMinutos = 15)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<SesionToken> listaSesionToken = new List<SesionToken>();
            try
            {
                string procedimiento = "SP_KeepAlive";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SesionToken", sSesionToken);
                    cmd.Parameters.AddWithValue("@minutos", iMinutos);

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
                respuesta = new JsonResult { Data = valorRegresa, Mensaje = mensaje };
            }
            return respuesta;
        }









        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////METODOS VERIFICADOS//////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////


        public async Task<ADObject> getRolAndUserAsync(string sUser, string sPassword)
        {
            ADObject objAd = new ADObject();
            AuthenticationAD authAd = new AuthenticationAD();
            objAd = await authAd.getUserAndRole(sUser, sPassword);
            return objAd;
        }
        public JsonResult Login(string sUser, string sPassword, string tipoUsuario)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };

            string sContrasena = EncryptProvider.Encrypt(sPassword);        // eliminar esta línea cuando el Front comience a enviar el pwd encriptado

            string sPwdDecriptado = EncryptProvider.Decrypt(sContrasena);

            string sRol = "";           // Rol devuelto por ActiveDirectory
            int idRol = 0;

            ADObject objAd = new ADObject();
            objAd = getRolAndUserAsync(sUser, sPassword).Result;
            bool banderaForzarEntrada = true;

            if (banderaForzarEntrada == true || (objAd.idError == 0 && objAd.rol.Length > 0 && objAd.nombreUsuario.Length > 0))
            {
                if (banderaForzarEntrada == false)
                {
                    if (objAd.rol.Length > 0 && objAd.nombreUsuario.Length > 0)
                        sRol = objAd.rol;

                    if (!bExisteUsuario(sUser, objAd.nombreUsuario, sUser))
                    {
                        idRol = ObtenerRolId(sRol);
                        CrearUsuarioRol(sUser, idRol);
                    }
                }

                List<param_idusuario> listaUsuarios = new List<param_idusuario>();
                try
                {
                    string procedimiento = "SP_Login";
                    var con = (SqlConnection)db.Database.GetDbConnection();

                    using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(procedimiento, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user", sUser);
                        cmd.Parameters.AddWithValue("@password", sPwdDecriptado);
                        cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            param_idusuario oUsuario = new param_idusuario();

                            oUsuario.idUsuario = int.Parse(dr[0].ToString());
                            oUsuario.NombreUsuario = dr[1].ToString();
                            oUsuario.Nombre = dr[2].ToString();
                            oUsuario.ApellidoPaterno = dr[3].ToString();
                            oUsuario.ApellidoMaterno = dr[4].ToString();
                            oUsuario.Correo = dr[5].ToString();
                            oUsuario.Rol = dr[6].ToString();
                            oUsuario.RolId = int.Parse(dr[7].ToString());
                            oUsuario.Imagen = null;// byte.Parse(dr[7].ToString());
                            oUsuario.idActiveDirectory = int.Parse(dr[9].ToString());
                            oUsuario.idRolAD = int.Parse(dr[10].ToString());
                            oUsuario.SesionToken = dr[11].ToString();
                            oUsuario.ConSesionActiva = bool.Parse(dr[12].ToString());
                            oUsuario.isFirstLogin = bool.Parse(dr[13].ToString());
                            listaUsuarios.Add(oUsuario);

                        }
                    }
                    valorRegresa = listaUsuarios;
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
            }
            else
            {
                respuesta = new JsonResult { Data = null, Mensaje = "Error: Usuario no existe en Active Directory" };
            }
            return respuesta;
        }

        private bool bExisteUsuario(string sUsuario, string nombre, string correo)
        {

            bool bExiste = false;

            string mensaje = String.Empty;
            try
            {
                string procedimiento = "SP_ExisteUsuario";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user", sUsuario);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        bExiste = bool.Parse(dr[0].ToString());

                    }
                    //Procedemos a crear ese usuario JARR 2021-06-01
                    if (bExiste == false)
                    {
                        crearUsuario(nombre, correo);
                    }
                }

            }
            catch (Exception ex)
            {
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {

            }
            return bExiste;
        }

        private int crearUsuario(string nombre, string correo)
        {

            int bIdUsuario = -1;

            string mensaje = String.Empty;
            try
            {
                string procedimiento = "SP_CrearUsuario";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@email", correo);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        bIdUsuario = int.Parse(dr[0].ToString());

                    }

                }

            }
            catch (Exception ex)
            {
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {

            }
            return bIdUsuario;
        }


        public int ObtenerRolId(string sRol)
        {
            int iRol = 0;

            string mensaje = String.Empty;
            try
            {
                string procedimiento = "SP_ObtenerRolId";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rolDescripcion", sRol);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        iRol = int.Parse(dr[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = EnumHelper.SetErrorMessage(mensaje, ex, TypeofError.ErrorAlObtenerConsulta);
                Logger.Error(ex, mensaje);
            }
            finally
            {

            }
            return iRol;
        }

        public JsonResult CrearUsuarioRol(string sUser, int idRol)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<RolUsuarioCustom> listaRolUsuario = new List<RolUsuarioCustom>();
            try
            {
                string procedimiento = "SP_CrearUsuarioRol";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sUser", sUser);
                    cmd.Parameters.AddWithValue("@idRol", idRol);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        RolUsuarioCustom oRolUsuario = new RolUsuarioCustom();

                        oRolUsuario.idUsuario = int.Parse(dr[0].ToString());
                        oRolUsuario.idRol = int.Parse(dr[1].ToString());

                        listaRolUsuario.Add(oRolUsuario);

                    }
                }
                valorRegresa = listaRolUsuario;
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

        public JsonResult ObtenerPermisosFuncionalidadesRol(int idRol)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
            List<PermisosRol> listaPermisosRol = new List<PermisosRol>();
            try
            {
                string procedimiento = "SP_RolesFuncionalidadesPermisos";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(procedimiento, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idRol", idRol);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        PermisosRol oPermisosRol = new PermisosRol();
                        oPermisosRol.rolesId = int.Parse(dr[0].ToString());
                        oPermisosRol.nombreRol = dr[1].ToString();
                        oPermisosRol.idModulo = int.Parse(dr[2].ToString());
                        oPermisosRol.nombreModulo = dr[3].ToString();
                        oPermisosRol.idFuncionalidad = int.Parse(dr[4].ToString());
                        oPermisosRol.nombreFuncionalidad = dr[5].ToString();
                        oPermisosRol.idPermiso = (DBNull.Value.Equals(dr[6])) ? null : (int?)dr[6];
                        oPermisosRol.funcionalidadPadre = (DBNull.Value.Equals(dr[7])) ? null : (int?)dr[7];
                        oPermisosRol.Leer = int.Parse(dr[8].ToString());
                        oPermisosRol.Escribir = int.Parse(dr[9].ToString());
                        oPermisosRol.Ejecutar = int.Parse(dr[10].ToString());

                        listaPermisosRol.Add(oPermisosRol);
                    }
                }
                valorRegresa = listaPermisosRol;
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

        public JsonResult Logout(int idUsuario)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };

            try
            {
                string procedimiento = "SP_Logout";
                var con = (SqlConnection)db.Database.GetDbConnection();

                using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                {

                    var oUser = db.Usuarios.Where(u => u.Id == idUsuario).FirstOrDefault();

                    if (oUser != null)
                    {

                        oUser.SesionToken = null;
                        oUser.SesionFechaHora = null;
                        oUser.SesionMinutos = 0;

                        db.SaveChanges();

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
                respuesta = new JsonResult { Data = null, Mensaje = mensaje };

            }
            return respuesta;
        }


        public JsonResult ValidarSesion(int idUsuario, string sSesionToken)
        {
            object valorRegresa = null;
            string mensaje = String.Empty;
            JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };

            SesionToken oSesionToken = new SesionToken();

            try
            {

                var objUsuario = db.Usuarios.Where(u =>
                                                    u.Id == idUsuario
                                                    && u.SesionToken == sSesionToken
                                                    && u.Active == true).FirstOrDefault();

                if (objUsuario != null)
                {
                    oSesionToken.SesionOk = true;
                }
                else
                {
                    oSesionToken.SesionOk = false;
                }

                valorRegresa = oSesionToken;
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
