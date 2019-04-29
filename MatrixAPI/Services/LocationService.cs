using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MatrixAPI.CrossCutting;
using MatrixAPI.Models;
using MatrixAPI.Repository.Contracts;
using MatrixAPI.Repository.Models;
using MatrixAPI.Services.Contracts;

namespace MatrixAPI.Services
{
    public class LocationService : ILocation
    {
        private readonly IDapper _idapper;

        private DBConnection Connection { get; set; } = new DBConnection();


        public LocationService(IDapper dapper)
        {
            _idapper = dapper;
        }

        public Task<int> AddNavItem(Location location)
        {
            var parameters = new DynamicParameters();
            try
            {
                Connection.StoredProcedure = Constants.InsertNavigationSp;
                parameters.Add(Constants.ParamCity, location.City);
                parameters.Add(Constants.ParamCountry, location.Country);
                parameters.Add(Constants.ParamAddress,location.Address);
                return _idapper.Execute(parameters, Connection);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<IList<Location>> GetNavigationItems()
        {
            Connection.StoredProcedure = Constants.GetOfficeLocationsSp;
            var parameters = new DynamicParameters();
            return _idapper.QueryList<Location>(parameters, Connection);
        }

        public Task<int> UpdateNavItem(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
