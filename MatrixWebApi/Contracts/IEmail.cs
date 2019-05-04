using MatrixWebApi.Models;
using System.Threading.Tasks;

namespace MatrixWebApi.Contracts
{
    public interface IEmail
    {
        Task<string> SendEmail(Email mail);
    }
}
