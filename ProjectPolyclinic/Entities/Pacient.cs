using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectPolyclinic.Entities;

public class Pacient
{
    public int Id { get; private set; }

    public string PacientName { get; private set; } = string.Empty;

    public string PacientDisease { get; private set; } = string.Empty;
    public int Age { get; private set; }

    public static Pacient CreateEntity(int Id, string PacientName, string PacientDisease, int Age)
    {
        return new Pacient
        {
            Id = Id,
            PacientName = PacientName,
            PacientDisease = PacientDisease,
            Age = Age
        };
    }
}
