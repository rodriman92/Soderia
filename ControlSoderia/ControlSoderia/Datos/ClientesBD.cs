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
    class ClientesBD
    {
       

        internal static void Agregar(Cliente cl)
        {
            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string insertCommand = "INSERT INTO CLIENTE(ApeNombre, CUIT, Direccion, Telefono, Email, Localidad, ConsumoHabitual, NroReparto) VALUES (@an, @cuit, @dir, @tel, @email, @loc, @cons, @rep)";
                    SqlCommand comando = new SqlCommand(insertCommand, cnn);
                    comando.Parameters.AddWithValue("@an", cl.ApeNombre);
                    comando.Parameters.AddWithValue("@cuit", cl.CUIT);
                    comando.Parameters.AddWithValue("@dir", cl.Direccion);
                    comando.Parameters.AddWithValue("@tel", cl.Telefono);
                    comando.Parameters.AddWithValue("@email", cl.Email);
                    comando.Parameters.AddWithValue("@loc", cl.Localidad);
                    comando.Parameters.AddWithValue("@cons", cl.ConsumoHabitual);
                    comando.Parameters.AddWithValue("@rep", cl.NroReparto);

                    comando.ExecuteNonQuery();

                    insertCommand = "SELECT @@IDENTITY";
                    comando = new SqlCommand(insertCommand, cnn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    cl.IdCliente = id;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al agregar el registro", ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static void Editar(Cliente obj)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string updateCommand = "UPDATE Cliente SET ApeNombre=@an, CUIT=@cuit, Direccion=@dir, Telefono=@tel, Email=@email, Localidad=@loc, ConsumoHabitual=@conhab, NroReparto=@nro WHERE IdCliente=@id";
                    SqlCommand comando = new SqlCommand(updateCommand, cnn);
                    comando.Parameters.AddWithValue("@an", obj.ApeNombre);
                    comando.Parameters.AddWithValue("@cuit", obj.CUIT);
                    comando.Parameters.AddWithValue("@dir", obj.Direccion);
                    comando.Parameters.AddWithValue("@tel", obj.Telefono);
                    comando.Parameters.AddWithValue("@email", obj.Email);
                    comando.Parameters.AddWithValue("@loc", obj.Localidad);
                    comando.Parameters.AddWithValue("@conhab", obj.ConsumoHabitual);
                    comando.Parameters.AddWithValue("@nro", obj.NroReparto);


                    comando.Parameters.AddWithValue("@id", obj.IdCliente);

                    comando.ExecuteNonQuery();


                }
                catch (Exception)
                {

                    MessageBox.Show("Error al editar registro", "Error");
                }
            }
        }

        internal static void Borrar(int idCliente)
        {
            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string deleteCommand = "DELETE FROM CLIENTE WHERE IdCliente=@id";
                    SqlCommand comando = new SqlCommand(deleteCommand, cnn);
                    comando.Parameters.AddWithValue("@id", idCliente);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al intentar eliminar registro", ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static Cliente GetObjeto(int v)
        {
            Cliente obj = null;
            try
            {
                using (SqlConnection cnn = ConexionBD.GetConexion())
                {
                    cnn.Open();
                    string strComando = "SELECT IdCliente, ApeNombre, CUIT, Direccion, Telefono, Email, Localidad, ConsumoHabitual, NroReparto FROM Cliente WHERE IdCliente=@id";
                    SqlCommand comando = new SqlCommand(strComando, cnn);
                    comando.Parameters.AddWithValue("@id", v);
                    using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            obj = new Cliente();
                            obj.IdCliente = reader.GetInt32(0);
                            obj.ApeNombre = reader.GetString(1);
                            obj.CUIT = reader[2] == DBNull.Value ? string.Empty : reader.GetString(2);
                            obj.Direccion = reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);
                            obj.Telefono = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                            obj.Email = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                            obj.Localidad = reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);
                            obj.ConsumoHabitual = reader[7] == DBNull.Value ? string.Empty : reader.GetString(7);
                            obj.NroReparto = reader.GetInt32(8);




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

        internal static List<Cliente> GetLista()
        {
            List<Cliente> listaCl = new List<Cliente>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();


                string strComando = "SELECT IdCliente, ApeNombre, CUIT, Direccion, Telefono, Email, Localidad, ConsumoHabitual, NroReparto FROM Cliente ORDER BY IdCliente asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente obj = new Cliente();
                        obj.IdCliente = reader.GetInt32(0);
                        obj.ApeNombre = reader.GetString(1);
                        obj.CUIT = reader[2] == DBNull.Value ? string.Empty : reader.GetString(2);
                        obj.Direccion = reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);
                        obj.Telefono = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Email = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.Localidad = reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);
                        obj.ConsumoHabitual = reader[7] == DBNull.Value ? string.Empty : reader.GetString(7);
                        obj.NroReparto = reader.GetInt32(8);


                        listaCl.Add(obj);
                    }
                }
            }
            return listaCl;
        }

        internal static List<Cliente> GetListaFilrada(string datosCliente)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT  IdCliente, ApeNombre, CUIT, Direccion, Telefono, Email, Localidad, ConsumoHabitual, NroReparto FROM Cliente WHERE ApeNombre like @an+'%' ORDER BY ApeNombre asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                comando.Parameters.AddWithValue("@an", datosCliente);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente obj = new Cliente();
                        obj.IdCliente = reader.GetInt32(0);
                        obj.ApeNombre = reader.GetString(1);
                        obj.CUIT = reader[2] == DBNull.Value ? string.Empty : reader.GetString(2);
                        obj.Direccion = reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);
                        obj.Telefono = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Email = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.Localidad = reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);
                        obj.ConsumoHabitual = reader[7] == DBNull.Value ? string.Empty : reader.GetString(7);
                        obj.NroReparto = reader.GetInt32(8);




                        lista.Add(obj);
                    }
                }
            }
            return lista;
        }

        internal static List<Cliente> FiltrarClientesReparto(int nroRep)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT  IdCliente, ApeNombre, CUIT, Direccion, Telefono, Email, Localidad, ConsumoHabitual, NroReparto FROM Cliente WHERE NroReparto=@nro ORDER BY IdCliente asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                comando.Parameters.AddWithValue("@nro", nroRep);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente obj = new Cliente();
                        obj.IdCliente = reader.GetInt32(0);
                        obj.ApeNombre = reader.GetString(1);
                        obj.CUIT = reader[2] == DBNull.Value ? string.Empty : reader.GetString(2);
                        obj.Direccion = reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);
                        obj.Telefono = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Email = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.Localidad = reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);
                        obj.ConsumoHabitual = reader[7] == DBNull.Value ? string.Empty : reader.GetString(7);
                        obj.NroReparto = reader.GetInt32(8);




                        lista.Add(obj);
                    }
                }
            }
            return lista;
        }

        internal static void CargarCombo(ref ComboBox cboCliente)
        {
            List<Cliente> lista = ClientesBD.GetLista();
            Cliente c = new Cliente() { ApeNombre = "<Seleccione un cliente>" };
            lista.Insert(0, c);
            cboCliente.DataSource = lista;
            cboCliente.DisplayMember = "ApeNombre";
            cboCliente.ValueMember = "IdCliente";
        }

        internal static void CargarCombo(ref ComboBox cboCliente, int nroReparto)
        {
            List<Cliente> lista = ClientesBD.FiltrarClientesReparto(nroReparto);
            Cliente c = new Cliente() { ApeNombre = "<Seleccione un cliente>" };
            lista.Insert(0, c);
            cboCliente.DataSource = lista;
            cboCliente.DisplayMember = "ApeNombre";
            cboCliente.ValueMember = "IdCliente";
        }



        internal static void CargarComboFiltrado(ref ComboBox cboCliente, string filtro)
        {
            List<Cliente> lista = ClientesBD.FiltrarClientesCombo(filtro);
            Cliente c = new Cliente() { ApeNombre = "<Seleccione un cliente>" };
            lista.Insert(0, c);
            cboCliente.DataSource = lista;
            cboCliente.DisplayMember = "ApeNombre";
            cboCliente.ValueMember = "IdCliente";
        }

        private static List<Cliente> FiltrarClientesCombo(string filtro)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT  IdCliente, ApeNombre, CUIT, Direccion, Telefono, Email, Localidad, ConsumoHabitual, NroReparto FROM Cliente WHERE ApeNombre like @an+'%' ORDER BY IdCliente asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                comando.Parameters.AddWithValue("@an", filtro);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente obj = new Cliente();
                        obj.IdCliente = reader.GetInt32(0);
                        obj.ApeNombre = reader.GetString(1);
                        obj.CUIT = reader[2] == DBNull.Value ? string.Empty : reader.GetString(2);
                        obj.Direccion = reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);
                        obj.Telefono = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Email = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.Localidad = reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);
                        obj.ConsumoHabitual = reader[7] == DBNull.Value ? string.Empty : reader.GetString(7);
                        obj.NroReparto = reader.GetInt32(8);




                        lista.Add(obj);
                    }
                }
            }
            return lista;
        }
    }
    
}
