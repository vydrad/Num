using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoAnioPersonal
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoAnioPersonal() { }
        public DataTable ObtenerAnioPersonal(int num)

        {
            string consulta = $"SELECT Anio_Personal,Info FROM AnioPersonal WHERE Anio_Personal = {num}";
            return _datos.ObtenerTabla("AnioPersonal", consulta);
        }

    }
}
