using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlSoderia.BL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControlSoderia.Datos
{
    class ProveedoresBD
    {
        internal static void Agregar(Proveedor prov)
        {
            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string insertCommand = "INSERT INTO PROVEEDOR(RazonSocial, CUIT, Domicilio, Telefono, Email, Localidad) VALUES (@raz, @cuit, @dom, @tel, @email, @loc) ";
                    SqlCommand comando = new SqlCommand(insertCommand, cnn);
                    comando.Parameters.AddWithValue("@raz", prov.RazonSocial);
                    comando.Parameters.AddWithValue("@cuit", prov.CUIT);
                    comando.Parameters.AddWithValue("@dom", prov.Domicilio);
                    comando.Parameters.AddWithValue("@tel", prov.Telefono);
                    comando.Parameters.AddWithValue("@email", prov.Email);
                    comando.Parameters.AddWithValue("@loc", prov.Localidad);

                    comando.ExecuteNonQuery(); 
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al intentar agregar registro", ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static void Editar(Proveedor obj)
        {
            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string updateCommand = "UPDATE PROVEEDOR SET RAZONSOCIAL=@raz, CUIT=@cuit, DOMICILIO=@dom, TELEFONO=@tel, EMAIL=@email, LOCALIDAD=@loc WHERE IDPROVEEDOR=@id";
                    SqlCommand comando = new SqlCommand(updateCommand, cnn);
                    comando.Parameters.AddWithValue("@raz", obj.RazonSocial);
                    comando.Parameters.AddWithValue("@cuit", obj.CUIT);
                    comando.Parameters.AddWithValue("@dom", obj.Domicilio);
                    comando.Parameters.AddWithValue("@tel", obj.Telefono);
                    comando.Parameters.AddWithValue("@email", obj.Email);
                    comando.Parameters.AddWithValue("@loc", obj.Localidad);
                    comando.Parameters.AddWithValue("@id", obj.IdProveedor);


                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al editar registro", ex.Message);

                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static void Borrar(int idProveedor)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string deleteCommand = "DELETE FROM PROVEEDOR WHERE IDPROVEEDOR=@id";
                    SqlCommand comando = new SqlCommand(deleteCommand, cnn);
                    comando.Parameters.AddWithValue("@id", idProveedor);

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al intentar borrar registro", ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static List<Proveedor> GetLista()
        {
            List<Proveedor> listaProv = new List<Proveedor>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT IdProveedor, RazonSocial, CUIT, Domicilio, Telefono, Email, Localidad FROM PROVEEDOR ORDER BY RazonSocial asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Proveedor obj = new Proveedor();
                        obj.IdProveedor = reader.GetInt32(0);
                        obj.RazonSocial = reader[1] == DBNull.Value ? string.Empty : reader.GetString(1);
                        obj.CUIT = reader[2] == DBNull.Value ? string.Empty : reader.GetString(2);
                        obj.Domicilio = reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);
                        obj.Telefono = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Email = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.Localidad = reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);




                        listaProv.Add(obj);
                    }
                }
            }
            return listaProv;
        }

        internal static List<Proveedor> GetListaFilrada(string datosProveedor)
        {
            List<Proveedor> listaProv = new List<Proveedor>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT IdProveedor, RazonSocial, CUIT, Domicilio, Telefono, Email, Localidad FROM PROVEEDOR WHERE RazonSocial like '%'+@raz+'%' ORDER BY RazonSocial asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                comando.Parameters.AddWithValue("@raz", datosProveedor);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Proveedor obj = new Proveedor();
                        obj.IdProveedor = reader.GetInt32(0);
                        obj.RazonSocial = reader[1] == DBNull.Value ? string.Empty : reader.GetString(1);
                        obj.CUIT= reader[2] == DBNull.Value ? string.Empty : reader.GetString(2);
                        obj.Domicilio=reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);
                        obj.Telefono= reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Email= reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.Localidad= reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);




                        listaProv.Add(obj);
                    }
                }
            }
            return listaProv;
        }
    }
}
