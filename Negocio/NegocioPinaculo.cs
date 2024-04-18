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
    public class NegocioPinaculo
    {
        private DataTable _moti;
        private DaoPinaculo _dao = new DaoPinaculo();

        public DataTable ObtenerPinaculoo(int num)
        {

            _moti = _dao.ObtenerPinaculo(num);

            return _moti;
        }
    }
}
