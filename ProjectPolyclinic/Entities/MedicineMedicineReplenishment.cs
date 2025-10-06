using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Entities;

public class MedicineMedicineReplenishment
{
    public int Id { get; private set; }
    
    public int MedicineId { get; private set; }

    public int Count { get; private set; }

    public static MedicineMedicineReplenishment CreateElement (int id, int medicineId, int count)
    {
        return new MedicineMedicineReplenishment
        {
            Id = id,
            MedicineId = medicineId,
            Count = count
        };
    }
}
