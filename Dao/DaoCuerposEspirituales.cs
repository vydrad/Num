using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoCuerposEspirituales
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoCuerposEspirituales() { }
        public DataTable ObtenerCuerposEspirituales(string str)

        {
          
            return _datos.ObtenerTabla("CuerposEspirituales", str);
        }
    }
}
