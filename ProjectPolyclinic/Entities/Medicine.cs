using ProjectPolyclinic.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Entities;

public class Medicine
{
    public int Id { get; private set; }

    public MedicineType MedicineType { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public static Medicine CreateEntity(int id, MedicineType medicineType, string name, string description)
    {
        return new Medicine 
        { 
            Id = id, 
            MedicineType = medicineType, 
            Name = name ?? string.Empty, 
            Description = description ?? string.Empty 
        };
    }

}
