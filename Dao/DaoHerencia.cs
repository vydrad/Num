using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoHerencia
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoHerencia() { }
        public DataTable ObtenerHerencia(int num)

        {
            string consulta = $"SELECT Numero_Herencia,Info FROM Herencia WHERE Numero_Herencia = {num}";
            return _datos.ObtenerTabla("Herencia", consulta);
        }
    }
}
