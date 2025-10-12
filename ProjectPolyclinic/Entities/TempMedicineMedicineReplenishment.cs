using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Entities;

public class TempMedicineMedicineReplenishment
{
    public int Id { get; private set; }
    public int EmployeeId { get; private set; }
    public DateTime DateReceipt { get; private set; }
    public int MedicineId { get; private set; }
    public int Count { get; private set; }
}
