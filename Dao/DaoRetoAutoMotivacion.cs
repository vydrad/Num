using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoRetoAutoMotivacion
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoRetoAutoMotivacion() { }
        public DataTable ObtenerRetoAutoMotivacion(int num)

        {
            string consulta;
            if (num == 0)
            {
                consulta = "SELECT RetoAutoMotivacion, Info FROM Reto_AutoMotivacion WHERE RetoAutoMotivacion IN (1, 2, 3, 4, 5, 6, 7, 8, 9)";

            }
            else
            {
                consulta = $"SELECT RetoAutoMotivacion,Info  FROM Reto_AutoMotivacion WHERE RetoAutoMotivacion = {num}";
            }
         
            return _datos.ObtenerTabla("Reto_Automotivacion", consulta);
        }
    }
}
