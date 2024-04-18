using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dao
{
    public class DaoAlma
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoAlma() { }
        public DataTable ObtenerAlma(int num)

        {
            string consulta = $"SELECT AlmaTantrica,Info FROM Alma_Tantrica WHERE AlmaTantrica = {num}";
            return _datos.ObtenerTabla("Alma_Tantrica", consulta);
        }
    }
}
