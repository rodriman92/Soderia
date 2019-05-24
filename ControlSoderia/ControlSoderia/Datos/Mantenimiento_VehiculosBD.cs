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
    public class Mantenimiento_VehiculosBD
    {
        internal static void Agregar(Mantenimiento_Vehiculo man)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string insertCommand = "INSERT INTO MANTENIMIENTO_VEHICULOS(DESCRIPCIONVEHICULO, DOMINIO, FECHA, DETALLEMANTENIMIENTO, OBSERVACIONES, FECHAPROXMANTENIMIENTO) VALUES (@desc, @dom, @fec, @det, @obs, @fecprox)";
                    SqlCommand comando = new SqlCommand(insertCommand, cnn);
                    comando.Parameters.AddWithValue("@desc", man.DescripcionVehiculo);
                    comando.Parameters.AddWithValue("@dom", man.Dominio);
                    comando.Parameters.AddWithValue("@fec", man.FechaMantenimiento.ToShortDateString());
                    comando.Parameters.AddWithValue("@det", man.DetalleMantenimiento);
                    comando.Parameters.AddWithValue("@obs", man.Observaciones);
                    comando.Parameters.AddWithValue("fecprox", man.FechaProxMantenimiento.ToShortDateString());

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al intentar agregar el registro", ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static void Editar(Mantenimiento_Vehiculo obj)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string updateCommand = "UPDATE Mantenimiento_Vehiculos SET DescripcionVehiculo=@desc, Dominio=@dom, Fecha=@fec, DetalleMantenimiento=@det, Observaciones=@obs, FechaProxMantenimiento=@fecprox WHERE IdMantenimiento=@id";
                    SqlCommand comando = new SqlCommand(updateCommand, cnn);
                    comando.Parameters.AddWithValue("@desc", obj.DescripcionVehiculo);
                    comando.Parameters.AddWithValue("@dom", obj.Dominio);
                    comando.Parameters.AddWithValue("@fec", obj.FechaMantenimiento.ToShortDateString());
                    comando.Parameters.AddWithValue("@det", obj.DetalleMantenimiento);
                    comando.Parameters.AddWithValue("@obs", obj.Observaciones);
                    comando.Parameters.AddWithValue("fecprox", obj.FechaProxMantenimiento.ToShortDateString());

                    comando.Parameters.AddWithValue("@id", obj.IdMatenimiento);

                    comando.ExecuteNonQuery();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al intentar actualizar el registro", ex.Message);

                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        internal static void Borrar(int idMatenimiento)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();

                    string deleteCommand = "DELETE FROM MANTENIMIENTO_VEHICULOS WHERE IDMANTENIMIENTO=@ID";
                    SqlCommand comando = new SqlCommand(deleteCommand, cnn);
                    comando.Parameters.AddWithValue("@id", idMatenimiento);

                    comando.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al intentar eliminar el registro", ex.Message );

                }
                finally
                {
                    cnn.Close();
                }
                


            }
        }

        internal static List<Mantenimiento_Vehiculo> GetLista()
        {
            List<Mantenimiento_Vehiculo> listaMantenimiento = new List<Mantenimiento_Vehiculo>();

            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                cnn.Open();
                string strComando = "SELECT IdMantenimiento, DescripcionVehiculo, Dominio, Fecha, DetalleMantenimiento, Observaciones, FechaProxMantenimiento FROM Mantenimiento_Vehiculos ORDER BY Fecha asc ";
                SqlCommand comando = new SqlCommand(strComando, cnn);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Mantenimiento_Vehiculo obj = new Mantenimiento_Vehiculo();
                        obj.IdMatenimiento = reader.GetInt32(0);
                        obj.DescripcionVehiculo = reader[1] == DBNull.Value ? string.Empty : reader.GetString(1);
                        obj.Dominio = reader[2] == DBNull.Value ? string.Empty : reader.GetString(2);
                        obj.FechaMantenimiento = reader.GetDateTime(3);
                        obj.DetalleMantenimiento = reader[4] == DBNull.Value ? string.Empty : reader.GetString(4);
                        obj.Observaciones = reader[5] == DBNull.Value ? string.Empty : reader.GetString(5);
                        obj.FechaProxMantenimiento =reader.GetDateTime(6);




                        listaMantenimiento.Add(obj);
                    }
                }
            }
            return listaMantenimiento;
        }
    }
}
