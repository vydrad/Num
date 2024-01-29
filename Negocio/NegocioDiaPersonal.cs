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
    public class NegocioDiaPersonal
    {
        private DataTable _aspecto;
        private DaoDiaPersonal _dao = new DaoDiaPersonal();

        public DataTable ObtenerDiaPersonall(int num)
        {

            _aspecto = _dao.ObtenerDiaPersonal(num);

            return _aspecto;
        }
    }
}
