using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Controller {
    /// <summary>
    /// Descripción breve de AsignarServicioRedDeTransmisionHandler
    /// </summary>
    public class AsignarServicioRedDeTransmisionHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "texto/normal";
            context.Response.Write("Hola a todos");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}