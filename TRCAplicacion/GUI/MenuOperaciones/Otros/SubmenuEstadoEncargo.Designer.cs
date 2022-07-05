namespace TRCAplicacion.GUI.MenuOperaciones.Otros
{
    partial class SubmenuEstadoEncargo
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gbLlenadoEdicion = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dgvEstadoEncargo = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardarEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gbLlenadoEdicion.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoEncargo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Font = new System.Drawing.Font("Corbel", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(274, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(420, 27);
            this.txtBuscar.TabIndex = 34;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnRefrescar.Location = new System.Drawing.Point(11, 369);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(118, 30);
            this.btnRefrescar.TabIndex = 37;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(752, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 30);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(207, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Buscar:";
            // 
            // gbLlenadoEdicion
            // 
            this.gbLlenadoEdicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbLlenadoEdicion.Controls.Add(this.txtNombre);
            this.gbLlenadoEdicion.Controls.Add(this.label5);
            this.gbLlenadoEdicion.Enabled = false;
            this.gbLlenadoEdicion.Font = new System.Drawing.Font("Corbel", 10F);
            this.gbLlenadoEdicion.Location = new System.Drawing.Point(7, 93);
            this.gbLlenadoEdicion.Name = "gbLlenadoEdicion";
            this.gbLlenadoEdicion.Size = new System.Drawing.Size(724, 109);
            this.gbLlenadoEdicion.TabIndex = 35;
            this.gbLlenadoEdicion.TabStop = false;
            this.gbLlenadoEdicion.Text = "Llenado y edicion";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 12F);
            this.txtNombre.Location = new System.Drawing.Point(111, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDatos.Controls.Add(this.dgvEstadoEncargo);
            this.gbDatos.Font = new System.Drawing.Font("Corbel", 10F);
            this.gbDatos.Location = new System.Drawing.Point(7, 208);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(724, 155);
            this.gbDatos.TabIndex = 36;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // dgvEstadoEncargo
            // 
            this.dgvEstadoEncargo.AllowUserToAddRows = false;
            this.dgvEstadoEncargo.AllowUserToDeleteRows = false;
            this.dgvEstadoEncargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoEncargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre});
            this.dgvEstadoEncargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstadoEncargo.Location = new System.Drawing.Point(3, 20);
            this.dgvEstadoEncargo.MultiSelect = false;
            this.dgvEstadoEncargo.Name = "dgvEstadoEncargo";
            this.dgvEstadoEncargo.ReadOnly = true;
            this.dgvEstadoEncargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadoEncargo.Size = new System.Drawing.Size(718, 132);
            this.dgvEstadoEncargo.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Estado del encargo";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.Enabled = false;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnBorrar.Image = global::TRCAplicacion.Properties.Resources.delete___1487_;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(752, 330);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(118, 30);
            this.btnBorrar.TabIndex = 40;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardarEditar
            // 
            this.btnGuardarEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarEditar.Enabled = false;
            this.btnGuardarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEditar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnGuardarEditar.Image = global::TRCAplicacion.Properties.Resources.save_item___1411_;
            this.btnGuardarEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEditar.Location = new System.Drawing.Point(752, 136);
            this.btnGuardarEditar.Name = "btnGuardarEditar";
            this.btnGuardarEditar.Size = new System.Drawing.Size(118, 30);
            this.btnGuardarEditar.TabIndex = 41;
            this.btnGuardarEditar.Text = "Guardar";
            this.btnGuardarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditar.UseVisualStyleBackColor = true;
            this.btnGuardarEditar.Click += new System.EventHandler(this.btnGuardarEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnBuscar.Image = global::TRCAplicacion.Properties.Resources.search_right___1505_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(576, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 30);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnEditar.Image = global::TRCAplicacion.Properties.Resources.edit___1483_;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(752, 294);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 30);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnNuevo.Location = new System.Drawing.Point(10, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 60);
            this.btnNuevo.TabIndex = 44;
            this.btnNuevo.Text = "Nuevo estado encargo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(752, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(118, 63);
            this.lblCliente.TabIndex = 33;
            this.lblCliente.Text = "Estado\r\nEncargo";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubmenuEstadoEncargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardarEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbLlenadoEdicion);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblCliente);
            this.Name = "SubmenuEstadoEncargo";
            this.Text = "SubmenuEstadoEncargo";
            this.Load += new System.EventHandler(this.SubmenuEstadoEncargo_Load);
            this.gbLlenadoEdicion.ResumeLayout(false);
            this.gbLlenadoEdicion.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoEncargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardarEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbLlenadoEdicion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.DataGridView dgvEstadoEncargo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}