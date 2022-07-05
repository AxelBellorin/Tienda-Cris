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
            objReportesControllers = new ReportesControllers();
            //Recuperamos los datos
            dt = objReportesControllers.ejecutarConsulta("select p.\"Codigo_Producto\",p.\"Stock\" from venta.\"Producto\" p order by p.\"Stock\" limit 10;");

            //Se eliminan todas las series del gráficos
            //chartProductoBajoStock.Series.Clear();

            //Se añade un titulo al gráfico
            chartProductoBajoStock.Titles.Add("Productos con bajo stock");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ////Añadimos una serie al gráfico
                //chartProductoBajoStock.Series.Add(dt.Rows[i][0].ToString());

                
                //Añadimos el valor de la comlumna en la posicion Y del gráfico
                chartProductoBajoStock.Series[0].Points.AddXY(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());

                //añadimos el nombre de la columna en la posicion X del gráfico
                chartProductoBajoStock.Series[0].Label = dt.Rows[i][1].ToString();

                chartProductoBajoStock.Series[0]["PointWidth"] = "0.5";
            }
        }
    }
}
