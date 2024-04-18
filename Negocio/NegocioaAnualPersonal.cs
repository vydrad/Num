using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;

namespace Negocio
{
    public class NegocioaAnualPersonal
    {
        private DataTable _aspecto;
        private DaoAnualPersonal _dao = new DaoAnualPersonal();

        public DataTable ObtenerAnualPersonall(string str)
        {
            _aspecto = _dao.ObtenerAnualPersonal(str);
            return _aspecto;
        }
    }
}
