using ProjectPolyclinic.Entities;
using ProjectPolyclinic.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

public class MedicineRepository : IMedicineRepository
{
    public void CreateMedicine(Medicine medicine)
    {
    }

    public void DeleteMedicine(int id)
    {
    }

    public Medicine ReadMedicineById(int id)
    {
        return Medicine.CreateEntity(0, MedicineType.None, string.Empty, string.Empty);
    }

    public IEnumerable<Medicine> ReadMedicines()
    {
        return [];
    }

    public void UpdateMedicine(Medicine medicine)
    {
        throw new NotImplementedException();
    }
}
