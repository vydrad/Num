using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dao
{
    public class DaoRetoAutoImagen
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoRetoAutoImagen() { }
        public DataTable ObtenerRetoAutoImagen(int num)

        {
            string consulta;
            if (num == 0)
            {
                consulta = "SELECT RetoAutoImagen, Info FROM Reto_AutoImagen WHERE RetoAutoImagen IN (1, 2, 3, 4, 5, 6, 7, 8, 9)";

            }
            else
            {
                consulta = $"SELECT RetoAutoImagen,Info  FROM Reto_AutoImagen WHERE RetoAutoImagen = {num}";
            }
            
            return _datos.ObtenerTabla("Reto_Autoimagen", consulta);
        }
    }
}
