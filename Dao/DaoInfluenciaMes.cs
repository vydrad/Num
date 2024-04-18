using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dao
{
    public class DaoInfluenciaMes
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoInfluenciaMes() { }
        public DataTable ObtenerInfluenciaMes(int num)

        {
            string consulta = $"SELECT Info FROM InfluenciaMesNacimiento WHERE Influencia_Mes_Nacimiento = {num}";
            return _datos.ObtenerTabla("InfluenciaMesNacimiento", consulta);
        }
    }
}
