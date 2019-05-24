using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlSoderia.BL;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ControlSoderia.Datos
{
    class ProductosBD
    {
        internal static void Agregar(Producto p1)
        {
            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string InsertCommand = "INSERT INTO PRODUCTO(DescripcionProducto, Precio, Estado) VALUES (@desc, @pre, @est)";
                    SqlCommand comando = new SqlCommand(InsertCommand, cnn);
                    comando.Parameters.AddWithValue("@desc", p1.DescripcionProducto);
                    comando.Parameters.AddWithValue("@pre", p1.Precio);
                    comando.Parameters.AddWithValue("@est", p1.Estado);

                    comando.ExecuteNonQuery();

                    InsertCommand = "SELECT @@IDENTITY";
                    comando = new SqlCommand(InsertCommand, cnn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    p1.IdProducto = id;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al intentar agregar el registro", ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static Producto GetObjeto(int v)
        {
            Producto obj = null;
            try
            {
                using (SqlConnection cnn = ConexionBD.GetConexion())
                {
                    cnn.Open();
                    string strComando = "SELECT IdProducto, DescripcionProducto, Precio, Estado FROM Producto WHERE IdProducto=@id";
                    SqlCommand comando = new SqlCommand(strComando, cnn);
                    comando.Parameters.AddWithValue("@id", v);
                    using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();


                            obj = new Producto();
                            obj.IdProducto = reader.GetInt32(0);
                            obj.DescripcionProducto = reader[1] == DBNull.Value ? string.Empty : reader.GetString(1);
                            obj.Precio = reader.GetDecimal(2);

                            obj.Estado = (EstadoProducto)reader.GetInt32(3);


                        }
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static void Editar(Producto obj)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string updateCommand = "UPDATE Producto SET DescripcionProducto=@desc, Precio=@pre, Estado=@est WHERE IdProducto=@id";
                    SqlCommand comando = new SqlCommand(updateCommand, cnn);
                    comando.Parameters.AddWithValue("@desc", obj.DescripcionProducto);
                    comando.Parameters.AddWithValue("@pre", obj.Precio);
                    comando.Parameters.AddWithValue("@est", obj.Estado);
                    
                    comando.Parameters.AddWithValue("@id", obj.IdProducto);

                    comando.ExecuteNonQuery();


                }
                catch (Exception)
                {

                    MessageBox.Show("Error al editar registro", "Error");
                }
            }
        }

        internal static void Borrar(int idProducto)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string deleteCommand = "DELETE FROM PRODUCTO WHERE IdProducto=@id";
                    SqlCommand comando = new SqlCommand(deleteCommand, cnn);
                    comando.Parameters.AddWithValue("@id", idProducto);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al intentar borrar el registro", ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static List<Producto> GetLista()
        {
            List<Producto> listaProd = new List<Producto>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT IdProducto, DescripcionProducto, Precio, Estado FROM Producto ORDER BY DescripcionProducto asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto obj = new Producto();
                        obj.IdProducto = reader.GetInt32(0);
                        obj.DescripcionProducto = reader[1] == DBNull.Value ? string.Empty : reader.GetString(1);
                        obj.Precio = reader.GetDecimal(2);

                        obj.Estado = (EstadoProducto)reader.GetInt32(3);


                        listaProd.Add(obj);
                    }
                }
            }
            return listaProd;
        }

        internal static void CargarCombo(ref ComboBox cboProducto)
        {
            List<Producto> lista = ProductosBD.GetListaActivos();
            Producto prod = new Producto() { DescripcionProducto = "<Seleccione un producto>" };
            lista.Insert(0, prod);
            cboProducto.DataSource = lista;
            cboProducto.DisplayMember = "DescripcionProducto";
            cboProducto.ValueMember = "IdProducto";
        }

        private static List<Producto> GetListaActivos()
        {
            List<Producto> listaProd = new List<Producto>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT IdProducto, DescripcionProducto, Precio, Estado FROM Producto WHERE Estado=0 ORDER BY DescripcionProducto asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto obj = new Producto();
                        obj.IdProducto = reader.GetInt32(0);
                        obj.DescripcionProducto = reader[1] == DBNull.Value ? string.Empty : reader.GetString(1);
                        obj.Precio = reader.GetDecimal(2);

                        obj.Estado = (EstadoProducto)reader.GetInt32(3);


                        listaProd.Add(obj);
                    }
                }
            }
            return listaProd;
        }

        internal static List<Producto> GetListaFilrada(string datosProd)
        {
            List<Producto> listaProd = new List<Producto>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT IdProducto, DescripcionProducto, Precio, Estado FROM Producto WHERE DescripcionProducto like '%'+@desc+'%' ORDER BY DescripcionProducto asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                comando.Parameters.AddWithValue("@desc", datosProd);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto obj = new Producto();
                        obj.IdProducto = reader.GetInt32(0);
                        obj.DescripcionProducto = reader[1] == DBNull.Value ? string.Empty : reader.GetString(1);
                        obj.Precio = reader.GetDecimal(2);

                        obj.Estado = (EstadoProducto)reader.GetInt32(3);


                        listaProd.Add(obj);
                    }
                }
            }
            return listaProd;
        }
    }
}
