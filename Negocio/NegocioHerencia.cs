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
    public class NegocioHerencia
    {
        private DataTable _autoexpresion;
        private DaoHerencia _dao = new DaoHerencia();

        public DataTable ObtenerHerenciaa(int num)
        {

            _autoexpresion = _dao.ObtenerHerencia(num);

            return _autoexpresion;
        }
    }
}
