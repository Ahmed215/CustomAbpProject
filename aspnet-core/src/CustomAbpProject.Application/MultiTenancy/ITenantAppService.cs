using Abp.Application.Services;
using CustomAbpProject.MultiTenancy.Dto;

namespace CustomAbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

