using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;

namespace Negocio
{
    public class NegocioRetoExpresion
    {
        private DataTable _moti;
        private DaoRetoAutoExpresion _dao = new DaoRetoAutoExpresion();

        public DataTable ObtenerRetoAutoExpresionn(int num)
        {

            _moti = _dao.ObtenerRetoAutoExpresion(num);

            return _moti;
        }
    }
}
