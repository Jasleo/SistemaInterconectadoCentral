using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Zona {
        private int id;
        private String nombre;
        private int provinciaFK;
        private int subEstacionFK;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int ProvinciaFK { get => provinciaFK; set => provinciaFK = value; }
        public int SubEstacionFK { get => subEstacionFK; set => subEstacionFK = value; }
    }
}