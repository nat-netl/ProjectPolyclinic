using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Entities;

public class MedicineReplenishment
{
    public int Id { get; private set; }

    public int EmployeeId { get; private set; }

    public DateTime DateReceipt { get; private set; }

    public IEnumerable<MedicineMedicineReplenishment> MedicineMedicineReplenishment { get; private set; } = [];

    public static MedicineReplenishment CreateOperation(int id, int employeeId, IEnumerable<MedicineMedicineReplenishment> medicineMedicineReplenishment)
    {
        return new MedicineReplenishment
        {
            Id = id,
            EmployeeId = employeeId,
            DateReceipt = DateTime.Now,
            MedicineMedicineReplenishment = medicineMedicineReplenishment
        };
    }

    public static MedicineReplenishment CreateOperation(TempMedicineMedicineReplenishment tempMedicineMedicineReplenishment, 
        IEnumerable<MedicineMedicineReplenishment> medicineMedicineReplenishment)
    {
        return new MedicineReplenishment
        {
            Id = tempMedicineMedicineReplenishment.Id,
            EmployeeId = tempMedicineMedicineReplenishment.EmployeeId,
            DateReceipt = tempMedicineMedicineReplenishment.DateReceipt,
            MedicineMedicineReplenishment = medicineMedicineReplenishment
        };
    }
}
