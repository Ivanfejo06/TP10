using System.Data.SqlClient;
using Dapper;
namespace TP10.Models;

public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=BDSeries; Trusted_Connection=True;";
    
    public static List<Series> Series()
    {
        List<Series> devolver = null;
        string sql = "Select * From Series";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.Query<Series>(sql).ToList();
        }
        return devolver;
    }
    public static Series InfoSerie(int idserie)
    {
        Series devolver = null;
        string sql = "Select * From Series where IdSerie = @Id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.QueryFirstOrDefault<Series>(sql, new{Id = idserie});
        }
        return devolver;
    }
    public static List<Actores> InfoActores(int idserie)
    {
        List<Actores> devolver = null;
        string sql = "Select * From Actores where IdSerie = @id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.Query<Actores>(sql, new{id = idserie}).ToList();
        }
        return devolver;
    }
    public static List<Temporadas> InfoTemporadas(int idserie)
    {
        List<Temporadas> devolver = null;
        string sql = "Select * From Temporadas where IdSerie = @id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.Query<Temporadas>(sql, new{id = idserie}).ToList();
        }
        return devolver;
    }
}