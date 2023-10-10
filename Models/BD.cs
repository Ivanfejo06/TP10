using System.Data.SqlClient;
using Dapper;
namespace TP10.Models;
public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=TP9; Trusted_Connection=True;";
    
    public static list<Series> InfoSeries()
    {
        list<Series> devolver = null;
        string sql = "Select * From Series";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.Query<Series>(sql).ToList();
        }
        return devolver;
    }
    public static Actores InfoActores(int idserie)
    {
        list<Actores> devolver = null;
        string sql = "Select * From Actores where IdSerie = @id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.Query<Actores>(sql, new{id = idserie}).ToList();
        }
        return devolver;
    }

    public static Temporadas InfoTemporadas(int idserie)
    {
        list<Temporadas> devolver = null;
        string sql = "Select * From Temporadas where IdSerie = @id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.Query<Temporadas>(sql, new{id = idserie}).ToList();
        }
        return devolver;
    }
}