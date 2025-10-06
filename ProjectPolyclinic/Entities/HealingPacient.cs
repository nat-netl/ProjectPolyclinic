using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Entities;

public class HealingPacient
{
    public int Id { get; private set; }

    public int MedicineId { get; private set; }

    public int EmployeeId { get; private set; }

    public int PacientId { get; private set; }

    public DateTime HealingDate { get; private set; }

    public int Ration {  get; private set; }

    public static HealingPacient CreateOperation(int id, int medicineId, int employeeId, int pacientId, int ration)
    {
        return new HealingPacient
        {
            Id = id,
            MedicineId = medicineId,
            EmployeeId = employeeId,
            PacientId = pacientId,
            HealingDate = DateTime.Now,
            Ration = ration
        };
    }
}
