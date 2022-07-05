using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Reportes
{
    class ReportesControllers
    {
        ConexionModel conex = null;
        System.Data.DataTable dt = null;

        public System.Data.DataTable ejecutarConsulta(string consulta)
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarDatosReportes(consulta);
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }
    }
}
