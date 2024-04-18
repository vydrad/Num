using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;

namespace Negocio
{
    public class NegocioDharma
    {
        private DataTable _aspecto;
        private DaoDharma _dao = new DaoDharma();

        public DataTable ObtenerDharmaa(int num)
        {

            _aspecto = _dao.ObtenerDharma(num);

            return _aspecto;
        }
    }
}
