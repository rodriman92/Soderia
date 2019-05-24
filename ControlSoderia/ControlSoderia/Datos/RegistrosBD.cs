using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlSoderia.GUI;
using ControlSoderia.BL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControlSoderia.Datos
{
    class RegistrosBD
    {
        internal static List<Registro> GetLista()
        {
            List<Registro> listaRegistro = new List<Registro>();

            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string selectCommand = "SELECT IdRecibo, numDia, numMes, numAño, idCliente, idProducto, Cantidad, Precio, Importe, SaldoAnterior FROM Recibo ORDER BY numDia desc";
                    SqlCommand comando = new SqlCommand(selectCommand, cnn);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Registro obj = new Registro();
                            obj.IdRegistro = reader.GetInt32(0);
                            obj.numDia = reader.GetInt32(1);
                            obj.numMes = reader.GetInt32(2);
                            obj.año = reader.GetInt32(3);
                            obj.idCliente = ClientesBD.GetObjeto(reader.GetInt32(4));
                            obj.idProducto = ProductosBD.GetObjeto(reader.GetInt32(5));
                            obj.Cantidad = reader.GetInt32(6);
                            obj.Precio = reader.GetDecimal(7);
                            obj.Importe = reader.GetDecimal(8);
                            obj.SaldoAnterior = reader.GetDecimal(9);


                            listaRegistro.Add(obj);
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listaRegistro;
        }

        internal static void Borrar(int idRegistro)
        {
            using (SqlConnection cnn=ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string deleteCommand = "DELETE FROM RECIBO WHERE IdRecibo=@id";
                    SqlCommand comando = new SqlCommand(deleteCommand, cnn);
                    comando.Parameters.AddWithValue("@id", idRegistro);

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
    }
}
