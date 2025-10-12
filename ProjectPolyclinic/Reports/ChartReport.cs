using Microsoft.Extensions.Logging;
using ProjectPolyclinic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Reports;

internal class ChartReport
{
    private readonly IHealingPacientRepository _healingPacientRepository;
    private readonly ILogger<ChartReport> _logger;

    public ChartReport(IHealingPacientRepository healingPacientRepository, ILogger<ChartReport> logger)
    {
        _healingPacientRepository = healingPacientRepository ?? throw new ArgumentNullException(nameof(healingPacientRepository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public bool CreateChart(string filePath, DateTime dateTime)
    {
        try
        {
            new PdfBuilder(filePath)
            .AddHeader("Лечение пациентов")
            .AddPieChart("Выданные медикаменты", GetData(dateTime))
            .Build();
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при формировании документа");
            return false;
        }
    }

    private List<(string Caption, double Value)> GetData(DateTime dateTime)
    {
        return _healingPacientRepository
        .ReadHealingPacient()
        .Where(x => x.HealingDate.Date == dateTime.Date)
        .GroupBy(x => x.PacientId, (key, group) => new {
            Id = key,
            Count = group.Sum(x => x.Ration)
        })
        .Select(x => (x.Id.ToString(), (double)x.Count))
        .ToList();
    }
}
