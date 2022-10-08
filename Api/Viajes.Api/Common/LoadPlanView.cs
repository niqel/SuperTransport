using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;
using Viajes.Api.Enums.Metrics;

namespace Viajes.Api.Common
{
    public static class LoadPlanView
    {
        private static List<VwPlanCarga> LoadPlanViewList;
        public static List<VwPlanCarga> GetLoadPlanView(TmsTcEntities context, int truckType)
        {
            switch (truckType)
            {
                case (int)TruckTypes.TF:
                    GetLoadPlanViewTrFull(context);
                    break;
                case (int) TruckTypes.TS: 
                    GetLoadPlanViewTrSemiFull(context);
                    break;
                default: 
                    LoadPlanViewList = context.VwPlanCarga.ToList();
                    break;
            }
            return LoadPlanViewList;
        }


        private static List<VwPlanCarga> GetLoadPlanViewTrFull(TmsTcEntities context)
        {
            LoadPlanViewList = context.VwPlanCargaTrFull.Select(vw => new VwPlanCarga
            {
                Fecha = vw.Fecha,
                Oficina = vw.Oficina,
                Mercado = vw.Mercado,
                Demanda = vw.Demanda,
                Posicionado = vw.Posicionado,
                Arribo = vw.Arribo,
                Faltante = (int) vw.Faltante,
                Total = vw.Total
            }).ToList();
            return LoadPlanViewList;
        }

        private static List<VwPlanCarga> GetLoadPlanViewTrSemiFull(TmsTcEntities context)
        {
            LoadPlanViewList = context.VwPlanCargaTrSemiFull.Select(vw => new VwPlanCarga
            {
                Fecha = vw.Fecha,
                Oficina = vw.Oficina,
                Mercado = vw.Mercado,
                Demanda = vw.Demanda,
                Posicionado = vw.Posicionado,
                Arribo = vw.Arribo,
                Faltante = (int) vw.Faltante,
                Total = vw.Total
            }).ToList();
            return LoadPlanViewList;
        }
    }
}
