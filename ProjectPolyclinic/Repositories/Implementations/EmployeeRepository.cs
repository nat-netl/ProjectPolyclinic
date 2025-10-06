using ProjectPolyclinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

public class EmployeeRepository : IEmployeeRepository
{
    public void CreateEmployee(Employee employee)
    {
    }

    public void DeleteEmployee(int id)
    {
    }

    public Employee ReadEmployeeById(int id)
    {
        return Employee.CreateEntity(0, string.Empty, string.Empty, 0);
    }

    public IEnumerable<Employee> ReadEmployees()
    {
        return [];
    }

    public void UpdateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }
}
