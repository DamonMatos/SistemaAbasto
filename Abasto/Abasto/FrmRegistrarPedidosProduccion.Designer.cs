namespace Abasto
{
    partial class FrmRegistrarPedidosProduccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarPedidosProduccion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtCargoVendedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.dginsumod = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAbastecedor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigoinsumo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.txtproductodescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcanproducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtstockActual = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gbBuscarProducto = new System.Windows.Forms.GroupBox();
            this.dgListarProducto = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginsumod)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbBuscarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(101, 67);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(345, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "N°Pedido:";
            // 
            // txtPedido
            // 
            this.txtPedido.Enabled = false;
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(101, 19);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(190, 20);
            this.txtPedido.TabIndex = 5;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Enabled = false;
            this.txtNombreVendedor.Location = new System.Drawing.Point(97, 19);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(258, 20);
            this.txtNombreVendedor.TabIndex = 6;
            // 
            // txtCargoVendedor
            // 
            this.txtCargoVendedor.Enabled = false;
            this.txtCargoVendedor.Location = new System.Drawing.Point(97, 42);
            this.txtCargoVendedor.Name = "txtCargoVendedor";
            this.txtCargoVendedor.Size = new System.Drawing.Size(202, 20);
            this.txtCargoVendedor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cargo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreVendedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCargoVendedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(465, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 105);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha:";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Enabled = false;
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(101, 42);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(190, 20);
            this.dtpfecha.TabIndex = 19;
            // 
            // dginsumod
            // 
            this.dginsumod.AllowUserToAddRows = false;
            this.dginsumod.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dginsumod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginsumod.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dginsumod.Location = new System.Drawing.Point(12, 239);
            this.dginsumod.Name = "dginsumod";
            this.dginsumod.Size = new System.Drawing.Size(829, 197);
            this.dginsumod.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Abastecedor";
            // 
            // txtAbastecedor
            // 
            this.txtAbastecedor.Enabled = false;
            this.txtAbastecedor.Location = new System.Drawing.Point(101, 93);
            this.txtAbastecedor.Name = "txtAbastecedor";
            this.txtAbastecedor.Size = new System.Drawing.Size(345, 20);
            this.txtAbastecedor.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAbastecedor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.txtPedido);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dtpfecha);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 128);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Codigo Insumo:";
            // 
            // txtcodigoinsumo
            // 
            this.txtcodigoinsumo.Enabled = false;
            this.txtcodigoinsumo.Location = new System.Drawing.Point(113, 187);
            this.txtcodigoinsumo.Name = "txtcodigoinsumo";
            this.txtcodigoinsumo.Size = new System.Drawing.Size(103, 20);
            this.txtcodigoinsumo.TabIndex = 41;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Location = new System.Drawing.Point(307, 187);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(299, 20);
            this.txtdescripcion.TabIndex = 42;
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Enabled = false;
            this.txtPrecioU.Location = new System.Drawing.Point(113, 213);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(103, 20);
            this.txtPrecioU.TabIndex = 43;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.Location = new System.Drawing.Point(667, 192);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(47, 41);
            this.btnagregar.TabIndex = 44;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Precio:";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(707, 464);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(134, 20);
            this.txttotal.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(664, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Total";
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Enabled = false;
            this.txtcodigoproducto.Location = new System.Drawing.Point(113, 135);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(103, 20);
            this.txtcodigoproducto.TabIndex = 48;
            // 
            // txtproductodescripcion
            // 
            this.txtproductodescripcion.Enabled = false;
            this.txtproductodescripcion.Location = new System.Drawing.Point(113, 161);
            this.txtproductodescripcion.Name = "txtproductodescripcion";
            this.txtproductodescripcion.Size = new System.Drawing.Size(300, 20);
            this.txtproductodescripcion.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Codigo Producto:";
            // 
            // txtcanproducto
            // 
            this.txtcanproducto.Enabled = false;
            this.txtcanproducto.Location = new System.Drawing.Point(337, 135);
            this.txtcanproducto.Name = "txtcanproducto";
            this.txtcanproducto.Size = new System.Drawing.Size(76, 20);
            this.txtcanproducto.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(506, 213);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 52;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(612, 192);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 41);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Stock Actual:";
            // 
            // txtstockActual
            // 
            this.txtstockActual.Enabled = false;
            this.txtstockActual.Location = new System.Drawing.Point(307, 213);
            this.txtstockActual.Name = "txtstockActual";
            this.txtstockActual.Size = new System.Drawing.Size(96, 20);
            this.txtstockActual.TabIndex = 56;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(11, 440);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 44);
            this.btnGenerar.TabIndex = 57;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // gbBuscarProducto
            // 
            this.gbBuscarProducto.Controls.Add(this.dgListarProducto);
            this.gbBuscarProducto.Location = new System.Drawing.Point(11, 239);
            this.gbBuscarProducto.Name = "gbBuscarProducto";
            this.gbBuscarProducto.Size = new System.Drawing.Size(829, 197);
            this.gbBuscarProducto.TabIndex = 11;
            this.gbBuscarProducto.TabStop = false;
            this.gbBuscarProducto.Text = "Buscar Insumos";
            this.gbBuscarProducto.Visible = false;
            // 
            // dgListarProducto
            // 
            this.dgListarProducto.AllowUserToAddRows = false;
            this.dgListarProducto.AllowUserToDeleteRows = false;
            this.dgListarProducto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgListarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListarProducto.Location = new System.Drawing.Point(3, 16);
            this.dgListarProducto.Name = "dgListarProducto";
            this.dgListarProducto.Size = new System.Drawing.Size(823, 178);
            this.dgListarProducto.TabIndex = 0;
            this.dgListarProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarProducto_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cantidad Solicitada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Producto:";
            // 
            // FrmRegistrarPedidosProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 487);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbBuscarProducto);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtstockActual);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtcanproducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtproductodescripcion);
            this.Controls.Add(this.txtcodigoproducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtPrecioU);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigoinsumo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dginsumod);
            this.Name = "FrmRegistrarPedidosProduccion";
            this.Text = "Generar Abastecimiento ";
            this.Load += new System.EventHandler(this.FrmRegistrarPedidosProduccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginsumod)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbBuscarProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.TextBox txtCargoVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.DataGridView dginsumod;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAbastecedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtcodigoinsumo;
        public System.Windows.Forms.TextBox txtdescripcion;
        public System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtcodigoproducto;
        public System.Windows.Forms.TextBox txtproductodescripcion;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtcanproducto;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtstockActual;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox gbBuscarProducto;
        private System.Windows.Forms.DataGridView dgListarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
    }
}