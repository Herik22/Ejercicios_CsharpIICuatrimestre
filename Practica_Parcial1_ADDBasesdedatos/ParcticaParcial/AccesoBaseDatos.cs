using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ParcticaParcial
{
    public class AccesoBaseDatos
    {

        #region Atributos

        private SqlConnection conexion; // atributo que permite establecer conexion con la BD
        private SqlCommand comando; // atributo que permite realizar comandos de consulta en la base
        private SqlDataReader lector; // atributo que contendra la informacion consultada. de SOLO_LECTURA

        #endregion 

        #region Constructor
        /// <summary>
        /// Constructor por defecto que inicializa la conexion.
        /// </summary>
        public AccesoBaseDatos()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(Properties.Settings.Default.PruebaBaseD); // cadena de conexion hecha por defecto.
        }

        /// <summary>
        /// constructor que recibe la cadena de conexion
        /// </summary>
        /// <param name="cadenaConexion"></param>
        public AccesoBaseDatos(string cadenaConexion)
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(cadenaConexion);
        }

        #endregion

        #region Métodos

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open(); // VERIFICO QUE  LA CONEXION ESTE ABIERTA 
            }
            catch (Exception)
            {
                rta = false; // si algo falla retornara false 
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close(); // siempre y cuando la conexion este abierta se cerrara.
                }
            }

            return rta;
        }

       /* public List<Dato> ObtenerListaDato()
        {
            List<Dato> lista = new List<Dato>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM tabla_uno";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Dato item = new Dato();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.id = (int)lector["id"];
                    item.cadena = lector[1].ToString();
                    item.entero = lector.GetInt32(2);
                    item.flotante = float.Parse(lector[3].ToString());

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }*/

        public bool AgregarDato(Perro param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand(); // instancio la clase comando para poder generar uno de adicion. 

                this.comando.Parameters.AddWithValue("@nombre", param.Nombre); // por conviccion el mismo nombre de la columna.
                this.comando.Parameters.AddWithValue("@raza", param.Raza);
                this.comando.Parameters.AddWithValue("@edad", param.edad);

                string sql = "INSERT INTO  Test_tabla_PERROS (nombre, raza, edad ) "; //comando para agregar y los campos
                sql += "VALUES (@nombre,@raza,@edad)"; //sql += "SET nombre = @nombre, raza = @raza, edad = @edad "; // seteo los valores.

                // Genero el comando, con su tipo de comando, el comando, y un objeto de tipo conextion. 
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                // abro la conexion
                this.conexion.Open();

                //verifico las filas que fueron afectadas
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        /*
        public bool ModificarDato(Dato param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.id);
                this.comando.Parameters.AddWithValue("@cadena", param.cadena);
                this.comando.Parameters.AddWithValue("@entero", param.entero);
                this.comando.Parameters.AddWithValue("@flotante", param.flotante);

                string sql = "UPDATE tabla_uno ";
                sql += "SET cadena = @cadena, entero = @entero, flotante = @flotante ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM tabla_uno ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }*/
        #endregion

    }
}
