using Service.APP.Contracts.Dtos.Test;
using Service.APP.Contracts.Inputs.Test;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Service.APP.Contracts.IServices
{
    public interface ITestService : IApplicationService
    {
        Task<GetTestResultDTO> GetTestResult(GetTestResultInput input);
    }
}
