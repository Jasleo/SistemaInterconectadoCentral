using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Producto {
        private int id;
        private String nombre;
        private int produccionPromedio;
        private int produccionMaximo;
        private DateTime fechaEntrada;
        private int categoriaFK;
        private Boolean disponible;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int ProduccionPromedio { get => produccionPromedio; set => produccionPromedio = value; }
        public int ProduccionMaximo { get => produccionMaximo; set => produccionMaximo = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public int CategoriaFK { get => categoriaFK; set => categoriaFK = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
    }
}