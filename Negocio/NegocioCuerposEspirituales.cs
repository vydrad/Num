using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;
namespace Negocio
{
    public class NegocioCuerposEspirituales
    {
        private DataTable _aspecto;
        private DaoCuerposEspirituales _dao = new DaoCuerposEspirituales();

        public DataTable ObtenerCuerposEspiritualess(string str)
        {

            _aspecto = _dao.ObtenerCuerposEspirituales(str);

            return _aspecto;
        }
    }
}
