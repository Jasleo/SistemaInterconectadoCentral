using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Region {
        private int id;
        private String nommbre;

        public int Id { get => id; set => id = value; }
        public string Nommbre { get => nommbre; set => nommbre = value; }
    }
}