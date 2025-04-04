using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace PryDamonteConexionBD
{
    public class ClsConexionBD
    {
        OleDbConnection Conexion = new OleDbConnection();
        OleDbCommand Comando = new OleDbCommand();
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();


        string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = .\\SQLQuery1.sql";

        class Program
        {
            static void Main()
            {
                string connectionString = "Server=localhost;Database=Producto;Trusted_Connection=True;";
                //string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = .\\SQLQuery1.sql";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("✅ Conexión exitosa a la base de datos.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error al conectar: " + ex.Message);
                    }
                }
            }
        }
    }
}
            

        // class Program
        //{

        //static void Main()

        //{
        // string connectionString = "Server=.;Database=Comercio;Trusted_Connection=True;";           

        // using (SqlConnection connection = new SqlConnection(connectionString))
        // {
        //  try
        //  {
        //     connection.Open();
        //       Console.WriteLine("✅ Conexión exitosa a la base de datos.");
        //  }
        //  catch (Exception ex)
        // {
        //  Console.WriteLine("❌ Error al conectar: " + ex.Message);
        //}
        //  }
        // }
        //}

