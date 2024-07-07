using Entidades.Excepciones;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public static class AccesoDatos
    {
        static SqlCommand command;
        static SqlConnection connection;
        static string connectionString = "Data Source=DESKTOP-AIVC783;Initial Catalog=BD_Parcial_2;Integrated Security=True;";
        
        static AccesoDatos()
        {

        }
        static SqlConnection ObtenerConeccion()
        {
            connection = new SqlConnection(connectionString);
            return connection;
        }

        public static bool Guardar(string nombre, float costo)
        {
            bool retorno = true;
            try
            {
                using (var conexion = ObtenerConeccion())
                {
                    conexion.Open();
                    string query = "INSERT INTO Reparaciones (mensaje, alumno)" +
                    "VALUES (@mensaje, @alumno)";
                    command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@mensaje", $"Se reparó el {nombre} a un costo de {costo} berries");
                    command.Parameters.AddWithValue("@alumno", "Mauro Sosa");

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;

        }

        //Create
        public static void Insertar(Barco unBarco)
        {
            using (var conexion = ObtenerConeccion())
            {
                conexion.Open();
                string query = "INSERT INTO Barcos (Nombre, Tipo, Tripulacion)" +
                "VALUES (@nombre, @tipo, @tripulacion)";
                command = new SqlCommand(query, conexion);

                ETipoBarco tipo = unBarco is Pirata ? ETipoBarco.Pirata : ETipoBarco.Marina;

                command.Parameters.AddWithValue("@nombre", unBarco.Nombre);
                command.Parameters.AddWithValue("@tipo", tipo.ToString());
                command.Parameters.AddWithValue("@tripulacion", unBarco.Tripulacion);

                command.ExecuteNonQuery();
            }
        }

        //Read
        public static List<Barco> Seleccionar()
        {
            List<Barco> listaEntidades = new List<Barco>();

            using (var conexion = ObtenerConeccion())
            {
                conexion.Open();
                string query = "SELECT * FROM Barcos";
                command = new SqlCommand(query, conexion);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string nombre = reader.GetString("Nombre");
                    string tipo = reader.GetString("Tipo");
                    int tripulacion = reader.GetInt32("Tripulacion");

                    Barco barco = tipo == "Pirata" ? new Pirata(id, nombre, tripulacion) : barco = new Marina(id, nombre, tripulacion);

                    listaEntidades.Add(barco);
                }
            }

            return listaEntidades;
        }

        //Update
        public static void Modificar(Barco unBarco)
        {
            using (var conexion = ObtenerConeccion())
            {
                conexion.Open();
                string query = "UPDATE Barcos SET Nombre = @nombre, Tripulacion = @tripulacion " +
                    "WHERE ID = @id";
                command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@id", unBarco.Id);
                command.Parameters.AddWithValue("@nombre", unBarco.Nombre);
                command.Parameters.AddWithValue("@tripulacion", unBarco.Tripulacion);

                command.ExecuteNonQuery();
            }
        }

        //Delete
        public static void Eliminar(string nombre)
        {
            using (var conexion = ObtenerConeccion())
            {
                conexion.Open();
                string query = "DELETE FROM Barcos WHERE Nombre = @nombre";
                command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombre", nombre);

                command.ExecuteNonQuery();
            }
        }

    }
}
