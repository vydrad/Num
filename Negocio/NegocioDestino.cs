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
    public class NegocioDestino
    {
        private DataTable _aspecto;
        private DaoDestino _dao = new DaoDestino();

        public DataTable ObtenerDestinoo(int num)
        {

            _aspecto = _dao.ObtenerDestino(num);

            return _aspecto;
        }
    }
}
