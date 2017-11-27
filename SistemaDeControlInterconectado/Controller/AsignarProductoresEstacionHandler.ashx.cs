using SistemaDeControlInterconectado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Controller {
    /// <summary>
    /// Descripción breve de AsignarProductoresEstacionHandler
    /// </summary>
    public class AsignarProductoresEstacionHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            Data d = new Data();

            EntregaEnergia ee = new EntregaEnergia();

            ee.ProductoFK = Int32.Parse(context.Request.Params["cboAsignarProduccion"]);
            ee.EstacionFK = Int32.Parse(context.Request.Params["cboAsignarEstacion"]);
            ee.Fecha = DateTime.Parse(context.Request.Params["txtAsignarFechaEstacion"]);
            ee.Energia = float.Parse(context.Request.Params["txtAsignarEnergia"]);
            

            d.crearEntregaEnergia(ee);

            context.Response.Redirect("../view/Menu.apsx");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}