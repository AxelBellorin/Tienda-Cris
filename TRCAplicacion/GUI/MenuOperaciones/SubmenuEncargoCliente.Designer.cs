namespace TRCAplicacion.GUI.MenuOperaciones
{
    partial class SubmenuEncargoCliente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnGuardarEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbLlenadoEdicion = new System.Windows.Forms.GroupBox();
            this.nuCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.mtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.cbEstadoEncargo = new System.Windows.Forms.ComboBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoEncargo = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAgregarProductoLista = new System.Windows.Forms.Button();
            this.dgvEncargoCliente = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarProductoLista = new System.Windows.Forms.Button();
            this.gbLlenadoEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(704, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 30);
            this.btnCancelar.TabIndex = 39;
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
            this.lblCantidad.TabIndex = 29;
            this.lblCantidad.Text = "Hay 0 Productos";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnGuardarEditar.TabIndex = 41;
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
            this.btnNuevo.TabIndex = 44;
            this.btnNuevo.Text = "Nuevo\r\nEncargo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbLlenadoEdicion
            // 
            this.gbLlenadoEdicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbLlenadoEdicion.Controls.Add(this.nuCantidadProducto);
            this.gbLlenadoEdicion.Controls.Add(this.mtbCedula);
            this.gbLlenadoEdicion.Controls.Add(this.cbTipoPago);
            this.gbLlenadoEdicion.Controls.Add(this.cbEstadoEncargo);
            this.gbLlenadoEdicion.Controls.Add(this.txtCodigoProducto);
            this.gbLlenadoEdicion.Controls.Add(this.txtCodigoEncargo);
            this.gbLlenadoEdicion.Controls.Add(this.lblProducto);
            this.gbLlenadoEdicion.Controls.Add(this.label1);
            this.gbLlenadoEdicion.Controls.Add(this.label9);
            this.gbLlenadoEdicion.Controls.Add(this.label10);
            this.gbLlenadoEdicion.Controls.Add(this.label7);
            this.gbLlenadoEdicion.Controls.Add(this.label6);
            this.gbLlenadoEdicion.Controls.Add(this.label5);
            this.gbLlenadoEdicion.Font = new System.Drawing.Font("Corbel", 10F);
            this.gbLlenadoEdicion.Location = new System.Drawing.Point(92, 97);
            this.gbLlenadoEdicion.Name = "gbLlenadoEdicion";
            this.gbLlenadoEdicion.Size = new System.Drawing.Size(353, 267);
            this.gbLlenadoEdicion.TabIndex = 35;
            this.gbLlenadoEdicion.TabStop = false;
            this.gbLlenadoEdicion.Text = "Llenado y edicion";
            this.gbLlenadoEdicion.Enter += new System.EventHandler(this.gbLlenadoEdicion_Enter);
            // 
            // nuCantidadProducto
            // 
            this.nuCantidadProducto.Font = new System.Drawing.Font("Corbel", 10F);
            this.nuCantidadProducto.Location = new System.Drawing.Point(140, 211);
            this.nuCantidadProducto.Name = "nuCantidadProducto";
            this.nuCantidadProducto.Size = new System.Drawing.Size(64, 24);
            this.nuCantidadProducto.TabIndex = 47;
            this.nuCantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCedula
            // 
            this.mtbCedula.Font = new System.Drawing.Font("Corbel", 10F);
            this.mtbCedula.Location = new System.Drawing.Point(140, 92);
            this.mtbCedula.Mask = "000-000000-0000?";
            this.mtbCedula.Name = "mtbCedula";
            this.mtbCedula.Size = new System.Drawing.Size(200, 24);
            this.mtbCedula.TabIndex = 7;
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoPago.Font = new System.Drawing.Font("Corbel", 10F);
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(140, 122);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(200, 23);
            this.cbTipoPago.TabIndex = 6;
            // 
            // cbEstadoEncargo
            // 
            this.cbEstadoEncargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoEncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstadoEncargo.Font = new System.Drawing.Font("Corbel", 10F);
            this.cbEstadoEncargo.FormattingEnabled = true;
            this.cbEstadoEncargo.Location = new System.Drawing.Point(140, 63);
            this.cbEstadoEncargo.Name = "cbEstadoEncargo";
            this.cbEstadoEncargo.Size = new System.Drawing.Size(200, 23);
            this.cbEstadoEncargo.TabIndex = 6;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtCodigoProducto.Location = new System.Drawing.Point(140, 181);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(200, 24);
            this.txtCodigoProducto.TabIndex = 3;
            // 
            // txtCodigoEncargo
            // 
            this.txtCodigoEncargo.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtCodigoEncargo.Location = new System.Drawing.Point(140, 33);
            this.txtCodigoEncargo.Name = "txtCodigoEncargo";
            this.txtCodigoEncargo.Size = new System.Drawing.Size(200, 24);
            this.txtCodigoEncargo.TabIndex = 3;
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProducto.AutoSize = true;
            this.lblProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProducto.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.lblProducto.Location = new System.Drawing.Point(137, 154);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(136, 17);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Seleccionar producto";
            this.lblProducto.Click += new System.EventHandler(this.lblProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10F);
            this.label1.Location = new System.Drawing.Point(3, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 10F);
            this.label9.Location = new System.Drawing.Point(45, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 10F);
            this.label10.Location = new System.Drawing.Point(66, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 10F);
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado del encargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 10F);
            this.label6.Location = new System.Drawing.Point(17, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cedula del cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10F);
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo del encargo:";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(225, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(593, 63);
            this.lblCliente.TabIndex = 33;
            this.lblCliente.Text = "Encargo del Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarProductoLista
            // 
            this.btnAgregarProductoLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProductoLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductoLista.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnAgregarProductoLista.Location = new System.Drawing.Point(451, 97);
            this.btnAgregarProductoLista.Name = "btnAgregarProductoLista";
            this.btnAgregarProductoLista.Size = new System.Drawing.Size(76, 30);
            this.btnAgregarProductoLista.TabIndex = 41;
            this.btnAgregarProductoLista.Text = "Agregar";
            this.btnAgregarProductoLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductoLista.UseVisualStyleBackColor = true;
            this.btnAgregarProductoLista.Click += new System.EventHandler(this.btnAgregarProductoLista_Click);
            // 
            // dgvEncargoCliente
            // 
            this.dgvEncargoCliente.AllowUserToAddRows = false;
            this.dgvEncargoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEncargoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.cantidad});
            this.dgvEncargoCliente.Location = new System.Drawing.Point(451, 140);
            this.dgvEncargoCliente.MultiSelect = false;
            this.dgvEncargoCliente.Name = "dgvEncargoCliente";
            this.dgvEncargoCliente.ReadOnly = true;
            this.dgvEncargoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncargoCliente.Size = new System.Drawing.Size(243, 166);
            this.dgvEncargoCliente.TabIndex = 46;
            this.dgvEncargoCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncargoCliente_CellContentClick);
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
            // btnQuitarProductoLista
            // 
            this.btnQuitarProductoLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitarProductoLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProductoLista.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnQuitarProductoLista.Location = new System.Drawing.Point(451, 312);
            this.btnQuitarProductoLista.Name = "btnQuitarProductoLista";
            this.btnQuitarProductoLista.Size = new System.Drawing.Size(76, 30);
            this.btnQuitarProductoLista.TabIndex = 41;
            this.btnQuitarProductoLista.Text = "Quitar";
            this.btnQuitarProductoLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarProductoLista.UseVisualStyleBackColor = true;
            this.btnQuitarProductoLista.Click += new System.EventHandler(this.btnQuitarProductoLista_Click);
            // 
            // SubmenuEncargoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.dgvEncargoCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnQuitarProductoLista);
            this.Controls.Add(this.btnAgregarProductoLista);
            this.Controls.Add(this.btnGuardarEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbLlenadoEdicion);
            this.Controls.Add(this.lblCliente);
            this.Name = "SubmenuEncargoCliente";
            this.Text = "SubmenuEncargoCliente";
            this.Load += new System.EventHandler(this.SubmenuEncargoCliente_Load);
            this.gbLlenadoEdicion.ResumeLayout(false);
            this.gbLlenadoEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidadProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargoCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGuardarEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbLlenadoEdicion;
        private System.Windows.Forms.TextBox txtCodigoEncargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.ComboBox cbEstadoEncargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarProductoLista;
        private System.Windows.Forms.DataGridView dgvEncargoCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.MaskedTextBox mtbCedula;
        private System.Windows.Forms.NumericUpDown nuCantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnQuitarProductoLista;
    }
}