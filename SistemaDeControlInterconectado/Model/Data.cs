using SistemaElectoral.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControlInterconectado.Model {
    public class Data {
        private Conexion con;
        private String query;

        public Data() {
            con = new Conexion("sistemaInterconectadoCentral");
        }

        public List<Categoria> getCategoria() {
            List<Categoria> lista = new List<Categoria>();
            Categoria c;
            query = "SELECT * FROM categoria ;";

            con.Ejecutar(query);

            while (con.rs.Read()) {
                c = new Categoria();

                c.Id = con.rs.GetInt32(0);
                c.Nombre = con.rs.GetString(1);

                lista.Add(c);

            }
            con.Cerrar();
            return lista;
        }

        public List<Producto> getProducto() {
            List<Producto> lista = new List<Producto>();
            Producto pr;
            query = "SELECT * FROM producto;";

            con.Ejecutar(query);

            while (con.rs.Read()) {
                pr = new Producto();

                pr.Id = con.rs.GetInt32(0);
                pr.Nombre = con.rs.GetString(1);
                pr.ProduccionPromedio = con.rs.GetInt32(2);
                pr.ProduccionMaximo = con.rs.GetInt32(3);
                pr.FechaEntrada = con.rs.GetDateTime(4);
                pr.Disponible = con.rs.GetBoolean(5);

                lista.Add(pr);
            }
            con.Cerrar();
            return lista;
        }

        public List<Estacion> getEstacion() {
            List<Estacion> lista = new List<Estacion>();
            Estacion e;
            query = "SELECT * FROM estacion ;";

            con.Ejecutar(query);

            while (con.rs.Read()) {
                e = new Estacion();

                e.Id = con.rs.GetInt32(0);
                e.Nombre = con.rs.GetString(1);
                e.NumeroTrans = con.rs.GetInt32(2);

                lista.Add(e);

            }
            con.Cerrar();
            return lista;
        }

        public List<EntregaEnergia> getEntregaEstacion() {
            List<EntregaEnergia> lista = new List<EntregaEnergia>();
            EntregaEnergia e;
            query = "SELECT * FROM entregaEnergia ;";
            con.Ejecutar(query);

            while (con.rs.Read()) {
                e = new EntregaEnergia();

                e.Id = con.rs.GetInt32(0);
                e.EstacionFK = con.rs.GetInt32(1);
                e.ProductoFK = con.rs.GetInt32(2);
                e.Fecha = con.rs.GetDateTime(3);
                e.Energia = con.rs.GetFloat(4);

                lista.Add(e);

            }
            con.Cerrar();
            return lista;
        }

        public List<Red> getRed() {
            List<Red> lista = new List<Red>();
            Red e;
            query = "SELECT * FROM red ;";
            con.Ejecutar(query);

            while (con.rs.Read()) {
                e = new Red();

                e.Id = con.rs.GetInt32(0);
                e.EstacionFK = con.rs.GetInt32(1);
                e.VolumenEnergia = con.rs.GetInt32(2);
                e.MinimoEnergia = con.rs.GetInt32(3);
                e.MaximoEnergia = con.rs.GetInt32(4);
                e.FueraDeServicio1 = con.rs.GetBoolean(5);

                lista.Add(e);

            }
            con.Cerrar();
            return lista;
        }

        public void crearProducto(Producto pro) {

            query = "INSERT INTO producto VALUES('" + pro.Nombre + "','" + pro.ProduccionPromedio + "','" + pro.ProduccionMaximo + "','" + pro.FechaEntrada + "','" + pro.CategoriaFK + "', '" + pro.Disponible + "')";

            con.Ejecutar(query);
            con.Cerrar();
        }

        public void crearEstacion(Estacion est) {

            query = "INSERT INTO estacion VALUES('" + est.Nombre + "','" + est.NumeroTrans + "')";

            con.Ejecutar(query);
            con.Cerrar();
        }

        public void crearEntregaEnergia(EntregaEnergia ee) {

            query = "INSERT INTO entregaEnergia VALUES('" + ee.EstacionFK + "','" + ee.ProductoFK + "','" + ee.Fecha + "','" + ee.Energia + "')";

            con.Ejecutar(query);
            con.Cerrar();
        }

        public void updateEntregaEnergia(int estacionFK, int productoFKnueva, int id) {
            query = "UPDATE entregaEnergia SET productoFK = " + productoFKnueva + " , WHERE id = '" + id + "' AND estacionFK = " + estacionFK + " ";


            con.Ejecutar(query);
            con.Cerrar();
        }

        public void eliminarEntregaEnergia(int id) {
            query = "DELETE FROM entregaEnergia WHERE id = '" + id + "'";
            con.Ejecutar(query);
            con.Cerrar();
        }

        public void crearRed(Red r) {
            query = "INSERT INTO red VALUES('" + r.EstacionFK + "','" + r.VolumenEnergia + "','" + r.MinimoEnergia + "','" + r.MaximoEnergia + "','" + r.FueraDeServicio1 + "')";

            con.Ejecutar(query);
            con.Cerrar();
        }

        public void updateSacarDeServicio(int id, Boolean servicio) {
            query = "UPDATE red SET fueraDeServicio = " + servicio + " , WHERE id = '" + id + "'";

            con.Ejecutar(query);
            con.Cerrar();

        }
    }
}