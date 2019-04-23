using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatrixAPI.Models;

namespace MatrixAPI.Services.Contracts
{
    public interface ILocation
    {
        Task<int> AddNavItem(Location location);

        Task<int> UpdateNavItem(Location location);

        Task<IList<Location>> GetNavigationItems();
    }
}
