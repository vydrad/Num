using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;

namespace Negocio
{
    public class NegocioInfluenciaDia
    {
        private DataTable _aspecto;
        private DaoInfluenciaDia _dao = new DaoInfluenciaDia();

        public DataTable ObtenerInfluenciaDiaa(int num)
        {

            _aspecto = _dao.ObtenerInfluenciaDia(num);

            return _aspecto;
        }
    }
}
