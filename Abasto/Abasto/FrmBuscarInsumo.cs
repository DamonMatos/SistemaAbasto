using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abasto
{
    public partial class FrmBuscarInsumo : Form
    {
        public FrmBuscarInsumo()
        {
            InitializeComponent();
        }
        DataTable Dt = new DataTable();
        Data.Produccion Datos = new Data.Produccion();
        private void txtbuscarproducto_TextChanged(object sender, EventArgs e)
        {          
            Dt = Datos.BuscarInsumos(txtbuscarproducto.Text);
            dgInsumos.DataSource = Dt;
        }

        private void FrmBuscarInsumo_Load(object sender, EventArgs e)
        {            
            Dt = Datos.ListarInsumos();
            dgInsumos.DataSource = Dt;
        }        
    }
}
