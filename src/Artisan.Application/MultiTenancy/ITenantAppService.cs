using Abp.Application.Services;
using Artisan.MultiTenancy.Dto;

namespace Artisan.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

