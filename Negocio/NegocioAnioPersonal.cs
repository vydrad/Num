using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;
using Entidades;
namespace Negocio
{
    public class NegocioAnioPersonal
    {
        private DataTable _aspecto;
        private DaoAnioPersonal _dao = new DaoAnioPersonal();

        public DataTable ObtenerAnioPersonall(int num)
        {

            _aspecto = _dao.ObtenerAnioPersonal(num);

            return _aspecto;
        }
    }
}
