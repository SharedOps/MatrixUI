using Dapper;
using MatrixAPI.Repository.Contracts;
using MatrixAPI.Repository.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixAPI.Repository
{
    public class Dapper : IDapper
    {
        public Task<IList<T>> QueryList<T>(DynamicParameters parameterModel, DBConnection connection) where T : new()
        {
            using (SqlConnection con = new SqlConnection(connection.ConnectionString))
            {
                con.Open();
                IList<T> results = con.Query<T>(connection.StoredProcedure, parameterModel, null, true, null, CommandType.StoredProcedure).ToList();
                return Task.FromResult(results);
            }
        }


        public Task<T> QueryOne<T>(DynamicParameters parameterModel, DBConnection connection) where T : new()
        {
            using (SqlConnection con = new SqlConnection(connection.ConnectionString))
            {
                con.Open();
                return Task.FromResult(con.Query<T>(connection.StoredProcedure, parameterModel, null, true, null, CommandType.StoredProcedure).FirstOrDefault());
            }
        }


        public Task<int> Execute(DynamicParameters parameterModel, DBConnection connection) //where T : new()
        {
            using (SqlConnection con = new SqlConnection(connection.ConnectionString))
            {
                con.Open();
                return Task.FromResult(con.Query<int>(connection.StoredProcedure, parameterModel, null, true, null, CommandType.StoredProcedure).SingleOrDefault());

            }
        }
    }
}
