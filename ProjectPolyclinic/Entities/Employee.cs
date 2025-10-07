using ProjectPolyclinic.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set;} = string.Empty;

    public EmployeePost EmployeePost { get; private set; }

    public static Employee CreateEntity(int id, string first, string last, EmployeePost EmployeePost)
    {
        return new Employee { 
            Id = id, 
            FirstName = first ?? string.Empty, 
            LastName = last ?? string.Empty, 
            EmployeePost = EmployeePost };
    }
}
