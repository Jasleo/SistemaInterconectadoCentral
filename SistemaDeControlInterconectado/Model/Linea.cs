using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Linea {
        private int id;
        private int redFK;
        private int lonigtud;

        public int Id { get => id; set => id = value; }
        public int RedFK { get => redFK; set => redFK = value; }
        public int Lonigtud { get => lonigtud; set => lonigtud = value; }
    }
}