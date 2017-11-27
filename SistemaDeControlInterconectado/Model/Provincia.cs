using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Provincia {
        private int id;
        private String nommbre;
        private int regionFK;

        public int Id { get => id; set => id = value; }
        public string Nommbre { get => nommbre; set => nommbre = value; }
        public int RegionFK { get => regionFK; set => regionFK = value; }
    }
}