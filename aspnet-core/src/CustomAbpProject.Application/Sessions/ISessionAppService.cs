using System.Threading.Tasks;
using Abp.Application.Services;
using CustomAbpProject.Sessions.Dto;

namespace CustomAbpProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
