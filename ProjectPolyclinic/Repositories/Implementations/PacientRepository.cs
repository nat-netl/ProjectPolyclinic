using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

public class PacientRepository : IPacientRepository
{
    public void CreatePacient(Pacient pacient)
    {
    }

    public void DeletePacient(int id)
    {
    }

    public Pacient ReadPacientById(int id)
    {
        return Pacient.CreateEntity(0, string.Empty, string.Empty, 0);
    }

    public IEnumerable<Pacient> ReadPacients()
    {
        return [];
    }

    public void UpdatePacient(Pacient pacient)
    {
        throw new NotImplementedException();
    }
}
