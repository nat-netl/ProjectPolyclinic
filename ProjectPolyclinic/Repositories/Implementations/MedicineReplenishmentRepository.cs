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

public class MedicineReplenishmentRepository : IMedicineReplenishmentRepository
{
    private readonly IConnectionString _connectionString;
    private readonly ILogger<MedicineReplenishmentRepository> _logger;
    public MedicineReplenishmentRepository(IConnectionString connectionString,
    ILogger<MedicineReplenishmentRepository> logger)
    {
        _connectionString = connectionString;
        _logger = logger;
    }

    public void CreateMedicineReplenishment(MedicineReplenishment medicineReplenishment)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
        JsonConvert.SerializeObject(medicineReplenishment));
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();
            var queryInsert = @"
                INSERT INTO MedicineReplenishments (EmployeeId, DateReceipt)
                VALUES (@EmployeeId, @DateReceipt);
                SELECT MAX(Id) FROM MedicineReplenishments";
            var medicineReplenishmentId =
            connection.QueryFirst<int>(queryInsert, medicineReplenishment, transaction);
            var querySubInsert = @"
                INSERT INTO MedicineMedicineReplenishments (MedicineReplenishmentId, MedicineId, Count)
                VALUES (@MedicineReplenishmentId,@MedicineId, @Count)";
            foreach (var elem in medicineReplenishment.MedicineMedicineReplenishment)
            {
                connection.Execute(querySubInsert, new
                {
                    medicineReplenishmentId,
                    elem.MedicineId,
                    elem.Count
                }, transaction);
            }
            transaction.Commit();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }

    }

    public void DeleteMedicineReplenishment(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var queryDelete = @"
                DELETE FROM MedicineReplenishments
                WHERE Id=@id";
            connection.Execute(queryDelete, new { id });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public IEnumerable<MedicineReplenishment> ReadMedicineReplenishment(DateTime? dateForm = null, DateTime? dateTo = null, int? medicineId = null, int? employeeId = null)
    {
        _logger.LogInformation("Получение всех объектов");

        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
                SELECT fr.*, ffr.MedicineId, ffr.Count FROM MedicineReplenishments fr
                INNER JOIN MedicineMedicineReplenishments ffr ON ffr.MedicineReplenishmentId = fr.Id";
            var medicineReplenishments =
            connection.Query<TempMedicineMedicineReplenishment>(querySelect);
            _logger.LogDebug("Полученные объекты: {json}",
            JsonConvert.SerializeObject(medicineReplenishments));
            return medicineReplenishments.GroupBy(x => x.Id, y => y,
            (key, value) => MedicineReplenishment.CreateOperation(value.First(),
            value.Select(z => MedicineMedicineReplenishment.CreateElement(0, z.MedicineId, z.Count)))).ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }

    }
}
