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
    public class NegocioMesPersonal
    {
        private DataTable _aspecto;
        private DaoMesPersonal _dao = new DaoMesPersonal();

        public DataTable ObtenerMesPersonall(int num)
        {

            _aspecto = _dao.ObtenerMesPersonal(num);

            return _aspecto;
        }
    }
}
