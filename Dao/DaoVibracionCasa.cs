using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dao
{
    public class DaoVibracionCasa
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoVibracionCasa() { }
        public DataTable ObtenerVibracionCasaPlaneta(int num)

        {
            string consulta = $"SELECT Numero_Casa,Info,Planeta FROM VibracionCasaPlaneta WHERE Numero_Casa = {num}";
            return _datos.ObtenerTabla("VibracionCasaPlaneta", consulta);
        }
    }
}
