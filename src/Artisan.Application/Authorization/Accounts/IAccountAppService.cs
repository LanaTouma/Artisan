using System.Threading.Tasks;
using Abp.Application.Services;
using Artisan.Authorization.Accounts.Dto;

namespace Artisan.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
