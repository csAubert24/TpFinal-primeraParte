using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Articulos
{
 class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo>lista =  new List<Articulo>();
			SqlCommand comando = new SqlCommand();
			SqlConnection conexion = new SqlConnection();
			SqlDataReader lector;
			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security = true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select Codigo,Nombre,Descripcion,ImagenUrl from ARTICULOS";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();


				while (lector.Read())
				{
					Articulo aux = new Articulo();
					aux.codigo = (string)lector["Codigo"];
					aux.nombre = (string)lector["Nombre"];
					aux.descrpcion = (string)lector["Descripcion"];
					aux.Imagen = (string)lector["ImagenUrl"];


					lista.Add(aux);

				}
				conexion.Close();
				return lista;
			}
			catch (Exception ex)
			{

				throw ex ;
			}

        }

    }
}
