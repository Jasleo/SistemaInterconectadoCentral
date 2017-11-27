using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Categoria {
        private int id;
        private String nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}