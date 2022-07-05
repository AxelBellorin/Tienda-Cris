using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using TRCAplicacion.Controllers.Producto;

using TRCAplicacion.Controllers.Productos;

namespace TRCAplicacion.GUI.MenuOperaciones.Otros
{
    public partial class SubmenuProductos : Form
    {

        //ProductoC objProductoC = null;
        ProductoC objProductoC = new ProductoC();
        ProductoController objProductoController = null;

        //ProductosC objProductosC = new ProductosC();

        private void mostrarGridProducto()
        {
            DataTable dt = null;

            dgvProducto.Rows.Clear();

            objProductoC = new ProductoC();
            objProductoController = new ProductoController(objProductoC);

            dt = new DataTable();
            dt = objProductoController.mostrarProductos();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvProducto.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][6].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         dt.Rows[i][5].ToString(),
                                         dt.Rows[i][4].ToString());
                }
            }

            lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " productos";
        }

        public SubmenuProductos()
        {
            InitializeComponent();
        }

        private void SubmenuProductos_Load(object sender, EventArgs e)
        {
            mostrarGridProducto();

            cbFiltroProducto.SelectedIndex = 0;

            txtBuscar.Focus();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void SubmenuProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvProducto.SelectedRows.Count == 1)
            {
                ProductosC.CodProducto = dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells[0].Value.ToString();
                ProductosC.StockProducto = int.Parse(dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells[3].Value.ToString());
            }

            else
            {
                MessageBox.Show("Ningun producto seleccionado");
            }
        }

        private void buscar()
        {
            if (txtBuscar.Text != String.Empty)
            {
                try
                {
                    //Se declara un datatable para asignar al grid
                    var tabla = new DataTable();
                    var columna = new DataColumn();

                    //agregar columnas
                    columna = new DataColumn();
                    columna.DataType = typeof(string);
                    //columna.DataType = Type.GetType("String");
                    columna.ColumnName = "codProducto";
                    tabla.Columns.Add(columna);

                    columna = new DataColumn();
                    columna.DataType = typeof(string);
                    //columna.DataType = Type.GetType("String");
                    columna.ColumnName = "categoria";
                    tabla.Columns.Add(columna);

                    columna = new DataColumn();
                    columna.DataType = typeof(String);
                    //columna.DataType = Type.GetType("String");
                    columna.ColumnName = "descripcion";
                    tabla.Columns.Add(columna);

                    columna = new DataColumn();
                    columna.DataType = typeof(String);
                    //columna.DataType = Type.GetType("String");
                    columna.ColumnName = "stock";
                    tabla.Columns.Add(columna);

                    columna = new DataColumn();
                    columna.DataType = typeof(String);
                    //columna.DataType = Type.GetType("String");
                    columna.ColumnName = "marca";
                    tabla.Columns.Add(columna);

                    columna = new DataColumn();
                    columna.DataType = typeof(String);
                    //columna.DataType = Type.GetType("String");
                    columna.ColumnName = "talla";
                    tabla.Columns.Add(columna);

                    // mostrarGridProducto();

                    txtBuscar.Focus();

                    foreach (DataGridViewRow dataGridViewRow in dgvProducto.Rows)
                    {
                        DataRow dataRow = tabla.NewRow();
                        dataRow["codProducto"] = dataGridViewRow.Cells[0].Value.ToString();
                        dataRow["categoria"] = dataGridViewRow.Cells[1].Value.ToString();
                        dataRow["descripcion"] = dataGridViewRow.Cells[2].Value.ToString();
                        dataRow["stock"] = dataGridViewRow.Cells[3].Value.ToString();
                        dataRow["marca"] = dataGridViewRow.Cells[4].Value.ToString();
                        dataRow["talla"] = dataGridViewRow.Cells[5].Value.ToString();

                        tabla.Rows.Add(dataRow);
                    }

                    string filtro = "categoria";

                    if (cbFiltroProducto.SelectedIndex == 0)
                    {
                        filtro = "categoria";
                    }

                    else if (cbFiltroProducto.SelectedIndex == 1)
                    {
                        filtro = "descripcion";
                    }

                    else if (cbFiltroProducto.SelectedIndex == 2)
                    {
                        filtro = "marca";
                    }

                    else if (cbFiltroProducto.SelectedIndex == 3)
                    {
                        filtro = "talla";
                    }

                    //var filtroBuscar = tabla.AsEnumerable().Where(x => x.Field<String>("categoria").ToUpper().Contains(txtBuscar.Text.ToUpper()));
                    var filtroBuscar = tabla.AsEnumerable().Where(x => x.Field<String>(filtro).ToUpper().Contains(txtBuscar.Text.ToUpper()));

                    lblCantidad.Text = "Hay " + tabla.Rows.Count.ToString() + " productos";

                    dgvProducto.Rows.Clear();

                    foreach (var item in filtroBuscar)
                    {
                        dgvProducto.Rows.Add(item.Field<String>(0), item.Field<String>(1), item.Field<String>(2), item.Field<String>(3), item.Field<String>(4), item.Field<String>(5));
                    }
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show(Excepcion.Message);
                }
            }

            else
            {
                mostrarGridProducto();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void cbBuscarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = String.Empty;
            txtBuscar.Focus();
        }
    }
}
