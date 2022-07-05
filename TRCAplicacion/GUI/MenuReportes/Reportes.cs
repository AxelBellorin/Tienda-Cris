using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TRCAplicacion.Controllers.Reportes;

namespace TRCAplicacion.GUI.MenuReportes
{
    public partial class Reportes : Form
    {
        ReportesControllers objReportesControllers= null;
        DataTable dt = null;

        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            lblCantidadVenta.Text = cantidadVenta();
            lblTotalVenta.Text = totalVenta();
            productoBajoStock();
        }

        public string cantidadVenta()
        {
            objReportesControllers = new ReportesControllers();
            dt = objReportesControllers.ejecutarConsulta("select count(p.\"Pedido_Id\") from venta.\"Pedido\" p where p.\"Fecha_Pedido\"::date = current_date;");

            return dt.Rows[0][0].ToString();
        }

        public string totalVenta()
        {
            objReportesControllers = new ReportesControllers();
            dt = objReportesControllers.ejecutarConsulta("select sum(p.\"Total\") from venta.\"Pedido\" p where p.\"Fecha_Pedido\"::date = current_date;");

            return dt.Rows[0][0].ToString();
        }

        public void productoBajoStock()
        {
            //Se instancia la clase random para generar RGB aleatorio
            Random r = new Random();

            objReportesControllers = new ReportesControllers();

            //Recuperamos los datos
            dt = objReportesControllers.ejecutarConsulta("select p.\"Codigo_Producto\",p.\"Stock\" from venta.\"Producto\" p order by p.\"Stock\" limit 10;");

            //Se añade un titulo al gráfico
            chartProductoBajoStock.Titles.Add("Productos con bajo stock");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Añadimos un punto de la serio en el gráfico y se le pasa los valores X y Y
                chartProductoBajoStock.Series[0].Points.AddXY(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());

                //Añadimos un label de la cantidad de stock en cada columna(punto).
                chartProductoBajoStock.Series[0].Points[i].Label = dt.Rows[i][1].ToString();
<<<<<<< HEAD
                //Probando
=======
                //prueba
>>>>>>> 31582810cc3ff5a9de519c9758c1346b2243acd3
            }
            //se borro

            //Se le agrega un color random para cada columna(punto).
            for (int i = 0; i < chartProductoBajoStock.Series[0].Points.Count; i++)
            {
                chartProductoBajoStock.Series[0].Points[i].Color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }
        }
    }
}
