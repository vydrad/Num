using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dao
{
    public class DaoAspectoLetras
    {
        private AccesoDatos _datos = new AccesoDatos("NumTantrica");
        public DaoAspectoLetras() { }
        public DataTable ObtenerAspectodelasletras(char a)

        {
            string consulta = $"SELECT Letra,Fisico,Afectivo,Espiritual FROM Aspecto_de_las_letras WHERE Letra IN ('A', 'B', 'C', 'D', 'E', 'F','G','H'" +
                $",'I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z')";
            return _datos.ObtenerTabla("Aspectos_de_las_letras", consulta);
        }

        /*
        public int AgregarArticulo(AspectoLetras art)
        {
            SqlCommand cmd = new SqlCommand();
            ArmarParametrosAgregar(ref cmd, art);
            return _datos.EjecutarProcedimientoAlmacenado(ref cmd, "sp_AgregarArticulo");
        }

        public int ModificarArticulo(Articulo art)
        {
            SqlCommand cmd = new SqlCommand();
            ArmarParametrosModificar(ref cmd, art);
            return _datos.EjecutarProcedimientoAlmacenado(ref cmd, "sp_ModificarArticulo");
        }

        public int BorrarArticulo(int id)
        {
            return _datos.EjecutarConsulta($"DELETE FROM Articulos WHERE IDArticulo = {id}");
        }


        public DataTable ObtenerArticuloPorNombre(string nombre)
        {
            string consulta = "SELECT A.*, NombreCategoria, NombreProveedor " +
                              "FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IDCategoria = C.IDCategoria " +
                              "INNER JOIN PROVEEDORES P ON A.IDProveedor = P.IDProveedor " +
                              $"WHERE A.NombreArticulo LIKE '%{nombre}%'";

            return _datos.ObtenerTabla("Articulos", consulta);
        }
        private void ArmarParametrosAgregar(ref SqlCommand cmd, Articulo art)
        {
            cmd.Parameters.AddWithValue("@NOMBRE", art.Nombre);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", art.Categoria.Id);
            cmd.Parameters.AddWithValue("@IDPROVEEDOR", art.Proveedor.Id);
            cmd.Parameters.AddWithValue("@PRECIOVENTA", art.PrecioVenta);
            cmd.Parameters.AddWithValue("@PRECIOCOMPRA", art.PrecioCompra);
            cmd.Parameters.AddWithValue("@STOCK", art.Stock);
        }

        private void ArmarParametrosModificar(ref SqlCommand cmd, Articulo art)
        {
            cmd.Parameters.AddWithValue("@IDARTICULO", art.Id);
            cmd.Parameters.AddWithValue("@NOMBRE", art.Nombre);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", art.Categoria.Id);
            cmd.Parameters.AddWithValue("@IDPROVEEDOR", art.Proveedor.Id);
            cmd.Parameters.AddWithValue("@PRECIOVENTA", art.PrecioVenta);
            cmd.Parameters.AddWithValue("@PRECIOCOMPRA", art.PrecioCompra);
            cmd.Parameters.AddWithValue("@STOCK", art.Stock);
        }*/
    }
}
