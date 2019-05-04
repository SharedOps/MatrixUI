using Dapper;
using MatrixRepository.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatrixRepository.Contracts
{
    public interface IDapperRepository
    {
        Task<T> QueryOne<T>(DynamicParameters parameterModel, DBConnection connection) where T : new();

        Task<IList<T>> QueryList<T>(DynamicParameters parameterModel, DBConnection connection) where T : new();

        Task<int> Execute(DynamicParameters parameterModel, DBConnection connection);
    }
}
