using TmsTcAPI.BLL.Enum;
using TmsTcAPI.BLL.Interface;
using TmsTcAPI.DAL.Models;
using TmsTcAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static TmsTcAPI.BLL.Enum.ErrorEnum;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TmsTcAPI.BLL.Models;
using System.Xml;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TmsTcAPI.BLL.Business
{
    public class RutasBusiness : IRutas
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        DbContextOptions<TmsTcEntities> contextOptions;
        public RutasBusiness(DbContextOptions<TmsTcEntities> options)
        {
            contextOptions = options;
        }

        public InfoRuta ObtenerInfoRuta(
             string sOrigenLatitude
            , string sOrigenLongitude
            , string sDestinoLatitude
            , string sDestinoLongitude
            , string sTipoVehiculo
            //, string sPesoVehiculo
            //, string sLargoVehiculo
            //, string sAnchoVehiculo
            //, string sAlturaVehiculo
            //, string sEvitarCasetas
            //, string sEvitarFerrys
            //, string sOptimizarParadas
            //, string sOptimizarNOM
            //, string sRutaCamion
            //, string sVelocidad
            )
        {
            //JsonResult jsonResult = new JsonResult { Data = null, Mensaje = "" };

            //jsonResult.Data = GetInfoRuta(
            InfoRuta oInfoRuta = new InfoRuta();

            oInfoRuta = GetInfoRuta(
                sOrigenLatitude
                ,sOrigenLongitude
                ,sDestinoLatitude
                ,sDestinoLongitude
                ,sTipoVehiculo
                //,sPesoVehiculo
                //,sLargoVehiculo
                //,sAnchoVehiculo
                //,sAlturaVehiculo
                //,sEvitarCasetas
                //,sEvitarFerrys
                //,sOptimizarParadas
                //,sOptimizarNOM
                //,sRutaCamion
                //,sVelocidad
                );

            return oInfoRuta;

        }

        private InfoRuta GetInfoRuta(
             string sOrigenLatitude
            ,string sOrigenLongitude
            ,string sDestinoLatitude
            ,string sDestinoLongitude
            ,string sTipoVehiculo
            //,string sPesoVehiculo
            //,string sLargoVehiculo
            //,string sAnchoVehiculo
            //,string sAlturaVehiculo
            //,string sEvitarCasetas
            //,string sEvitarFerrys
            //,string sOptimizarParadas
            //,string sOptimizarNOM
            //,string sRutaCamion
            //,string sVelocidad
            )
        {
            //List<InfoRuta> lista = new List<InfoRuta>();

            InfoRuta ruta = new InfoRuta();

            XmlDocument xdoc = new XmlDocument();

            string sRuta = "";
            //sRuta += "http://www.gmapserver.com/GlobalMap_API/V3/GlobalMapPHP.php?ClaveCliente=";
            //sRuta += "316364192833609";

            sRuta += ObtenerGlobalMap_EndPoint();
            //sRuta = "globalmap";

            sRuta += "&TipoVehiculo=" + sTipoVehiculo;
            //sRuta += "&PesoVehiculo=" + sPesoVehiculo;
            //sRuta += "&LargoVehiculo=" + sLargoVehiculo;
            //sRuta += "&AnchoVehiculo="+ sAnchoVehiculo;
            //sRuta += "&AlturaVehiculo=" + sAlturaVehiculo;
            //sRuta += "&EvitarCasetas=" + sEvitarCasetas;
            //sRuta += "&EvitarFerrys=" + sEvitarFerrys;
            //sRuta += "&OptimizarParadas=" + sOptimizarParadas;
            //sRuta += "&OptimizarNOM=" + sOptimizarNOM;
            //sRuta += "&RutaCamion=" + sRutaCamion;
            //sRuta += "&Velocidad=" + sVelocidad;

            sRuta += "&TxtOrigen=";
            sRuta += "&LonOrigen=" + sOrigenLongitude;
            sRuta += "&LatOrigen=" + sOrigenLatitude;
            
            sRuta += "&TxtDestino=";
            sRuta += "&LonDestino=" + sDestinoLongitude;
            sRuta += "&LatDestino=" + sDestinoLatitude;


            try
            {

                xdoc.Load(sRuta);


                XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("MENSAJE_RUTA");

                foreach (XmlNode xNode in xNodelst)
                {
                    foreach (XmlNode xMyNode in xNode)
                    {
                        if (xMyNode.Name == "#text")
                            ruta.Error_GlobalMap = xMyNode.InnerText == "RUTA LISTA" ? "" : xMyNode.InnerText;

                    }
                }

                xNodelst = xdoc.DocumentElement.SelectNodes("ORIGEN");

                foreach (XmlNode xNode in xNodelst)
                {
                    foreach (XmlNode xMyNode in xNode)
                    {
                        if (xMyNode.Name == "TEXTO")
                            ruta.OrigenNombre = xMyNode.InnerText;
                        else if (xMyNode.Name == "LONGITUD")
                            ruta.OrigenLon = xMyNode.InnerText;
                        else if (xMyNode.Name == "LATITUD")
                            ruta.OrigenLat = xMyNode.InnerText;
                    }
                }

                xNodelst = xdoc.DocumentElement.SelectNodes("DESTINO");

                foreach (XmlNode xNode in xNodelst)
                {
                    foreach (XmlNode xMyNode in xNode)
                    {
                        if (xMyNode.Name == "TEXTO")
                            ruta.DestinoNombre = xMyNode.InnerText;
                        else if (xMyNode.Name == "LONGITUD")
                            ruta.DestinoLon = xMyNode.InnerText;
                        else if (xMyNode.Name == "LATITUD")
                            ruta.DestinoLat = xMyNode.InnerText;
                    }
                }

                xNodelst = xdoc.DocumentElement.SelectNodes("RESULTADOS");

                foreach (XmlNode xNode in xNodelst)
                {
                    foreach (XmlNode xMyNode in xNode)
                    {
                        if (xMyNode.Name == "DISTANCIA_TOTAL")
                            ruta.DistanciaTotal = xMyNode.InnerText;
                        else if (xMyNode.Name == "TIEMPO_TOTAL")
                            ruta.TiempoTotal = xMyNode.InnerText;
                        else if (xMyNode.Name == "COSTO_CASETAS")
                            ruta.CostoCasetas = xMyNode.InnerText.Replace("$","").Trim();
                    }
                }
            }

            catch (Exception e)
            {
                ruta.ErrorInterno = -999;
                ruta.ErrorInternoMsg = e.Message;
            }
            finally {
               
            }
            return ruta;
        }



        public string ObtenerGlobalMap_EndPoint()
        {
            if (contextOptions == null)
                return "http://www.gmapserver.com/GlobalMap_API/V3/GlobalMapPHP.php?ClaveCliente=316364192833609";
            using (TmsTcEntities db = new TmsTcEntities(contextOptions))
            {
                string sEndPoint = "";

                object valorRegresa = null;
                string mensaje = String.Empty;
                JsonResult respuesta = new JsonResult { Data = null, Mensaje = "Error" };
                try
                {
                    string procedimiento = "SP_ObtenerGlobalMap_EndPoint";
                    var con = (SqlConnection)db.Database.GetDbConnection();

                    using (SqlConnection cn = new SqlConnection(con.ConnectionString))
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(procedimiento, cn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            sEndPoint = dr[0].ToString();
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
                    //sEndPoint = new JsonResult { Data = valorRegresa, Mensaje = mensaje };
                }
                return sEndPoint;
            }
        }

    }

}
