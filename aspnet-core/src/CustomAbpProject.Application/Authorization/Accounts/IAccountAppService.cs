using System.Threading.Tasks;
using Abp.Application.Services;
using CustomAbpProject.Authorization.Accounts.Dto;

namespace CustomAbpProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
