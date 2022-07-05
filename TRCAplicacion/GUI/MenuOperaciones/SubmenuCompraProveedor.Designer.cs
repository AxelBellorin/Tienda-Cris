namespace TRCAplicacion.GUI.MenuOperaciones
{
    partial class SubmenuCompraProveedor
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
            this.dgvCompraProveedor = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregarProductoLista = new System.Windows.Forms.Button();
            this.btnGuardarEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbLlenadoEdicion = new System.Windows.Forms.GroupBox();
            this.nuCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreCompania = new System.Windows.Forms.TextBox();
            this.txtCodigoCompra = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnQuitarProductoLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraProveedor)).BeginInit();
            this.gbLlenadoEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompraProveedor
            // 
            this.dgvCompraProveedor.AllowUserToAddRows = false;
            this.dgvCompraProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCompraProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.cantidad});
            this.dgvCompraProveedor.Location = new System.Drawing.Point(451, 140);
            this.dgvCompraProveedor.MultiSelect = false;
            this.dgvCompraProveedor.Name = "dgvCompraProveedor";
            this.dgvCompraProveedor.ReadOnly = true;
            this.dgvCompraProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompraProveedor.Size = new System.Drawing.Size(243, 166);
            this.dgvCompraProveedor.TabIndex = 54;
            // 
            // codigoProducto
            // 
            this.codigoProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoProducto.HeaderText = "Codigo del producto";
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 75;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(704, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 30);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(542, 312);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(152, 19);
            this.lblCantidad.TabIndex = 47;
            this.lblCantidad.Text = "Hay 0 Productos";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregarProductoLista
            // 
            this.btnAgregarProductoLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProductoLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductoLista.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnAgregarProductoLista.Location = new System.Drawing.Point(451, 97);
            this.btnAgregarProductoLista.Name = "btnAgregarProductoLista";
            this.btnAgregarProductoLista.Size = new System.Drawing.Size(76, 30);
            this.btnAgregarProductoLista.TabIndex = 51;
            this.btnAgregarProductoLista.Text = "Agregar";
            this.btnAgregarProductoLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductoLista.UseVisualStyleBackColor = true;
            this.btnAgregarProductoLista.Click += new System.EventHandler(this.btnAgregarProductoLista_Click);
            // 
            // btnGuardarEditar
            // 
            this.btnGuardarEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEditar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnGuardarEditar.Image = global::TRCAplicacion.Properties.Resources.save_item___1411_;
            this.btnGuardarEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEditar.Location = new System.Drawing.Point(704, 140);
            this.btnGuardarEditar.Name = "btnGuardarEditar";
            this.btnGuardarEditar.Size = new System.Drawing.Size(118, 30);
            this.btnGuardarEditar.TabIndex = 52;
            this.btnGuardarEditar.Text = "Guardar";
            this.btnGuardarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditar.UseVisualStyleBackColor = true;
            this.btnGuardarEditar.Click += new System.EventHandler(this.btnGuardarEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnNuevo.Image = global::TRCAplicacion.Properties.Resources.profile_plus_round___1324_;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(91, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 60);
            this.btnNuevo.TabIndex = 53;
            this.btnNuevo.Text = "Nueva\r\nCompra";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbLlenadoEdicion
            // 
            this.gbLlenadoEdicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbLlenadoEdicion.Controls.Add(this.nuCantidadProducto);
            this.gbLlenadoEdicion.Controls.Add(this.txtCodigoProducto);
            this.gbLlenadoEdicion.Controls.Add(this.txtPrecio);
            this.gbLlenadoEdicion.Controls.Add(this.txtNombreCompania);
            this.gbLlenadoEdicion.Controls.Add(this.txtCodigoCompra);
            this.gbLlenadoEdicion.Controls.Add(this.lblProducto);
            this.gbLlenadoEdicion.Controls.Add(this.label3);
            this.gbLlenadoEdicion.Controls.Add(this.label1);
            this.gbLlenadoEdicion.Controls.Add(this.label2);
            this.gbLlenadoEdicion.Controls.Add(this.label10);
            this.gbLlenadoEdicion.Controls.Add(this.label5);
            this.gbLlenadoEdicion.Font = new System.Drawing.Font("Corbel", 10F);
            this.gbLlenadoEdicion.Location = new System.Drawing.Point(92, 97);
            this.gbLlenadoEdicion.Name = "gbLlenadoEdicion";
            this.gbLlenadoEdicion.Size = new System.Drawing.Size(353, 267);
            this.gbLlenadoEdicion.TabIndex = 49;
            this.gbLlenadoEdicion.TabStop = false;
            this.gbLlenadoEdicion.Text = "Llenado y edicion";
            // 
            // nuCantidadProducto
            // 
            this.nuCantidadProducto.Font = new System.Drawing.Font("Corbel", 10F);
            this.nuCantidadProducto.Location = new System.Drawing.Point(142, 171);
            this.nuCantidadProducto.Name = "nuCantidadProducto";
            this.nuCantidadProducto.Size = new System.Drawing.Size(64, 24);
            this.nuCantidadProducto.TabIndex = 47;
            this.nuCantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtCodigoProducto.Location = new System.Drawing.Point(142, 141);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(200, 24);
            this.txtCodigoProducto.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtPrecio.Location = new System.Drawing.Point(142, 201);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 24);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtNombreCompania
            // 
            this.txtNombreCompania.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreCompania.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtNombreCompania.Location = new System.Drawing.Point(142, 75);
            this.txtNombreCompania.Name = "txtNombreCompania";
            this.txtNombreCompania.Size = new System.Drawing.Size(200, 24);
            this.txtNombreCompania.TabIndex = 3;
            // 
            // txtCodigoCompra
            // 
            this.txtCodigoCompra.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtCodigoCompra.Location = new System.Drawing.Point(142, 45);
            this.txtCodigoCompra.Name = "txtCodigoCompra";
            this.txtCodigoCompra.Size = new System.Drawing.Size(200, 24);
            this.txtCodigoCompra.TabIndex = 3;
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProducto.AutoSize = true;
            this.lblProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProducto.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.lblProducto.Location = new System.Drawing.Point(139, 111);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(136, 17);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Seleccionar producto";
            this.lblProducto.Click += new System.EventHandler(this.lblProducto_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10F);
            this.label3.Location = new System.Drawing.Point(86, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10F);
            this.label1.Location = new System.Drawing.Point(8, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del producto:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10F);
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre proveedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 10F);
            this.label10.Location = new System.Drawing.Point(71, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10F);
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo de Compra:";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(225, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(593, 63);
            this.lblCliente.TabIndex = 48;
            this.lblCliente.Text = "Compra al proveedor";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitarProductoLista
            // 
            this.btnQuitarProductoLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitarProductoLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProductoLista.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnQuitarProductoLista.Location = new System.Drawing.Point(451, 312);
            this.btnQuitarProductoLista.Name = "btnQuitarProductoLista";
            this.btnQuitarProductoLista.Size = new System.Drawing.Size(76, 30);
            this.btnQuitarProductoLista.TabIndex = 55;
            this.btnQuitarProductoLista.Text = "Quitar";
            this.btnQuitarProductoLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarProductoLista.UseVisualStyleBackColor = true;
            this.btnQuitarProductoLista.Click += new System.EventHandler(this.btnQuitarProductoLista_Click);
            // 
            // SubmenuCompraProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.btnQuitarProductoLista);
            this.Controls.Add(this.dgvCompraProveedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnAgregarProductoLista);
            this.Controls.Add(this.btnGuardarEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbLlenadoEdicion);
            this.Controls.Add(this.lblCliente);
            this.Name = "SubmenuCompraProveedor";
            this.Text = "SubmenuCompraProveedor";
            this.Load += new System.EventHandler(this.SubmenuCompraProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraProveedor)).EndInit();
            this.gbLlenadoEdicion.ResumeLayout(false);
            this.gbLlenadoEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompraProveedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregarProductoLista;
        private System.Windows.Forms.Button btnGuardarEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbLlenadoEdicion;
        private System.Windows.Forms.NumericUpDown nuCantidadProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtCodigoCompra;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCompania;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitarProductoLista;
    }
}