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

public class EmployeeRepository : IEmployeeRepository
{
    private readonly IConnectionString _connectionString;
    private readonly ILogger<EmployeeRepository> _logger;
    public EmployeeRepository(IConnectionString connectionString, ILogger<EmployeeRepository> logger)
    {
        _connectionString = connectionString;
        _logger = logger;
    }

    public void CreateEmployee(Employee employee)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
        JsonConvert.SerializeObject(employee));
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
            INSERT INTO Employees (FirstName, LastName, EmployeePost)
            VALUES (@FirstName, @LastName, @EmployeePost)";
            connection.Execute(queryInsert, employee);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }

    }

    public void DeleteEmployee(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var queryDelete = @"
            DELETE FROM Employees
            WHERE Id=@id";
            connection.Execute(queryDelete, new { id });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Employee ReadEmployeeById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = @"
            SELECT * FROM Employees
            WHERE Id=@id";
            var employee = connection.QueryFirst<Employee>(querySelect,
            new { id });
            _logger.LogDebug("Найденный объект: {json}",
            JsonConvert.SerializeObject(employee));
            return employee;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Employee> ReadEmployees()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Employees";
            var employees = connection.Query<Employee>(querySelect);
            _logger.LogDebug("Полученные объекты: {json}",
            JsonConvert.SerializeObject(employees));
            return employees;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }

        }

    public void UpdateEmployee(Employee employee)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}",
        JsonConvert.SerializeObject(employee));
        try
        {
            using var connection = new
            NpgsqlConnection(_connectionString.ConnectionString);
            var queryUpdate = @"
                UPDATE Employees
                SET
                FirstName=@FirstName,
                LastName=@LastName,
                EmployeePost=@EmployeePost
                WHERE Id=@Id";
            connection.Execute(queryUpdate, employee);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }
}
