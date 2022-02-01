namespace Abasto
{
    partial class FrmListarPedidosProduccion
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
            this.dgListarProduccion = new System.Windows.Forms.DataGridView();
            this.dgdetalle = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListarProduccion
            // 
            this.dgListarProduccion.AllowUserToAddRows = false;
            this.dgListarProduccion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgListarProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListarProduccion.Location = new System.Drawing.Point(3, 3);
            this.dgListarProduccion.Name = "dgListarProduccion";
            this.dgListarProduccion.Size = new System.Drawing.Size(586, 424);
            this.dgListarProduccion.TabIndex = 0;
            this.dgListarProduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarProduccion_CellClick);
            this.dgListarProduccion.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgListarProduccion_CellPainting_1);
            // 
            // dgdetalle
            // 
            this.dgdetalle.AllowUserToAddRows = false;
            this.dgdetalle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdetalle.Location = new System.Drawing.Point(595, 3);
            this.dgdetalle.Name = "dgdetalle";
            this.dgdetalle.Size = new System.Drawing.Size(657, 424);
            this.dgdetalle.TabIndex = 1;
            this.dgdetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdetalle_CellClick);
            this.dgdetalle.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgdetalle_CellPainting);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.749F));
            this.tableLayoutPanel1.Controls.Add(this.dgListarProduccion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgdetalle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 430);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FrmListarPedidosProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListarPedidosProduccion";
            this.Text = "Listado de Pedidos Pendientes";
            this.Load += new System.EventHandler(this.FrmListarPedidosProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListarProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalle)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgListarProduccion;
        public System.Windows.Forms.DataGridView dgdetalle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}