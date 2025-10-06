using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Entities.Enums;

[Flags]
public enum MedicineType
{
    None = 0,
    Antibiotic = 1,
    Antihistamine = 2,
    Antiviral = 4,
    Expectorant = 8,
}
