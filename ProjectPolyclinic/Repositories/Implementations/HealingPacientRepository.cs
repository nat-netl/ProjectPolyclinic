using Dapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Npgsql;
using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

public class HealingPacientRepository : IHealingPacientRepository
{
    private readonly IConnectionString _connectionString;
    private readonly ILogger<HealingPacientRepository> _logger;
    public HealingPacientRepository(IConnectionString connectionString,
    ILogger<HealingPacientRepository> logger)
    {
        _connectionString = connectionString;
        _logger = logger;
    }

    public void CreateHealingPacient(HealingPacient healingPacient)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
        JsonConvert.SerializeObject(healingPacient));
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
            INSERT INTO HealingPacients (MedicineId, EmployeeId, PacientId, HealingDate, Ration)
            VALUES (@MedicineId, @EmployeeId, @PacientId, @HealingDate, @Ration)";
            connection.Execute(queryInsert, healingPacient);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public IEnumerable<HealingPacient> ReadHealingPacient(DateTime? dateForm = null, DateTime? dateTo = null, int? MedicineId = null, int? EmployeeId = null, int? PacientId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM HealingPacients";
            var healingPacients =
            connection.Query<HealingPacient>(querySelect);
            _logger.LogDebug("Полученные объекты: {json}",
            JsonConvert.SerializeObject(healingPacients));
            return healingPacients;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }

    }
}
