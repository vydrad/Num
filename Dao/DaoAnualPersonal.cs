using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
    public class DaoAnualPersonal
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoAnualPersonal() { }
        public DataTable ObtenerAnualPersonal(string str)

        {
            //string consulta = $"SELECT Vibracion_Anual,Info FROM VibracionAnual WHERE Vibracion_Anual = {num}";
            return _datos.ObtenerTabla("VibracionAnual", str);
        }
    }
}
