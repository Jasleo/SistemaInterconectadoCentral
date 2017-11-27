using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class SubEstacion {
        private int id;
        private int lineaFK;

        public int Id { get => id; set => id = value; }
        public int LineaFK { get => lineaFK; set => lineaFK = value; }
    }
}