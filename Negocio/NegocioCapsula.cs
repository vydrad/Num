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
    public class NegocioCapsula
    {
        private DataTable _aspecto;
        private DaoCapsula _dao = new DaoCapsula();

        public DataTable ObtenerCapsulaa(int num)
        {

            _aspecto = _dao.ObtenerCapsula(num);

            return _aspecto;
        }
    }
}
