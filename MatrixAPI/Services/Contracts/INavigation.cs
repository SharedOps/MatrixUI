using MatrixAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatrixAPI.Services.Contracts
{
    public interface INavigation
    {
        Task<int> AddNavItem(Navigation navItem);

        Task<int> UpdateNavItem(Navigation navItem);

        Task<IList<Navigation>> GetNavigationItems();

    }
}
