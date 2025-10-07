using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories;

public interface IHealingPacientRepository
{
    IEnumerable<HealingPacient> ReadHealingPacient (DateTime? dateForm = null, DateTime? dateTo = null, 
        int? MedicineId = null, int? EmployeeId = null, int? PacientId = null);

    void CreateHealingPacient (HealingPacient healingPacient);
}
