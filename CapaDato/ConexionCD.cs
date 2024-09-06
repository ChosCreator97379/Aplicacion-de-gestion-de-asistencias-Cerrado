using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ConexionCD
    {
        public static SqlConnection sqlConnection()
        {
            //Instanciar el Generador de Cadenas de Conexion
            SqlConnectionStringBuilder generadorCadenaCnx = new SqlConnectionStringBuilder();
            //Pasar los parametros para la cadena de conexion
            generadorCadenaCnx.DataSource = "localhost"; //Servidor
            generadorCadenaCnx.InitialCatalog = "REAA_BD"; //Base de Datos
            generadorCadenaCnx.UserID = "sa"; //Usuario
            generadorCadenaCnx.Password = "1234"; //Contraseña
                                                  //Leer la cadena de conexion generada
            string cadenaCnx = generadorCadenaCnx.ConnectionString;
            //Instanciar un objeto de conexion
            SqlConnection cnx = new SqlConnection(cadenaCnx);
            //Retornar el nuevo objeto de conexion
            return cnx;
        }
    }
}
