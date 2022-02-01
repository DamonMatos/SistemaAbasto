using Aspose.Cells;
using Abasto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abasto
{
    public partial class FrmListarPedidosProduccion : Form
    {
        DataTable Dt = new DataTable();
        public FrmListarPedidosProduccion()
        {
            InitializeComponent();
        }
        private void FrmListarPedidosProduccion_Load(object sender, EventArgs e)
        {
            this.cargar();
        }


        public void cargar()
        {
            Data.Produccion dProducion = new Data.Produccion();
            try
            {
                DataGridViewButtonColumn Coldescargar = new DataGridViewButtonColumn();
                Coldescargar.Name = "Descargar";
                Coldescargar.HeaderText = "Descargar";
                this.dgListarProduccion.Columns.Add(Coldescargar);

                DataGridViewButtonColumn ColAbrir = new DataGridViewButtonColumn();
                ColAbrir.Name = "Mostrar";
                ColAbrir.HeaderText = "Mostrar";
                this.dgListarProduccion.Columns.Add(ColAbrir);

                Dt = dProducion.ListarPedidoCabecerra();
                dgListarProduccion.DataSource = Dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AbrirFormulario(int NumOperacion,string IdProducto)
        {
            try
            {
                FrmRegistrarPedidosProduccion FrmRegistro = new FrmRegistrarPedidosProduccion(NumOperacion,IdProducto);
                FrmRegistro.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DetallePedido(int NumOperacion)
        {
            try
            {
                dgdetalle.Columns.Clear();
                DataTable dt = new DataTable();
                dt.Clear();
                Data.Produccion data = new Data.Produccion();
                dt = data.ListarPedidoCabecerraDetalle(NumOperacion);
                dgdetalle.DataSource = dt;
                DataGridViewButtonColumn ColAbrir = new DataGridViewButtonColumn();
                ColAbrir.Name = "Abrir";
                ColAbrir.HeaderText = "Abrir";
                this.dgdetalle.Columns.Add(ColAbrir);
                dgdetalle.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DescargarReporte(int NumPedido)
        {
            Data.Produccion dProducion = new Data.Produccion();
            String pathTemplate = String.Empty;
            String ruta = String.Empty;
            int Fila = 0;
            Workbook book = null;
            Worksheet pReporte = null;
            try
            {
                DataSet ds = new DataSet();
                ds = dProducion.ReporteBuscarPedido(NumPedido);
                ruta = Path.Combine(Path.GetTempPath(), "ReporteDiario.xlsx");
                if (ds.Tables[0].Rows.Count > 0 || ds.Tables[1].Rows.Count > 0)
                {
                    Aspose.Cells.License license = new Aspose.Cells.License();
                    license.SetLicense("Aspose.Cells.lic");
                    pathTemplate = AppDomain.CurrentDomain.BaseDirectory + @"Resources\" + "plantilla.xlsx";
                    book = new Workbook(pathTemplate);
                    Aspose.Cells.Worksheet wstemplate = book.Worksheets[0];
                    book.Worksheets.Clear();
                    pReporte = book.Worksheets.Add("Reporte Diario");
                    pReporte.Copy(wstemplate);

                    DataRow vrows = ds.Tables[0].Rows[0];
                    pReporte.Cells[3, 2].Value = vrows[5].ToString();
                    pReporte.Cells[3, 5].Value = vrows[2].ToString();
                    pReporte.Cells[5, 2].Value = vrows[3].ToString();
                    pReporte.Cells[5, 5].Value = vrows[6].ToString();

                    Fila = 8;
                    foreach (DataRow Dr in ds.Tables[1].Rows)
                    {
                        pReporte.Cells[Fila, 1].Value = Dr[8].ToString();
                        pReporte.Cells[Fila, 2].Value = Dr[4].ToString();
                        pReporte.Cells[Fila, 3].Value = Dr[1].ToString();
                        pReporte.Cells[Fila, 4].Value = Dr[2].ToString();
                        pReporte.Cells[Fila, 5].Value = Dr[3].ToString();
                        pReporte.Cells[Fila, 6].Value = Dr[5].ToString();
                        pReporte.Cells[Fila, 7].Value = Dr[6].ToString();
                        pReporte.Cells[Fila, 8].Value = Dr[7].ToString();
                        Fila++;
                    }
                }
                book.Save(ruta);
                Process.Start(ruta);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }




        private void dgListarProduccion_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgListarProduccion.Columns[e.ColumnIndex].Name == "Descargar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dgListarProduccion.Rows[e.RowIndex].Cells["Descargar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\excel.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left +3 , e.CellBounds.Top + 3);
                this.dgListarProduccion.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dgListarProduccion.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }

           else if (e.ColumnIndex >= 0 && this.dgListarProduccion.Columns[e.ColumnIndex].Name == "Mostrar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dgListarProduccion.Rows[e.RowIndex].Cells["Mostrar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\open.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left +3 , e.CellBounds.Top + 3);
                this.dgListarProduccion.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dgListarProduccion.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }

        }

        private void dgdetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int NumPedido = 0;
            string Idproducto = string.Empty;
            string Estado = string.Empty;
            try
            {
                int indice = e.ColumnIndex;
                if (indice != -1)
                {
                   if (this.dgdetalle.Columns[e.ColumnIndex].Name == "Abrir"){
                        NumPedido = (int)this.dgdetalle.Rows[e.RowIndex].Cells["NumPedido"].Value;
                        Idproducto = this.dgdetalle.Rows[e.RowIndex].Cells["IdProducto"].Value.ToString();
                        Estado = this.dgdetalle.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                        if (Estado.Equals("Pendiente"))
                        {
                            this.AbrirFormulario(NumPedido, Idproducto);
                        }
                        else if (Estado.Equals("Generado"))
                        {
                            MessageBox.Show("Ya se Genero por ende no se podra Abrir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Se Encuentra Anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }

        private void dgdetalle_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgdetalle.Columns[e.ColumnIndex].Name == "Abrir" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dgdetalle.Rows[e.RowIndex].Cells["Abrir"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\abrir.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.dgdetalle.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dgdetalle.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }
        }

        private void dgListarProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int NumPedido = 0;
            try
            {
                int indice = e.ColumnIndex;
                if (indice != -1)
                {
                    if (this.dgListarProduccion.Columns[e.ColumnIndex].Name == "Descargar")
                    {
                        NumPedido = (int)this.dgListarProduccion.Rows[e.RowIndex].Cells["NumPedido"].Value;
                        //NumOperacion = int.Parse(dgListarProduccion.Rows[dgListarProduccion.CurrentRow.Index].Cells[0].Value.ToString()); //
                        this.DescargarReporte(NumPedido);
                    }
                    else if (this.dgListarProduccion.Columns[e.ColumnIndex].Name == "Mostrar")
                    {
                        NumPedido = (int)this.dgListarProduccion.Rows[e.RowIndex].Cells["NumPedido"].Value;
                        this.DetallePedido(NumPedido);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }
    }
}
