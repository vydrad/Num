using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoVidasPasadas
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoVidasPasadas() { }
        public DataTable ObtenerVidasPasadas(int num)

        {
            string consulta = $"SELECT VidasPasadasTantrica,Info FROM VidasPasadas_Tantrica WHERE VidasPasadasTantrica = {num}";
            return _datos.ObtenerTabla("VidasPasadas_Tantrica", consulta);
        }
    }
}
