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
    class RepartosBD
    {
        internal static void Agregar(Reparto rp)
        {
            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string insertCommand = "INSERT INTO REPARTO(NroReparto, idCliente, Mes, Sem1, Sem2, Sem3, Sem4) VALUES (@nro, @cl, @mes, @s1, @s2, @s3, @s4)";
                    SqlCommand comando = new SqlCommand(insertCommand, cnn);
                    comando.Parameters.AddWithValue("@nro", rp.NroReparto);
                    comando.Parameters.AddWithValue("@cl", rp.idCliente.IdCliente);
                    comando.Parameters.AddWithValue("@mes", rp.Mes);
                    
                    comando.Parameters.AddWithValue("@s1", rp.Sem1);
                    comando.Parameters.AddWithValue("@s2", rp.Sem2);
                    comando.Parameters.AddWithValue("@s3", rp.Sem3);
                    comando.Parameters.AddWithValue("@s4", rp.Sem4);

                    comando.ExecuteNonQuery();

                    insertCommand = "SELECT @@IDENTITY";
                    comando = new SqlCommand(insertCommand, cnn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    rp.IdReparto = id;
                    
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

        internal static void Editar(Reparto obj)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string updateCommand = "UPDATE REPARTO SET Mes=@mes, Sem1=@s1, Sem2=@s2, Sem3=@s3, Sem4=@s4 WHERE IdReparto=@id";
                    SqlCommand comando = new SqlCommand(updateCommand, cnn);
                    comando.Parameters.AddWithValue("@mes", obj.Mes);
                    
                    comando.Parameters.AddWithValue("@s1", obj.Sem1);
                    comando.Parameters.AddWithValue("@s2", obj.Sem2);
                    comando.Parameters.AddWithValue("@s3", obj.Sem3);
                    comando.Parameters.AddWithValue("@s4", obj.Sem4);
                    comando.Parameters.AddWithValue("@id", obj.IdReparto);

                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        internal static List<Reparto> GetLista()
        {
            List<Reparto> listaReparto = new List<Reparto>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT IdReparto, NroReparto, idCliente, Mes, Sem1, Sem2, Sem3, Sem4 FROM Reparto  ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())

                        
                    {
                        Reparto obj = new Reparto();
                        obj.IdReparto = reader.GetInt32(0);
                        obj.NroReparto = reader.GetInt32(1);
                        obj.idCliente = ClientesBD.GetObjeto(reader.GetInt32(2));
                        obj.Mes = reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);
                        
                        obj.Sem1 = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Sem2 = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.Sem3 = reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);
                        obj.Sem4 = reader[7] == DBNull.Value ? string.Empty : reader.GetString(7);


                        listaReparto.Add(obj);
                    }
                }
            }
            return listaReparto;
        }

        internal static void Borrar(int idReparto)
        {
            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string deleteCommand = "DELETE FROM REPARTO WHERE IdReparto=@id";
                    SqlCommand comando = new SqlCommand(deleteCommand, cnn);
                    comando.Parameters.AddWithValue("@id", idReparto);

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

        internal static List<Reparto> GetListaFilrada(string nroReparto)
        {
            List<Reparto> lista = new List<Reparto>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT * FROM Reparto WHERE NroReparto like '%'+@nro+'%' ";
                SqlCommand comando = new SqlCommand(strComando, cnn);
                comando.Parameters.AddWithValue("@nro", nroReparto);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reparto obj = new Reparto();
                        obj.IdReparto = reader.GetInt32(0);
                        obj.NroReparto = reader.GetInt32(1);
                        obj.idCliente = ClientesBD.GetObjeto(reader.GetInt32(2));
                        obj.Mes = reader[3] == DBNull.Value ? string.Empty : reader.GetString(3);

                        obj.Sem1 = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Sem2 = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.Sem3 = reader[6] == DBNull.Value ? string.Empty : reader.GetString(6);
                        obj.Sem4 = reader[7] == DBNull.Value ? string.Empty : reader.GetString(7);


                        lista.Add(obj);
                    }
                }
            }
            return lista;
        }
    }
}
