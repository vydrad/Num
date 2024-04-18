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
    public class NegocioDesafio
    {
        private DataTable _aspecto;
        private DaoDesafio _dao = new DaoDesafio();

        public DataTable ObtenerDesafioo(int num)
        {

            _aspecto = _dao.ObtenerDesafio(num);

            return _aspecto;
        }
    }
}
