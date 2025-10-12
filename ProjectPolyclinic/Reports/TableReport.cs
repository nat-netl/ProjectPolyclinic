using Microsoft.Extensions.Logging;
using ProjectPolyclinic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Reports;

internal class TableReport
{
    private readonly IMedicineReplenishmentRepository _medicineReplenishmentRepository;
    private readonly IHealingPacientRepository _healingPacientRepository;
    private readonly ILogger<TableReport> _logger;
    internal static readonly string[] item = ["Сотрудник", "Дата", "Количество пришло", "Количество ушло"];
    public TableReport(IMedicineReplenishmentRepository medicineReplenishmentRepository, IHealingPacientRepository healingPacientRepository,
    ILogger<TableReport> logger)
    {
        _medicineReplenishmentRepository = medicineReplenishmentRepository ??
        throw new
        ArgumentNullException(nameof(medicineReplenishmentRepository));
        _healingPacientRepository = healingPacientRepository ??
        throw new
        ArgumentNullException(nameof(healingPacientRepository));
        _logger = logger ??
        throw new ArgumentNullException(nameof(logger));
    }
    public bool CreateTable(string filePath, int medicineId, DateTime startDate,
    DateTime endDate)
    {
        try
        {
            new ExcelBuilder(filePath)
            .AddHeader("Сводка по движению медикаментов", 0, 4)
            .AddParagraph("за период", 0)
            .AddTable([10, 10, 15, 15], GetData(medicineId, startDate, endDate))
            .Build();
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при формировании документа");
            return false;
        }
    }

    private List<string[]> GetData(int medicineId, DateTime startDate, DateTime
    endDate)
    {
        var data = _medicineReplenishmentRepository
        .ReadMedicineReplenishment()
        .Where(x => x.DateReceipt >= startDate && x.DateReceipt <=
        endDate && x.MedicineMedicineReplenishment.Any(y => y.MedicineId == medicineId))
        .Select(x => new {
            x.EmployeeId,
            Date = x.DateReceipt,
            CountIn
        = x.MedicineMedicineReplenishment.FirstOrDefault(y => y.MedicineId == medicineId)?.Count,
            CountOut = (int?)null
        })
        .Union(
        _healingPacientRepository
        .ReadHealingPacient()
        .Where(x => x.HealingDate >= startDate &&
        x.HealingDate <= endDate && x.MedicineId == medicineId)
        .Select(x => new {
            x.EmployeeId,
            Date =
        x.HealingDate,
            CountIn = (int?)null,
            CountOut = (int?)x.Ration
        }))
        .OrderBy(x => x.Date);
        return new List<string[]>() { item }
        .Union(
        data
        .Select(x => new string[] {
        x.EmployeeId.ToString(), x.Date.ToString(), x.CountIn?.ToString() ??
        string.Empty, x.CountOut?.ToString() ?? string.Empty}))
        .Union(
        [["Всего", "", data.Sum(x => x.CountIn ?? 0).ToString(),
        data.Sum(x => x.CountOut ?? 0).ToString()]]).ToList();
    }
}
