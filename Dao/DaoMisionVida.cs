using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoMisionVida
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoMisionVida() { }
        public DataTable ObtenerMision(int num)

        {
            string consulta = $"SELECT MisionTantrica,Info FROM Mision_Tantrica WHERE MisionTantrica = {num}";
            return _datos.ObtenerTabla("Mision_Tantrica", consulta);
        }
    }
}
