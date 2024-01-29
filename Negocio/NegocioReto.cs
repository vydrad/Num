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
    public class NegocioReto
    {
        private DataTable _moti;
        private DaoReto _dao = new DaoReto();

        public DataTable ObtenerRetoo(int num)
        {

            _moti = _dao.ObtenerReto(num);

            return _moti;
        }
    }
}
