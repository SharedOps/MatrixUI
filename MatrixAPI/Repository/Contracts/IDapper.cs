using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MatrixAPI.Repository.Models;

namespace MatrixAPI.Repository.Contracts
{
    public interface IDapper
    {
        Task<T> QueryOne<T>(DynamicParameters parameterModel, DBConnection connection) where T : new();

        Task<IList<T>> QueryList<T>(DynamicParameters parameterModel, DBConnection connection) where T : new();

        Task<int> Execute(DynamicParameters parameterModel, DBConnection connection);
    }
}
