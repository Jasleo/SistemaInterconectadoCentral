using SistemaDeControlInterconectado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Controller {
    /// <summary>
    /// Descripción breve de CrearProduccionHandler
    /// </summary>
    public class CrearProduccionHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            Data d = new Data();

            Producto p = new Producto();

            p.Nombre = context.Request.Params["txtNombreProduccion"];
            p.ProduccionPromedio = Int32.Parse(context.Request.Params["txtProduccionPromedioProduccion"]);
            p.ProduccionMaximo = Int32.Parse(context.Request.Params["txtProduccionMaximoProduccion"]);
            p.FechaEntrada = DateTime.Parse(context.Request.Params["txtFechaEntradaProduccion"]);
            p.CategoriaFK = Int32.Parse(context.Request.Params["cboCategoriaProduccion"]);
            
            p.Disponible = Boolean.Parse(context.Request.Params["OpDisponible"]);

            d.crearProducto(p);

            context.Response.Redirect("../view/Menu.apsx");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}