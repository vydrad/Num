using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;

namespace Negocio
{
    public class NegocioRetoMotivacion
    {
        private DataTable _moti;
        private DaoRetoAutoMotivacion _dao = new DaoRetoAutoMotivacion();

        public DataTable ObtenerRetoAutoMotivacionn(int num)
        {

            _moti = _dao.ObtenerRetoAutoMotivacion(num);

            return _moti;
        }
    }
}
