using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories;

public interface IMedicineRepository
{
    IEnumerable<Medicine> ReadMedicines();

    Medicine ReadMedicineById(int id);

    void CreateMedicine(Medicine medicine);

    void UpdateMedicine(Medicine medicine);

    void DeleteMedicine(int id);
}
