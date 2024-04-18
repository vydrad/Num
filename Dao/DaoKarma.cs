using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoKarma
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoKarma() { }
        public DataTable ObtenerKarma(int num)

        {
            string consulta = $"SELECT KarmaTantrica,Info FROM Karma_Tantrica WHERE KarmaTantrica = {num}";
            return _datos.ObtenerTabla("Karma_Tantrica", consulta);
        }
    }
}
