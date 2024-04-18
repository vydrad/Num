using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dao
{
   public class DaoInfluenciaDia
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoInfluenciaDia() { }
        public DataTable ObtenerInfluenciaDia(int num)

        {
            string consulta = $"SELECT Dia FROM InfluenciaDiaNacimiento WHERE Influencia_Dia_Nacimiento = {num}";
            return _datos.ObtenerTabla("InfluenciaDiaNacimiento", consulta);
        }
    }
}
