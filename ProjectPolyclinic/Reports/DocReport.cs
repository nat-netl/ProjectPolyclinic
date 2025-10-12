using Microsoft.Extensions.Logging;
using ProjectPolyclinic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Reports;

internal class DocReport
{
    private readonly IPacientRepository _pacientRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMedicineRepository _medicineRepository;
    private readonly ILogger<DocReport> _logger;


    public DocReport(IPacientRepository pacientRepository, IEmployeeRepository
employeeRepository,
IMedicineRepository medicineRepository, ILogger<DocReport> logger)
    {
        _pacientRepository = pacientRepository ??
        throw new
        ArgumentNullException(nameof(pacientRepository));
        _employeeRepository = employeeRepository ??
        throw new ArgumentNullException(nameof(employeeRepository));
        _medicineRepository = medicineRepository ??
        throw new ArgumentNullException(nameof(medicineRepository));
        _logger = logger ??
        throw new ArgumentNullException(nameof(logger));
    }
    public bool CreateDoc(string filePath, bool includePacients, bool
    includeEmployees, bool includeMedicines)
    {
        try
        {
            var builder = new WordBuilder(filePath)
            .AddHeader("Документ со справочниками");
            if (includePacients)
            {
                builder.AddParagraph("Пациенты")
                .AddTable([2400, 2400, 1200],
                GetPacients());
            }
            if (includeEmployees)
            {
                builder.AddParagraph("Врачи")
                .AddTable([2400, 2400, 2400], GetEmployess());
            }
            if (includeMedicines)
            {
                builder.AddParagraph("Медикаменты")
                .AddTable([2400, 2400, 2400], GetMedicines());
            }
            builder.Build();
            return true;
        }
        catch (Exception ex)
        {
        _logger.LogError(ex, "Ошибка при формировании документа");
            return false;
        }
    }
    private List<string[]> GetPacients()
    {
        return [
        ["Вид медикамента", "Имя пациента", "Возраст"],
        .. _pacientRepository
        .ReadPacients()
        .Select(x => new string[] { x.PacientDisease,
        x.PacientName, x.Age.ToString() }),
        ];
            }
            private List<string[]> GetEmployess()
            {
                return [
                ["Имя", "Фамилия", "Должность"],
        .. _employeeRepository
        .ReadEmployees()
        .Select(x => new string[] { x.FirstName, x.LastName,
        x.EmployeePost.ToString() }),
        ];
            }
        private List<string[]> GetMedicines()
        {
            return [
            ["Тип медикамента", "Название", "Описание"],
        .. _medicineRepository
        .ReadMedicines()
        .Select(x => new string[] { x.MedicineType.ToString(),
        x.Name, x.Description }),
        ];
    }

}
