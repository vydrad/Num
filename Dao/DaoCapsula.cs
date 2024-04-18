using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoCapsula
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoCapsula() { }
        public DataTable ObtenerCapsula(int num)

        {
            string consulta = $"SELECT Capsula,Info  FROM Capsula WHERE Capsula = {num}";
            return _datos.ObtenerTabla("Capsula", consulta);
        }
    }
}
