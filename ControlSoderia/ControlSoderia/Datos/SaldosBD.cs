using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlSoderia.BL;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ControlSoderia.Datos
{
    class SaldosBD
    {
        internal static List<Saldo_Cliente> GetLista()
        {
            List<Saldo_Cliente> lista = new List<Saldo_Cliente>();
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string selectCommand = "SELECT IdSaldo, Mes, Año, idCliente, SaldoMes FROM Saldo_Cliente ORDER BY Mes, Año desc";
                    SqlCommand comando = new SqlCommand(selectCommand, cnn);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Saldo_Cliente obj = new Saldo_Cliente();
                            obj.IdSaldo = reader.GetInt32(0);
                            obj.Mes = reader.GetInt32(1);
                            obj.Año = reader.GetInt32(2);
                            obj.idCliente = ClientesBD.GetObjeto(reader.GetInt32(3));
                            obj.SaldoMes = reader.GetDecimal(4);
                            


                            lista.Add(obj);
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }

        internal static List<Vista_Saldo_Cliente> GetVista()
        {
            List<Vista_Saldo_Cliente> vista = new List<Vista_Saldo_Cliente>();
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();

                string selectComando = "SELECT TOP 1500[IdCliente],[ApeNombre],[Suma]FROM[ControlSoderia].[dbo].[Vista_Saldo]";
                SqlCommand comando = new SqlCommand(selectComando, cnn);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Vista_Saldo_Cliente obj = new Vista_Saldo_Cliente();
                        obj.idCliente = ClientesBD.GetObjeto(reader.GetInt32(0));
                        obj.ApeNombre = reader.GetString(1);
                        obj.Suma = reader.GetDecimal(2);



                        vista.Add(obj);
                    }
                }
                return vista;
            }
        }

        internal static void ActualizarSaldo(Recibo rec)
        {

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string updateCommand = "UPDATE Saldo_Cliente SET SaldoMes=SaldoMes+@cant WHERE IdCliente=@cl";
                    SqlCommand comando = new SqlCommand(updateCommand, cnn);
                    comando.Parameters.AddWithValue("@cant", rec.Importe);
                    comando.Parameters.AddWithValue("@cl", rec.cliente.IdCliente);
                    


                    comando.ExecuteNonQuery();


                }
                catch (Exception)
                {

                    MessageBox.Show("Error al editar registro", "Error");
                }
            }
        }

        internal static decimal GetSaldo(int idCliente)
        {
            Saldo_Cliente obj = new Saldo_Cliente();
            try
            {
                using (SqlConnection cnn = ConexionBD.GetConexion())
                {
                    cnn.Open();
                    string strComando = "SELECT IdSaldo, Mes, Año, idCliente, SaldoMes FROM Saldo_Cliente WHERE idCliente=@cl";
                    SqlCommand comando = new SqlCommand(strComando, cnn);
                    comando.Parameters.AddWithValue("@cl", idCliente);

                    using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            obj.IdSaldo = reader.GetInt32(0);
                            obj.Mes = reader.GetInt32(1);
                            obj.Año = reader.GetInt32(2);
                            obj.idCliente = ClientesBD.GetObjeto(reader.GetInt32(3));
                            obj.SaldoMes = reader.GetDecimal(4);


                            

                        }
                    }
                }
                return obj.SaldoMes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        internal static void ActualizarSaldoSuma(Cliente cliente, decimal sumatoria)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string updateCommand = "UPDATE Saldo_Cliente SET SaldoMes=SaldoMes+@cant WHERE IdCliente=@cl";
                    SqlCommand comando = new SqlCommand(updateCommand, cnn);
                    comando.Parameters.AddWithValue("@cant", sumatoria);
                    comando.Parameters.AddWithValue("@cl", cliente.IdCliente);



                    comando.ExecuteNonQuery();


                }
                catch (Exception)
                {

                    MessageBox.Show("Error al editar registro", "Error");
                }
            }
        }

        internal static void ActualizarSaldoResta(Cliente cliente, decimal diferencia)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string updateCommand = "UPDATE Saldo_Cliente SET SaldoMes=SaldoMes+@cant WHERE IdCliente=@cl";
                    SqlCommand comando = new SqlCommand(updateCommand, cnn);
                    comando.Parameters.AddWithValue("@cant", diferencia);
                    comando.Parameters.AddWithValue("@cl", cliente.IdCliente);



                    comando.ExecuteNonQuery();


                }
                catch (Exception)
                {

                    MessageBox.Show("Error al editar registro", "Error");
                }
            }
            
        }


    }
}
