using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoAutoMotivacion
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoAutoMotivacion() { }
        public DataTable ObtenerAutoMotivacion(int num)

        {
            string consulta = $"SELECT Nro_de_AutoMotivacion,Info  FROM AutoMotivacion WHERE Nro_de_AutoMotivacion = {num}";
            return _datos.ObtenerTabla("AutoMotivacion", consulta);
        }
    }
}
