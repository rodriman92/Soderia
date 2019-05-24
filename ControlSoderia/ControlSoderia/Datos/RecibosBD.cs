using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSoderia.BL;

namespace ControlSoderia.Datos
{
    class RecibosBD
    {

        internal static void Guardar(Recibo recibo, Saldo_Cliente saldo)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    SqlTransaction tran = cnn.BeginTransaction();
                    string insertCommand = "INSERT INTO RECIBO(numDia, numMes, numAño, idCliente, idProducto, Cantidad, Precio, Importe, SaldoAnterior, Entrada, Salida) VALUES (@dia, @mes, @anio, @cl, @pr, @cant, @pre, @imp, @sa, @in, @out)";
                    SqlCommand comando = new SqlCommand(insertCommand, cnn, tran);
                    comando.Parameters.AddWithValue("@dia", recibo.dia);
                    comando.Parameters.AddWithValue("@mes", recibo.mes);
                    comando.Parameters.AddWithValue("@anio", recibo.año);
                    comando.Parameters.AddWithValue("@cl", recibo.cliente.IdCliente);
                    comando.Parameters.AddWithValue("@pr", recibo.producto.IdProducto);
                    comando.Parameters.AddWithValue("@cant", recibo.Cantidad);
                    comando.Parameters.AddWithValue("@pre", recibo.PrecioU);
                    comando.Parameters.AddWithValue("@imp", recibo.Importe);
                    comando.Parameters.AddWithValue("@sa", recibo.SaldoA);
                    comando.Parameters.AddWithValue("@in", recibo.Entrada);
                    comando.Parameters.AddWithValue("@out", recibo.Salida);

                    try
                    {
                        comando.ExecuteNonQuery();

                        insertCommand = "SELECT @@IDENTITY";
                        comando = new SqlCommand(insertCommand, cnn, tran);
                        int id = (int)(decimal)comando.ExecuteScalar();
                        recibo.IdRecibo = id;

                        #region#
                        string Insert2 = "INSERT INTO Saldo_Cliente(Mes, Año, idCliente, SaldoMes) VALUES (@mes, @año, @cliente, @saldo)";
                        SqlCommand comando2 = new SqlCommand(Insert2, cnn, tran);
                        comando2.Parameters.AddWithValue("@mes", saldo.Mes);
                        comando2.Parameters.AddWithValue("@año", saldo.Año);
                        comando2.Parameters.AddWithValue("@cliente", saldo.idCliente.IdCliente);
                        comando2.Parameters.AddWithValue("@saldo", saldo.SaldoMes);

                        comando2.ExecuteNonQuery();

                        Insert2 = "SELECT @@IDENTITY";
                        comando2 = new SqlCommand(Insert2, cnn, tran);
                        int id2 = (int)(decimal)comando.ExecuteScalar();
                        saldo.IdSaldo = id2;

                        #endregion#


                        string updateComand = "UPDATE SALDO_CLIENTE SET SALDOMES=SALDOMES+-@out WHERE IdCliente=@cliente";


                        
                        SqlCommand insertCommand2 = new SqlCommand(updateComand, cnn, tran);
                        
                        insertCommand2.Parameters.AddWithValue("@cliente", recibo.cliente.IdCliente);
                        insertCommand2.Parameters.AddWithValue("@out", recibo.Salida);


                        insertCommand2.ExecuteNonQuery();
                        


                        tran.Commit();

                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }

                }
                finally
                {
                    cnn.Close();
                }
            }

        }
    }
}
