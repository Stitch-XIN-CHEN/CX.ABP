using Domain.Entity;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Domain.IRepository
{
    public interface ITestRepository : IRepository<Test, Guid>
    {
        Task<Test> GetALLInfoAsync(Guid id);
    }
}
