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
    public class NegocioMotivacion
    {
        private DataTable _moti;
        private DaoAutoMotivacion _dao = new DaoAutoMotivacion();

        public DataTable ObtenerAutoMotivacionn(int num)
        {

            _moti = _dao.ObtenerAutoMotivacion(num);

            return _moti;
        }
    }
}
