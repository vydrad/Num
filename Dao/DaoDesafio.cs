using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dao
{
     public class DaoDesafio
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoDesafio() { }
        public DataTable ObtenerDesafio(int num)

        {
            string consulta = $"SELECT Desafio,Info  FROM Desafio WHERE Desafio = {num}";
            return _datos.ObtenerTabla("Desafio", consulta);
        }
    }
}
