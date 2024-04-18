using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;

namespace Negocio
{
    public class NegocioRetoImagen
    {
        private DataTable _moti;
        private DaoRetoAutoImagen _dao = new DaoRetoAutoImagen();

        public DataTable ObtenerRetoAutoImagenn(int num)
        {

            _moti = _dao.ObtenerRetoAutoImagen(num);

            return _moti;
        }
    }
}
