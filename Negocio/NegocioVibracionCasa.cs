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
    public class NegocioVibracionCasa
    {
        private DataTable _moti;
        private DaoVibracionCasa _dao = new DaoVibracionCasa();

        public DataTable ObtenerVibracionCasaPlanetaa(int num)
        {

            _moti = _dao.ObtenerVibracionCasaPlaneta(num);

            return _moti;
        }
    }
}
