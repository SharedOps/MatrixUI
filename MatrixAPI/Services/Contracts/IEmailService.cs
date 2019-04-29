using System.Threading.Tasks;
using MatrixAPI.Models;

namespace MatrixAPI.Services.Contracts
{
    public interface IEmailService
    {
        Task<int> SendEmail(Email mail);
    }
}
