using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> listaArticulos = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand(); //Devuelve un objeto SQLDATAREADER y dsp lo capturamos en lector.
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database= CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, Codigo as CodArticulo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, ImagenUrl as Imagen, Precio, IdMarca, IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria And M.Id = A.IdMarca";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader(); //aca ya echa la consulta, escribimos los datos obtenidos en la variable lector

                while (lector.Read())//recorre linea x linea los resultados de la lectura
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["CodArticulo"]; //lleva el nombre del alias
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                

                    if (!(lector["Imagen"] is DBNull))
                        aux.ImagenUrl = (string)lector["Imagen"];

                    
                    aux.IdMarca = new Marcas(); //se crea un objeto para poder usarlo
                    aux.IdMarca.Id = (int)lector["IdMarca"];
                    aux.IdMarca.Descripcion = (string)lector["Marca"];
                    aux.IdCategoria = new Categorias();
                    aux.IdCategoria.Id = (int)lector["IdCategoria"];
                    aux.IdCategoria.Descripcion = (string)lector["Categoria"];
                    aux.Precio = (float)(decimal)lector["Precio"];

                    listaArticulos.Add(aux);
                }

                conexion.Close();
                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, IdMarca, IdCategoria, Precio) Values (@Codigo, @Nombre, @Descripcion, @Imagen, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Imagen", nuevo.ImagenUrl);
                datos.setearParametro("@IdMarca", nuevo.IdMarca.Id);
                datos.setearParametro("@IdCategoria", nuevo.IdCategoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulos art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update ARTICULOS Set Codigo = @Codigo ,Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @Imagen, Precio = @Precio Where Id = @Id");
                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion",art.Descripcion);
                datos.setearParametro("@Imagen", art.ImagenUrl);
                datos.setearParametro("@idMarca", art.IdMarca.Id);
                datos.setearParametro("@IdCategoria", art.IdCategoria.Id);
                datos.setearParametro("@Precio", art.Precio);
                datos.setearParametro("@Id", art.Id);

                datos.ejecutarAccion();
    
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = @Id");
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulos> filtrarUp(string campo, string criterio, string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select A.Id, Codigo as CodArticulo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, ImagenUrl as Imagen, Precio, IdMarca, IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria And M.Id = A.IdMarca And ";
                if(campo == "Celulares")
                {
                    switch(criterio)
                    {
                        case "Mayor a":
                            consulta += "IdCategoria = 1 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdCategoria = 1 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdCategoria = 1 And Precio = " + filtro;
                            break;
                    }

                }
                else if(campo == "Televisores")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "IdCategoria = 2 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdCategoria = 2 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdCategoria = 2 And Precio = " + filtro;
                            break;
                    }
                }
                else if(campo == "Media")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "IdCategoria = 3 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdCategoria = 3 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdCategoria = 3 And Precio = " + filtro;
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "IdCategoria = 4 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdCategoria = 4 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdCategoria = 4 And Precio = " + filtro;
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())//recorre linea x linea los resultados de la lectura
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["CodArticulo"]; //lleva el nombre del alias
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];


                    if (!(datos.Lector["Imagen"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["Imagen"];


                    aux.IdMarca = new Marcas(); //se crea un objeto para poder usarlo
                    aux.IdMarca.Id = (int)datos.Lector["IdMarca"];
                    aux.IdMarca.Descripcion = (string)datos.Lector["Marca"];
                    aux.IdCategoria = new Categorias();
                    aux.IdCategoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.IdCategoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            };
        }

        public List<Articulos> filtrarDown(string campo, string criterio, string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select A.Id, Codigo as CodArticulo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, ImagenUrl as Imagen, Precio, IdMarca, IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria And M.Id = A.IdMarca And ";
                if (campo == "Samsung")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "IdMarca = 1 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdMarca = 1 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdMarca = 1 And Precio = " + filtro;
                            break;
                    }

                }
                else if (campo == "Apple")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "IdMarca = 2 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdMarca = 2 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdMarca = 2 And Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Sony")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "IdMarca = 3 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdMarca = 3 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdMarca = 3 And Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Huawei")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "IdMarca = 3 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdMarca = 3 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdMarca = 3 And Precio = " + filtro;
                            break;
                    }
                }
                else 
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "IdMarca = 4 And Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "IdMarca = 4 And Precio < " + filtro;
                            break;
                        default:
                            consulta += "IdMarca = 4 And Precio = " + filtro;
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())//recorre linea x linea los resultados de la lectura
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["CodArticulo"]; //lleva el nombre del alias
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];


                    if (!(datos.Lector["Imagen"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["Imagen"];


                    aux.IdMarca = new Marcas(); //se crea un objeto para poder usarlo
                    aux.IdMarca.Id = (int)datos.Lector["IdMarca"];
                    aux.IdMarca.Descripcion = (string)datos.Lector["Marca"];
                    aux.IdCategoria = new Categorias();
                    aux.IdCategoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.IdCategoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            };
        }
    }
}
    

