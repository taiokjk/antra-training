using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperCore.Entities;
using DapperCore.Interfaces;
using DappterInfrastructure.Data;


namespace DappterInfrastructure.Repositories
{
    public class EmployeeRepository: IRepository<Employee>
    {
        private DbConnection _dbConnection = new DbConnection();

        public int Insert(Employee obj)
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.Execute("INSERT INTO Employee " +
                    "VALUES(@Id, @EmployeeName, @Age, @DepartmentId)", obj);
        }

        public int DeleteById(int id)
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.Execute("DELETE FROM Employee WHERE Id=@id", new { id = id });
        }

        public int Update(Employee obj)
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.Execute("UPDATE Employee " +
                "SET EmployeeName=@EmployeeName, " +
                "Age=@Age, " +
                "DepartmentId=@DepartmentId, WHERE Id = @id",
                obj);
        }

        public IEnumerable<Employee> GetAll()
        {
            IDbConnection conn = _dbConnection.GetConnection();

            var sql = "SELECT e.Id, e.EmployeeName, e.age, e.DepartmentId, d.Id, d.DepartmentName, d.Location" +
                "FROM Employee e INNER JOIN Department d ON e.DeparmentId = d.Id";

            return conn.Query<Employee, Department, Employee>(sql, (e, d) =>
            {
                e.Department = d;

                return e;
            });
        }

        public Employee GetById(int id)
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.QuerySingleOrDefault<Employee>("SELECT Id, EmployeeName, Age, DepartmentId FROM Employee" +
                                                        "WHERE Id = @id", new { id = id });
        }
    }
}
