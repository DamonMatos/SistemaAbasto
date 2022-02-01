using Abasto.Data;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static int Nivel;
        public static int IdPersonal;
        public static string NombreCompleto;
        int Estado = 0;

        private void btningresar_Click(object sender, EventArgs e)
        {           
            Data.Produccion Usuario = new Data.Produccion();            
            MenuPrincipal Menu      = new MenuPrincipal();
            try {
                String Usu   = txtUsuario.Text;
                String Cont  = txtcontrasena.Text;
                DataTable Dt = new DataTable();
                Dt = Usuario.InicioSesion(Usu, Cont);
                if (Dt.Rows.Count > 0){                   
                    DataRow Dr = Dt.Rows[0];
                    Estado = int.Parse(Dr["Estado"].ToString());
                    if (Estado == 1){
                        Nivel          = int.Parse(Dr["Nivel"].ToString());
                        IdPersonal     = int.Parse(Dr["IdPersonal"].ToString());
                        NombreCompleto = Dr["NombreCompleto"].ToString();
                        Menu.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show(Dr["Resultado"].ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }                   
                }
                else
                {
                    MessageBox.Show("Problemas de conexion con el servidor de DB", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                txtcontrasena.Text = "";
                txtUsuario.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
