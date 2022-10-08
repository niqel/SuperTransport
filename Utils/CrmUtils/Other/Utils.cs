using CrmTcAPI.Models;
using System;
using System.Collections.Generic;

namespace Core.Api.Other
{
    public class Utils
    {
        public Utils()
        {
        }

        /// <summary>
        /// IsNull verifies if name is null then returns an empty space
        /// else returns name
        /// </summary>
        /// <returns>string</returns>
        /// <param name="nombre">nombre</param>
        public string IsNull(string nombre)
        {
            if (nombre == null)
            {
                return "";
            }

            return nombre;
        }
        public int? ToNullableInt(string s)
        {
            int i;
            if (int.TryParse(s, out i))
                return i;
            return null;
        }
        public DateTime DateTimeNow()
        {
            TimeZoneInfo setTimeZoneInfo;
            DateTime currentDateTime;

            //Set the time zone information to US Mountain Standard Time 
            setTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)");

            //Get date and time in US Mountain Standard Time
            currentDateTime = TimeZoneInfo.ConvertTime(DateTime.Now, setTimeZoneInfo);

            return currentDateTime;
        }

        public List<CatalogoInformacion> validaCatalogo(JsonResult resultadoConsulta)
        {
            List<CatalogoInformacion> listaCatalogo = new List<CatalogoInformacion>();
            if (resultadoConsulta.Mensaje == "Ok" || resultadoConsulta.Mensaje == "")
                listaCatalogo = (List<CatalogoInformacion>)resultadoConsulta.Data;
            return listaCatalogo;
        }

        public List<CatalogoInformacionCiudadEstado> validaCatalogoCiudades(JsonResult resultadoConsulta)
        {
            List<CatalogoInformacionCiudadEstado> listaCatalogo = new List<CatalogoInformacionCiudadEstado>();
            if (resultadoConsulta.Mensaje == "Ok" || resultadoConsulta.Mensaje == "")
                listaCatalogo = (List<CatalogoInformacionCiudadEstado>)resultadoConsulta.Data;
            return listaCatalogo;
        }
        public List<CatalogoInformacionEstado> validaCatalogoEstados(JsonResult resultadoConsulta)
        {
            List<CatalogoInformacionEstado> listaCatalogo = new List<CatalogoInformacionEstado>();
            if (resultadoConsulta.Mensaje == "Ok" || resultadoConsulta.Mensaje == "")
                listaCatalogo = (List<CatalogoInformacionEstado>)resultadoConsulta.Data;
            return listaCatalogo;
        }
        public List<CatalogoInformacionMunicipio> validaCatalogoMunicipios(JsonResult resultadoConsulta)
        {
            List<CatalogoInformacionMunicipio> listaCatalogo = new List<CatalogoInformacionMunicipio>();
            if (resultadoConsulta.Mensaje == "Ok" || resultadoConsulta.Mensaje == "")
                listaCatalogo = (List<CatalogoInformacionMunicipio>)resultadoConsulta.Data;
            return listaCatalogo;
        }
        public List<CatalogoInformacionColonia> validaCatalogoColonias(JsonResult resultadoConsulta)
        {
            List<CatalogoInformacionColonia> listaCatalogo = new List<CatalogoInformacionColonia>();
            if (resultadoConsulta.Mensaje == "Ok" || resultadoConsulta.Mensaje == "")
                listaCatalogo = (List<CatalogoInformacionColonia>)resultadoConsulta.Data;
            return listaCatalogo;
        }


        public List<param_idusuario> validaCatalogoUsuarios(JsonResult resultadoConsulta)
        {
            List<param_idusuario> listaCatalogo = new List<param_idusuario>();
            if (resultadoConsulta.Mensaje == "Ok" || resultadoConsulta.Mensaje == "")
                listaCatalogo = (List<param_idusuario>)resultadoConsulta.Data;
            return listaCatalogo;
        }

        public List<PermisosUsuario> validaCatalogoPermisosUsuario(JsonResult resultadoConsulta)
        {
            List<PermisosUsuario> listaCatalogo = new List<PermisosUsuario>();
            if (resultadoConsulta.Mensaje == "Ok" || resultadoConsulta.Mensaje == "")
                listaCatalogo = (List<PermisosUsuario>)resultadoConsulta.Data;
            return listaCatalogo;
        }

    }
}