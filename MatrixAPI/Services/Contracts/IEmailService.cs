using System.Threading.Tasks;
using MatrixAPI.Models;

namespace MatrixAPI.Services.Contracts
{
    public interface IEmailService
    {
        Task<string> SendEmail(Email mail);
    }
}
