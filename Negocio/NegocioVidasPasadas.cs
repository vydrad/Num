using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;
namespace Negocio
{
    public class NegocioVidasPasadas
    {
        private DataTable _aspecto;
        private DaoVidasPasadas _dao = new DaoVidasPasadas();

        public DataTable ObtenerVidasPasadass(int num)
        {

            _aspecto = _dao.ObtenerVidasPasadas(num);

            return _aspecto;
        }
    }
}
