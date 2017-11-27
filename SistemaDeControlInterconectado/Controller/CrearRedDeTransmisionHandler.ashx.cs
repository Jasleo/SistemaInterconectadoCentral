using SistemaDeControlInterconectado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Controller {
    /// <summary>
    /// Descripción breve de CrearRedDeTransmisionHandler
    /// </summary>
    public class CrearRedDeTransmisionHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            Data d = new Data();

            Red r = new Red();

            r.EstacionFK = Int32.Parse(context.Request.Params["cboRedEstacion"]);
            r.VolumenEnergia = Int32.Parse(context.Request.Params["txtRedVolumenEnergia"]);
            r.MinimoEnergia = Int32.Parse(context.Request.Params["txtRedMinimoEnergia"]);
            r.MinimoEnergia = Int32.Parse(context.Request.Params["txtRedMaximoEnergia"]);
            r.FueraDeServicio1 = Boolean.Parse(context.Request.Params["OpDisponibleRed"]);

            d.crearRed(r);

            context.Response.Redirect("../view/Menu.apsx");


        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}