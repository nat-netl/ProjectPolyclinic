using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories;

public interface IMedicineReplenishmentRepository
{
    IEnumerable<MedicineReplenishment> ReadMedicineReplenishment(DateTime? dateForm = null, DateTime? dateTo = null,
        int? medicineId = null, int? employeeId = null);

    void CreateMedicineReplenishment(MedicineReplenishment medicineReplenishment);

    void DeleteMedicineReplenishment(int id);
}