using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

public class HealingPacientRepository : IHealingPacientRepository
{
    public void CreateHealingPacient(HealingPacient healingPacient)
    {
    }

    public IEnumerable<HealingPacient> ReadHealingPacient(DateTime? dateForm = null, DateTime? dateTo = null, int? MedicineId = null, int? EmployeeId = null, int? PacientId = null)
    {
        return [];
    }
}
