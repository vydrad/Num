using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoDestino
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoDestino() { }
        public DataTable ObtenerDestino(int num)

        {
            string num2 = Convert.ToString(num);
            string consulta = $"SELECT Info FROM Destino WHERE Destino = {num2}";
            return _datos.ObtenerTabla("Destino", consulta);
        }
    }
}
