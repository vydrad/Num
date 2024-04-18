using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dao
{
    public class DaoRetoAutoExpresion
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoRetoAutoExpresion() { }
        public DataTable ObtenerRetoAutoExpresion(int num)

        {
            string consulta;
            if (num == 0)
            {
                consulta = "SELECT RetoAutoexpresion, Info FROM Reto_Autoexpresion WHERE RetoAutoexpresion IN (1, 2, 3, 4, 5, 6, 7, 8, 9)";

            }
            else
            {
                consulta = $"SELECT RetoAutoexpresion,Info  FROM Reto_Autoexpresion WHERE RetoAutoexpresion = {num}";
            }
            
            return _datos.ObtenerTabla("Reto_Autoexpresion", consulta);
        }
    }
}
