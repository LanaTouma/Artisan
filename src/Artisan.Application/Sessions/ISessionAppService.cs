using System.Threading.Tasks;
using Abp.Application.Services;
using Artisan.Sessions.Dto;

namespace Artisan.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
