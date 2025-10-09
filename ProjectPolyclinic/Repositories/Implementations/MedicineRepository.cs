using Dapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Npgsql;
using ProjectPolyclinic.Entities;
using ProjectPolyclinic.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

public class MedicineRepository : IMedicineRepository
{
    private readonly IConnectionString _connectionString;
    private readonly ILogger<MedicineRepository> _logger;
    public MedicineRepository(IConnectionString connectionString,
    ILogger<MedicineRepository> logger)
    {
        _connectionString = connectionString;
        _logger = logger;
    }

    public void CreateMedicine(Medicine medicine)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
        JsonConvert.SerializeObject(medicine));
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
INSERT INTO Medicines (MedicineType, Name, Description)
VALUES (@MedicineType, @Name, @Description)";
            connection.Execute(queryInsert, medicine);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeleteMedicine(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var queryDelete = @"
                DELETE FROM Medicines
                WHERE Id=@id";
            connection.Execute(queryDelete, new { id });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Medicine ReadMedicineById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
                SELECT * FROM Medicines
                WHERE Id=@id";
            var medicine = connection.QueryFirst<Medicine>(querySelect, new
            {
                id
            });
            _logger.LogDebug("Найденный объект: {json}",
            JsonConvert.SerializeObject(medicine));
            return medicine;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }

    }

    public IEnumerable<Medicine> ReadMedicines()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Medicines";
            var medicines = connection.Query<Medicine>(querySelect);
            _logger.LogDebug("Полученные объекты: {json}",
            JsonConvert.SerializeObject(medicines));
            return medicines;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }

    public void UpdateMedicine(Medicine medicine)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}",
        JsonConvert.SerializeObject(medicine));
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var queryUpdate = @"
                UPDATE Medicines
                SET
                MedicineType=@MedicineType,
                Name=@Name,
                Description=@Description
                WHERE Id=@Id";
            connection.Execute(queryUpdate, medicine);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }
}
