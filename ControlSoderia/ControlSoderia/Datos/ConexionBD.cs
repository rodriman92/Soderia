using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSoderia.Datos
{
    class ConexionBD
    {
        public static SqlConnection CNN;
        public static SqlConnection GetConexion()
        {
            try
            {
                //string CadenaConexion=ConfigurationManager.ConnectionStrings["miConexion"].ToString();
                string CadenaConexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                CNN = new SqlConnection(CadenaConexion);
                return CNN;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //try
            //{

            //    string CadenaConexion = "Data Source= Rodrigo ;Initial Catalog=ControlSoderia; " + "Integrated Security=True;";
            //    CNN = new SqlConnection(CadenaConexion);
            //    return CNN;
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}

        }
    }
}
