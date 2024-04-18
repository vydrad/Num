using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;
namespace Negocio
{
    public class NegocioKarma
    {
        private DataTable _aspecto;
        private DaoKarma _dao = new DaoKarma();

        public DataTable ObtenerKarmaa(int num)
        {

            _aspecto = _dao.ObtenerKarma(num);

            return _aspecto;
        }
    }
}
