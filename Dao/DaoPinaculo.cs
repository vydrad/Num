using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoPinaculo
    {

        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoPinaculo() { }
        public DataTable ObtenerPinaculo(int num)

        {
            string consulta = $"SELECT Pinaculo,Info FROM Pinaculo WHERE Pinaculo = {num}";
            return _datos.ObtenerTabla("Pinaculo", consulta);
        }
    }
}
