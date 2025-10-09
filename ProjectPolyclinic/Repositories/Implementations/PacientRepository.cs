using Microsoft.Extensions.Logging;
using ProjectPolyclinic.Entities;
using Newtonsoft.Json;
using System.Data.SqlClient;
using Dapper;
using Npgsql;

namespace ProjectPolyclinic.Repositories.Implementations;

public class PacientRepository : IPacientRepository
{
    private readonly IConnectionString _connectionString;

    private readonly ILogger<PacientRepository> _logger;

    public PacientRepository (IConnectionString connetionString, ILogger<PacientRepository> logger)
    {
        _connectionString = connetionString;
        _logger = logger;
    }

    public void CreatePacient(Pacient pacient)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(pacient));

        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            connection.Open();
            var queryInsert = @"
                    INSERT INTO Pacients (PacientDisease, PacientName, Age)
                    VALUES (@PacientDisease, @PacientName, @Age)";
            connection.Execute(queryInsert, pacient);
        }
        catch (Exception ex) {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }
  
    public void DeletePacient(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryDelete = @"
                DELETE FROM Pacients
                WHERE Id=@id";
            connection.Execute(queryDelete, new { id });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Pacient ReadPacientById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
            SELECT * FROM Pacients
            WHERE ""id"" = @id";
            var pacient = connection.QueryFirst<Pacient>(querySelect, new
            {
                id
            });
            _logger.LogDebug("Найденный объект: {json}",
            JsonConvert.SerializeObject(pacient));
            return pacient;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Pacient> ReadPacients()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Pacients";
            var pacients = connection.Query<Pacient>(querySelect);
            _logger.LogDebug("Полученные объекты: {json}",
            JsonConvert.SerializeObject(pacients));
            return pacients;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }

    public void UpdatePacient(Pacient pacient)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(pacient));

        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            connection.Open();
            var queryInsert = @"UPDATE Pacients
                            SET
                            PacientDisease=@PacientDisease,
                            PacientName=@PacientName,
                            Age=@Age,
                            WHERE Id=@Id";
            connection.Execute(queryInsert, pacient);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }
}
