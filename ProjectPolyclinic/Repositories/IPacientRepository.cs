using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories;

public interface IPacientRepository
{
    IEnumerable<Pacient> ReadPacients();

    Pacient ReadPacientById (int id);

    void CreatePacient (Pacient pacient);

    void UpdatePacient(Pacient pacient);

    void DeletePacient(int id);

}
