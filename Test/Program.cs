using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=PCMEDIA\\SQLEXPRESS;Database=dvrTimeSheet;Trusted_Connection=True;Encrypt=False;";

        using var connection = new SqlConnection(connectionString);
        try
        {
            connection.Open();
            Console.WriteLine("✅ Conexión exitosa.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error al conectar:");
            Console.WriteLine(ex.Message);
        }
    }
}

