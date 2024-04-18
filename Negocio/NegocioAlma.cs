using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;
namespace Negocio
{
    public class NegocioAlma
    {
        private DataTable _aspecto;
        private DaoAlma _dao = new DaoAlma();

        public DataTable ObtenerAlmaa(int num)
        {

            _aspecto = _dao.ObtenerAlma(num);

            return _aspecto;
        }
    }
}
