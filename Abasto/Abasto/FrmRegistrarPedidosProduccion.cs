using Aspose.Cells;
using Abasto.Data;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace Abasto
{
    public partial class FrmRegistrarPedidosProduccion : Form
    {
        public int NumArticulo;
        public static int IdAbastecedor;
        public static string codigoInsumo;
        public static string NombreInsumo;
        public static int cantidad;
        public static double precioUnitario;

        private DataTable Tabla = new DataTable();

        public FrmRegistrarPedidosProduccion()
        {
            InitializeComponent();
        }

        public FrmRegistrarPedidosProduccion(int NumOperacion, string IdProducto)
        {
            InitializeComponent();
            try
            {
                DataTable dts = new DataTable();
                Data.Produccion dProducion = new Data.Produccion();
                dts = dProducion.BuscarArticuloDetalleProducto(NumOperacion, IdProducto);
                if (dts.Rows.Count > 0)
                {
                    DataRow dr = dts.Rows[0];
                    txtPedido.Text = dr[0].ToString();
                    dtpfecha.Text = dr[2].ToString();
                    txtNombreVendedor.Text = dr[3].ToString();
                    txtCargoVendedor.Text = dr[4].ToString();
                    txtNombreCliente.Text = dr[5].ToString();
                    txtcodigoproducto.Text = dr[6].ToString();
                    txtproductodescripcion.Text = dr[7].ToString();
                    txtcanproducto.Text = dr[8].ToString();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }            
        }

        private void FrmRegistrarPedidosProduccion_Load(object sender, EventArgs e)
        {
            Carrito ObjTabla = new Carrito();
            Produccion DProduccion = new Produccion();
            Tabla = ObjTabla.CrearTabla();
            dginsumod.DataSource = Tabla;
            txtAbastecedor.Text = Login.NombreCompleto;
            IdAbastecedor = Login.IdPersonal;
            dgListarProducto.DataSource = DProduccion.ListarInsumos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbBuscarProducto.Visible = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tabla.Rows.Count > 0)
                {
                    Insumo Insumo = new Insumo();
                    Produccion DProduccion = new Produccion();
                    foreach (DataRow Dr in Tabla.Rows)
                    {
                        Insumo.NumPedido = int.Parse(txtPedido.Text);
                        Insumo.IdProducto = txtcodigoproducto.Text;
                        Insumo.IdInsumo = Dr["CodInsumo"].ToString();
                        Insumo.Cantidad = int.Parse(Dr["Cantidad"].ToString());
                        Insumo.Precio = double.Parse(Dr["Subtotal"].ToString());
                        DProduccion.RegistrarInsumoProducto(Insumo);
                    }
                    ActualizarPedidoPedido();
                }
                else {
                    MessageBox.Show("Agregar Insumos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ActualizarPedidoPedido() {
            String mensaje = String.Empty;
            DataTable Dt = new DataTable();
            DetallePedido Pedido = new DetallePedido();
            Produccion DProduccion = new Produccion();
            Pedido.NumPedido = int.Parse(txtPedido.Text);
            Pedido.IdAbastecedor = IdAbastecedor;
            Pedido.IdProducto = txtcodigoproducto.Text;
            Dt = DProduccion.ActualizarPedidoProducto(Pedido);
            if (Dt.Rows.Count > 0) {
                DataRow Dr =Dt.Rows[0];
                mensaje = Dr["Mensaje"].ToString();
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            String CodigoInsumo = String.Empty;
            String Nombre = String.Empty;
            String Mensaje = String.Empty;
            int estado = 1;
            int StockActual = 0;
            int Cant = 0;
            Double Precio = 0.0;
            Carrito ObjTabla = new Carrito();
            try
            {                          
                CodigoInsumo = txtcodigoinsumo.Text;
                Nombre = txtdescripcion.Text;
                Cant = int.Parse(txtcantidad.Text);
                StockActual = int.Parse(txtstockActual.Text);
                Precio = double.Parse(txtPrecioU.Text);
                if (txtcodigoinsumo.Text == "" && txtstockActual.Text == "" && txtcantidad.Text == "") {
                    MessageBox.Show("Ingrese el Insumo","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (int.Parse(txtstockActual.Text) < int.Parse(txtcantidad.Text))
                    {
                        MessageBox.Show("La Cantidad es Mayor al Stock Actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                       
                    }
                    else {
                         if (dginsumod.Rows.Count == 0)
                         {
                             ObjTabla.AgregarFila(CodigoInsumo, Nombre, Cant, StockActual, Precio, Tabla, ref estado);
                             if(estado == 0)
                             {
                                 MessageBox.Show("La Cantidad es Mayor al Stock Actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                             }
                              dginsumod.DataSource = Tabla;                           
                         }
                         else {
                             ObjTabla.ValidarItems(CodigoInsumo, Nombre,Cant, StockActual, Precio, Tabla,ref estado);
                            if (estado == 0) {
                                ObjTabla.AgregarFila(CodigoInsumo, Nombre, Cant, StockActual, Precio, Tabla, ref estado);
                            }
                             dginsumod.DataSource = Tabla;
                         }                       
                    }                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                txttotal.Text = ObjTabla.CalcularMonto(Tabla).ToString();
            } 
        }

        private void dgListarProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stock =int.Parse(this.dgListarProducto.Rows[e.RowIndex].Cells["StockActual"].Value.ToString());
            if (stock == 0)
            {
                MessageBox.Show("El producto esta suspendido por que el stock actual esta en 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                txtstockActual.Text = stock.ToString();
                txtcodigoinsumo.Text = this.dgListarProducto.Rows[e.RowIndex].Cells["IdInsumo"].Value.ToString();
                txtdescripcion.Text = this.dgListarProducto.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtPrecioU.Text = this.dgListarProducto.Rows[e.RowIndex].Cells["PrecioUnitario"].Value.ToString();
                gbBuscarProducto.Visible = false;
                txtcantidad.Text = "";
                txtcantidad.Focus();
            }
            
        }
    }
}

