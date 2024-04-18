using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoDiaPersonal
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoDiaPersonal() { }
        public DataTable ObtenerDiaPersonal(int num)

        {
            string consulta = $"SELECT Dia_Personal,Info from DiaPersonal WHERE Dia_Personal = {num}";
            return _datos.ObtenerTabla("DiaPersonal", consulta);
        }
    }
}
