using Domain.Entity;
using Domain.IRepository;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EF.Repository
{
    public class TestRepository : EfCoreRepository<TestContext, Test, Guid>, ITestRepository
    {
        public TestRepository(IDbContextProvider<TestContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<Test> GetALLInfoAsync(Guid id)
        {
            var dbContext = await GetDbContextAsync();
            return dbContext.Test.FirstOrDefault(x => x.Id == id);
        }
    }
}
