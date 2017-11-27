using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Estacion {
        private int id;
        private String nombre;
        private int numeroTrans;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroTrans { get => numeroTrans; set => numeroTrans = value; }
    }
}