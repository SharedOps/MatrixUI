using MatrixAPI.Models;
using MatrixAPI.Repository.Contracts;
using MatrixAPI.Repository.Models;
using MatrixAPI.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MatrixAPI.CrossCutting;

namespace MatrixAPI.Services
{
    public class NavigationService: INavigation
    {
        private readonly IDapper _idapper;

        private DBConnection Connection { get; set; } = new DBConnection();

        public NavigationService(IDapper dapper)
        {
            _idapper = dapper;
        }

        public Task<int> AddNavItem(Navigation navItem)
        {
            var parameters = new DynamicParameters();
            try
            {
                Connection.StoredProcedure = Constants.InsertNavigationSp;
                parameters.Add(Constants.ParamNavTitle, navItem.Title);
                parameters.Add(Constants.ParamNavLink, navItem.Link);
                parameters.Add(Constants.ParamNavChildLink, 1);
                parameters.Add(Constants.ParamNavCreatedDate, DateTime.Now);
                return _idapper.Execute(parameters,Connection);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Task<IList<Navigation>> GetNavigationItems()
        {
            Connection.StoredProcedure = Constants.GetNavigationItemsSp;
            var parameters = new DynamicParameters();
            return _idapper.QueryList<Navigation>(parameters, Connection);
        }

        public Task<int> UpdateNavItem(Navigation navItem)
        {
            throw new NotImplementedException();
        }
    }
}
