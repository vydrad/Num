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
   public class NegocioImagen
    {
        private DataTable _imagen;
        private DaoAutoImagen _dao = new DaoAutoImagen();

        public DataTable ObtenerAutoImagenn(int num)
        {

            _imagen = _dao.ObtenerAutoImagen(num);

            return _imagen;
        }
    }
}
