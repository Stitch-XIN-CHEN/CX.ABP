using Domain.Entity;

namespace Domain.DomainHyperemia
{
    public static class TestDomainHyperemia
    {
        /// <summary>
        /// 将所有结果聚合
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        public static string GetAggregateResult(Test test) => test.Id + test.Name + test.Times + test.Description;
    }
}
