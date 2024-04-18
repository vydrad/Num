using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;
namespace Negocio
{
    public class NegocioMisionVida
    {
        private DataTable _aspecto;
        private DaoMisionVida _dao = new DaoMisionVida();

        public DataTable ObtenerMisionn(int num)
        {

            _aspecto = _dao.ObtenerMision(num);

            return _aspecto;
        }
    }
}
