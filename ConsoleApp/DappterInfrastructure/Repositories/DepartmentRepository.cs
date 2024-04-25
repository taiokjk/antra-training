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
    public class DepartmentRepository: IRepository<Department>
    {
        private DbConnection _dbConnection = new DbConnection();

        public int Insert(Department obj)
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.Execute("INSERT INTO Department " +
                    "VALUES(@id, @departmentname, @location)", obj);
        }

        public int DeleteById(int id)
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.Execute("DELETE FROM Department WHERE Id=@id", new { id = id });
        }

        public int Update(Department obj)
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.Execute("UPDATE Department " +
                "SET DepartmentName=@departmentName, " +
                "Location=@location WHERE Id = @id",
                obj);
        }

        public IEnumerable<Department> GetAll()
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.Query<Department>("SELECT Id, DepartmentName, Location FROM Department");
        }

        public Department GetById(int id)
        {
            IDbConnection conn = _dbConnection.GetConnection();

            return conn.QuerySingleOrDefault<Department>("SELECT Id, DepartmentName, Location FROM Department" +
                                                        "WHERE Id = @id", new { id = id });
        }
    }
}
