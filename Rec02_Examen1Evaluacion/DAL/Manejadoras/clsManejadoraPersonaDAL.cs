using System;
using System.Data.SqlClient;
using ENT;
using DAL.Conexion;

namespace DAL.Manejadoras
{
    public class clsManejadoraPersonaDAL
    {

        clsMyConnection mConexion;
        SqlDataReader mReader;

        public clsManejadoraPersonaDAL()
        {
            mConexion = new clsMyConnection();
        }

        /// <summary>
        /// Metodo que recoge una persona de la BBDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public clsPersona getPersonaDAL(int id)
        {
            clsPersona per;
            SqlConnection conexion = new SqlConnection();
            SqlCommand mComando = new SqlCommand();

            try
            {

                //Abrimos una conexion
                conexion = mConexion.getConnection();

                //Añadimos datos al comando
                mComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                //Creamos la sentencia sql
                mComando.CommandText = "SELECT * FROM personas WHERE IDPersona = @id";
                mComando.Connection = conexion;

                //Ejecutamos el comando
                mReader = mComando.ExecuteReader();
                if (mReader.Read())
                {
                    string nombre = (string)mReader["nombre"];
                    string apellidos = (string)mReader["apellidos"];
                    DateTime fechaNac = (DateTime)mReader["fechaNac"];
                    string direccion = (string)mReader["direccion"];
                    string telefono = (string)mReader["telefono"];

                    per = new clsPersona(id, nombre, apellidos, fechaNac, direccion, telefono);
                }
                else
                {
                    per = null;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return per;
        }

    }
}
