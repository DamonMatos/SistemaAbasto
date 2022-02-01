using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abasto
{
   public class Carrito
    {

        public DataTable CrearTabla() {
            DataTable dt = new DataTable();
            dt.Columns.Add("Items", typeof(Int16));
            dt.Columns.Add("CodInsumo", typeof(String));
            dt.Columns.Add("Descripcion", typeof(String));
            dt.Columns.Add("Cantidad", typeof(Int32));
            dt.Columns.Add("Precio", typeof(Double));
            dt.Columns.Add("Subtotal", typeof(Double), "Precio * Cantidad");
            return dt;
        }
      


        public void AgregarFila(String codigo, String Desc, int Cant,int Stock, Double Precio, DataTable Dts, ref int Estado) {
            if (Cant > Stock)
            {
                Estado = 0;
            }
            else {
                DataRow dr = Dts.NewRow();
                dr["Items"] = Dts.Rows.Count + 1;
                dr["CodInsumo"] = codigo;
                dr["Descripcion"] = Desc;
                dr["Cantidad"] = Cant;
                dr["Precio"] = Precio;
                Dts.Rows.Add(dr);
                Estado = 1;
            }
           
        }

        //public void AgregarItemsTable(String codigo, String Desc, int Cant, int StockActual, Double Precio, DataTable Dts)
        //{
        //    try
        //    {
        //        int Acumulador = 0;
        //        int Cantidadtotal = 0;
        //        for (int x = 0; x <= Dts.Rows.Count - 1; x++)
        //        {
        //            if (Dts.Rows[x]["CodInsumo"].ToString() == codigo)
        //            {
        //                Acumulador = int.Parse(Dts.Rows[x]["Cantidad"].ToString());
        //                Cantidadtotal = Acumulador + Cant;
        //                Dts.Rows[x]["Cantidad"] = Cantidadtotal;
        //            }
        //        }
        //        //String Expresion = String.Format("CodInsumo={0}", codigo);
        //        //DataRow[] dr = Dts.Select(Expresion);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void ValidarItems(String codigo, String Nombre, int Cantidad, int stockActual, Double Precio, DataTable Dts, ref int Estado)
        {
            int cantidadsumada = 0;
            DataRow Fila;
            Estado = 0;
            try
            {
                for (int x = 0; x <= Dts.Rows.Count - 1; x++)
                {
                    Fila = Dts.Rows[x];
                    if (Dts.Rows[x]["CodInsumo"].ToString() == codigo)
                    {
                        cantidadsumada = int.Parse(Dts.Rows[x]["Cantidad"].ToString()) + Cantidad;
                        Fila["Cantidad"] = cantidadsumada;
                        Estado = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Double CalcularMonto(DataTable dts) {
            Double Total = 0;
            try
            {
                foreach (DataRow dr in dts.Rows) {
                    Total = Total + double.Parse(dr["Subtotal"].ToString());
                } 
            }
            catch (Exception ex) {
                throw ex;
            }
            return Total;
        }
    }
}
