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
    public class NegocioAspecto
    {
        
        private DataTable _aspecto;
        private DaoAspectoLetras _dao = new DaoAspectoLetras();
        
        public DataTable ObtenerAspectodelasletrass(char a)
        {

           _aspecto = _dao.ObtenerAspectodelasletras(a);
          
            return _aspecto;
        }
    }
}
