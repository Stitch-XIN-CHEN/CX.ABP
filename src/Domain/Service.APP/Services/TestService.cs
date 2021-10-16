using Domain.DomainServices;
using Domain.Entity;
using Domain.IRepository;
using Service.APP.Contracts.Dtos.Test;
using Service.APP.Contracts.Inputs.Test;
using Service.APP.Contracts.IServices;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Service.APP.Services
{
    public class TestService : ApplicationService, ITestService
    {
        private readonly ITestRepository _testRepository;
        private readonly TestDomainService _testDomainService;
        public TestService(ITestRepository @testRepository, TestDomainService testDomainService)
        => (_testRepository, _testDomainService) = (@testRepository, testDomainService);
        public async Task<GetTestResultDTO> GetTestResult(GetTestResultInput input)
        {
            var domainService = await _testDomainService.GetTestAsync(input.Id); //测试领域服务
            var result = await _testRepository.GetALLInfoAsync(input.Id);
            return ObjectMapper.Map<Test, GetTestResultDTO>(result);
        }
    }
}
