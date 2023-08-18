using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExample_erik
{
   public class DepartmentRepo : IDepartmentRepo
    {
            private readonly IDbConnection _connection;
            //Constructor
            public DepartmentRepo(IDbConnection connection)
            {
                _connection = connection;
            }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }
    }
}
