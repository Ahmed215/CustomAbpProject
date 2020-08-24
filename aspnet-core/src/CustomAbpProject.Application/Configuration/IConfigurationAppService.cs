using System.Threading.Tasks;
using CustomAbpProject.Configuration.Dto;

namespace CustomAbpProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
