using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Abasto.Data
{
   public class Produccion
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public DataTable InicioSesion(String Usu, String Clav)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_InicioSesion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", Usu);
            cmd.Parameters.AddWithValue("@Clave", Clav);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable ListarPedidoCabecerra()
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ListarPedidosCabecera", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable ListarPedidoCabecerraDetalle(int numpedido)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ListarPedidosCabeceraDetalle", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumPedido", numpedido);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }



        public DataTable ListarInsumos()
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ListarInsumos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable BuscarInsumos(string Descripcion)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ListarBuscarInsumos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable BuscarArticuloDetalleProducto(int NumPedido,string IdProducto)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ListarPedidosCabeceraDetalleProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumPedido", NumPedido);
            cmd.Parameters.AddWithValue("@Idproducto", IdProducto);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        public DataSet ReporteBuscarPedido(int NumPedido)
        {
            DataSet Dt = new DataSet();
            SqlCommand cmd = new SqlCommand("Sp_ReporteGeneracionPedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumPedido", NumPedido);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable ActualizarPedidoProducto(DetallePedido Detalle)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ActualizarPedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumPedido", Detalle.NumPedido);
            cmd.Parameters.AddWithValue("@Idproducto", Detalle.IdProducto);
            cmd.Parameters.AddWithValue("@IdAbastecedor", Detalle.IdAbastecedor);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            return Dt;
         }


        public void RegistrarInsumoProducto(Insumo Insumo)
        {
            DataTable Dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_registrarInsumo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumPedido", Insumo.NumPedido);
            cmd.Parameters.AddWithValue("@Idproducto", Insumo.IdProducto);
            cmd.Parameters.AddWithValue("@IdInsumo", Insumo.IdInsumo);
            cmd.Parameters.AddWithValue("@cantidad", Insumo.Cantidad);
            cmd.Parameters.AddWithValue("@subtotal", Insumo.Precio);
            cn.Open();
            try{
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                cn.Close();
            }

        }

    }
}
