using SistemaDeControlInterconectado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Controller {
    /// <summary>
    /// Descripción breve de CrearEstacionHandler
    /// </summary>
    public class CrearEstacionHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            Data d = new Data();

            Estacion e = new Estacion();

            e.Nombre = context.Request.Params["txtNombreEstacion"];
            e.NumeroTrans = Int32.Parse(context.Request.Params["txtNumeroDeTransEstacion"]);

            d.crearEstacion(e);

            context.Response.Redirect("../view/Menu.apsx");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}