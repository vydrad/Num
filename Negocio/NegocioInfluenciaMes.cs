using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;

namespace Negocio
{
    public class NegocioInfluenciaMes
    {
        private DataTable _aspecto;
        private DaoInfluenciaMes _dao = new DaoInfluenciaMes();

        public DataTable ObtenerInfluenciaMess(int num)
        {

            _aspecto = _dao.ObtenerInfluenciaMes(num);

            return _aspecto;
        }
    }
}
