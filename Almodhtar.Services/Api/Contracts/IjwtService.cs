using Almodhtar.Entities.identity;
using System.Threading.Tasks;

namespace Almodhtar.Services.Api.Contract
{
    public interface IjwtService
    {
        Task<string> GenerateTokenAsync(User User);
    }
}
