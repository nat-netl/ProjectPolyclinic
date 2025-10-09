using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolyclinic.Repositories.Implementations;

internal class ConnectionString : IConnectionString
{
    string connectionString = "Host=localhost;Port=5433;Database=Polyclinic;Username=postgres;Password=Filosof";

    string IConnectionString.ConnectionString => connectionString;
}
