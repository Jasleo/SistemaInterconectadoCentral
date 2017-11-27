<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="SistemaDeControlInterconectado.View.Menu" %>

<%@ Import Namespace="SistemaDeControlInterconectado.Model" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <h1>Menu</h1>
    <% Data d = new Data(); %>
    <h2>Produccion</h2>
    <form action="../Controller/CrearProduccionHandler.ashx" method="post">
        Nombre :<input type="text" name="txtNombreProduccion" required="required" />
        <br />
        Produccion Promedio :<input type="number" name="txtProduccionPromedioProduccion" required="required" />
        <br />
        Produccion Maximo :<input type="number" name="txtProduccionMaximoProduccion" required="required" />
        <br />
        Fecha :<input type="text" name="txtFechaEntradaProduccion" required="required" />
        <br />
        Categoria
        <select name="cboCategoriaProduccion">
            <%
                foreach (Categoria cat in d.getCategoria()) {
                    Response.Write("<option name='valorCbo' value='" + cat.Id + "'>" + cat.Nombre + "</option>");
                }%>
        </select>
        <br />
        Disonibilidad
        <br />
        Si :<input type="radio" name="OpDisponible" value="1" required="required" />
        No :<input type="radio" name="OpDisponible" value="0" required="required" />
        <br />
        <input type="submit" value="OK" />
    </form>


    <h2>Estacion</h2>
    <form action="../Controller/CrearEstacionHandler.ashx" method="post">
        NombreEstacion :<input type="text" name="txtNombreEstacion" required="required" />
        <br />
        NumeroDeTransformadores :<input type="number" name="txtNumeroDeTransEstacion" required="required" />
        <br />
        <input type="submit" value="OK" />
    </form>


    <h2>Asignar y/o Eliminar Produccion a Estacion</h2>
    <form action="../Controller/AsignarProductoresEstacionHandler.ashx" method="post">
        Produccion :
        <select name="cboAsignarProduccion">
            <%
                foreach (Producto pro in d.getProducto()) {
                    Response.Write("<option name='valorCbo' value='" + pro.Id + "'>" + pro.Nombre + "</option>");
                }%>
        </select>
        Estacion :
        <select name="cboAsignarEstacion">
            <%
                foreach (Estacion est in d.getEstacion()) {
                    Response.Write("<option name='valorCbo' value='" + est.Id + "'>" + est.Nombre + "</option>");
                }%>
        </select>

        Fecha :<input type="text" name="txtAsignarFechaEstacion" required="required" />
        <br />
        Energia :<input type="number" name="txtAsignarEnergia" required="required" />
        <br />


        <input type="submit" value="OK" />

    </form>


    <h2>Red</h2>
    <form action="../Controller/CrearRedDeTransmisionHandler.ashx" method="post">
        Estacion :
        <select name="cboRedEstacion">
            <%
                foreach (Estacion re in d.getEstacion()) {
                    Response.Write("<option name='valorCbo' value='" + re.Id + "'>" + re.Nombre + "</option>");
                }%>
        </select>

        VolumenEnergia :<input type="number" name="txtRedVolumenEnergia" required="required" />
        <br />
        MinimoEnergia :<input type="number" name="txtRedMinimoEnergia" required="required" />
        <br />
        MaximoEnergia :<input type="number" name="txtRedMaximoEnergia" required="required" />
        <br />
        Disonibilidad De Red:
        <br />
        si :<input type="radio" name="OpDisponibleRed" value="1" required="required" />
        no :<input type="radio" name="OpDisponibleRed" value="0" required="required" />
        <br />
        <input type="submit" value="OK" />
    </form>



    <h2>Ingresar o Sacar Linea</h2>
    <form action="../Controller/AsignarServicioRedDeTransmisionHandler.ashx" method="post">
        Red Estacion :
        <select name="cboRedAsignarLinea">
            <%
                foreach (Red reAsLin in d.getRed()) {
                    Response.Write("<option name='valorCbo' value='" + reAsLin.Id + "'>" + reAsLin.EstacionFK + "</option>");
                }%>
        </select>
        <br />
        Linea :<input type="number" name="txtAsignarLinea" required="required" />
        <br />
        <input type="submit" value="OK" />
    </form>


</body>
</html>
