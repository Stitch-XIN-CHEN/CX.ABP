using Domain.Entity;
using Domain.IRepository;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Domain.DomainServices
{
    public class TestDomainService : DomainService
    {
        readonly ITestRepository _testRepository;
        public TestDomainService(ITestRepository @testRepository) => (_testRepository) = (@testRepository);
        public async Task<Test> GetTestAsync(Guid id)
        {
            var result = await _testRepository.FindAsync(id);
            if (result == null) throw new Exception("异常");
            return result;
        }
    }
}
