using System;
using System.Data.SqlClient;

namespace DAL.Conexion
{
    class clsMyConnection
    {

        //Atributos
        public string dataBase { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string host { get; set; }

        //Constructores
        public clsMyConnection()
        {
            dataBase = "WPFSample";
            user = "prueba";
            pass = "123";
            host = "localhost";

        }
        //Con parámetros por si quisiera cambiar las conexiones
        public clsMyConnection(string host, string dataBase, string user, string pass)
        {
            this.dataBase = dataBase;
            this.user = user;
            this.pass = pass;
            this.host = host;
        }


        //METODOS



        /// <summary>
        /// Método que abre una conexión con la base de datos
        /// </summary>
        /// <pre>Nada.</pre>
        /// <returns>Una conexión con la base de datso</returns>
        public SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = string.Format("server={0};database={1};uid={2};pwd={3};", host, dataBase, user, pass);
                connection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

            return connection;

        }

        /// <summary>
        /// Este metodo cierra una conexión con la Base de datos
        /// </summary>
        /// <post>The connection is closed.</post>
        /// <param name="connection">La entrada es la conexión a cerrar
        /// </param>
        public void closeConnection(ref SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
