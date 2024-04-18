using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoDharma
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoDharma() { }
        public DataTable ObtenerDharma(int num)

        {
            string consulta = $"SELECT DharmaTantrica,Info FROM Dharma_Tantrica WHERE DharmaTantrica = {num}";
            return _datos.ObtenerTabla("Dharma_Tantrica", consulta);
        }
    }
}
