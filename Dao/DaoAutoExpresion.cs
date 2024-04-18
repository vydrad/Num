using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dao
{
    public class DaoAutoExpresion
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoAutoExpresion() { }
        public DataTable ObtenerAutoExpresion(int num)

        {
            string consulta = $"SELECT Nro_de_Expresion,Info  FROM AutoExpresion WHERE Nro_de_Expresion = {num}";
            return _datos.ObtenerTabla("AutoExpresion", consulta);
        }
    }
}
