using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dao
{
    public class DaoAutoImagen
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoAutoImagen() { }
        public DataTable ObtenerAutoImagen(int num)

        {
            string consulta = $"SELECT Nro_de_AutoImagen,Info  FROM AutoImagen WHERE Nro_de_AutoImagen = {num}";
            return _datos.ObtenerTabla("AutoImagen", consulta);
        }
    }
}
