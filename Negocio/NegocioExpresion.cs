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
    public class NegocioExpresion
    {
        private DataTable _autoexpresion;
        private DaoAutoExpresion _dao = new DaoAutoExpresion();

        public DataTable ObtenerAutoExpresionn(int num)
        {

            _autoexpresion = _dao.ObtenerAutoExpresion(num);

            return _autoexpresion;
        }
    }
}
