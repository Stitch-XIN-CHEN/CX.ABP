using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Domain.Entity
{
    [ConnectionStringName("Test")]
    public partial class TestContext : AbpDbContext<TestContext>
    {
    }
}
