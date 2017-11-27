using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class EntregaEnergia {
        private int id;
        private int estacionFK;
        private int productoFK;
        private DateTime fecha;
        private  float energia;

        public int Id { get => id; set => id = value; }
        public int EstacionFK { get => estacionFK; set => estacionFK = value; }
        public int ProductoFK { get => productoFK; set => productoFK = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Energia { get => energia; set => energia = value; }
    }
}