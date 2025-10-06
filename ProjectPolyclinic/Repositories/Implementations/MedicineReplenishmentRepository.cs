using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

public class MedicineReplenishmentRepository : IMedicineReplenishmentRepository
{
    public void CreateMedicineReplenishment(MedicineReplenishment medicineReplenishment)
    {
    }

    public void DeleteMedicineReplenishment(int id)
    {
    }

    public IEnumerable<MedicineReplenishment> ReadMedicineReplenishment(DateTime? dateForm = null, DateTime? dateTo = null, int? medicineId = null, int? employeeId = null)
    {
        return [];
    }
}
