using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoMesPersonal
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoMesPersonal() { }
        public DataTable ObtenerMesPersonal(int num)

        {
            string consulta = $"SELECT Mes_Personal,Info FROM MesPersonal WHERE Mes_Personal = {num}";
            return _datos.ObtenerTabla("MesPersonal", consulta);
        }
    }
}
