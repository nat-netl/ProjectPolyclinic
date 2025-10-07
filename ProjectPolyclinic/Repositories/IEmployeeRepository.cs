using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories;

public interface IEmployeeRepository
{
    IEnumerable<Employee> ReadEmployees();

    Employee ReadEmployeeById(int id);

    void CreateEmployee(Employee employee);

    void UpdateEmployee(Employee employee);

    void DeleteEmployee(int id);
}
