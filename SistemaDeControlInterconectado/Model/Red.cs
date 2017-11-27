using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Red {
        private int id;
        private int estacionFK;
        private int volumenEnergia;
        private int minimoEnergia;
        private int maximoEnergia;
        private Boolean FueraDeServicio;

        public int Id { get => id; set => id = value; }
        public int EstacionFK { get => estacionFK; set => estacionFK = value; }
        public int VolumenEnergia { get => volumenEnergia; set => volumenEnergia = value; }
        public int MinimoEnergia { get => minimoEnergia; set => minimoEnergia = value; }
        public int MaximoEnergia { get => maximoEnergia; set => maximoEnergia = value; }
        public bool FueraDeServicio1 { get => FueraDeServicio; set => FueraDeServicio = value; }
    }
}