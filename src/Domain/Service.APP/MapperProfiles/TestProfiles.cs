using AutoMapper;
using Domain.Entity;
using Service.APP.Contracts.Dtos.Test;

namespace Service.APP.MapperProfiles
{
    /// <summary>
    /// 配置TestService所有 Dto映射
    /// </summary>
    public class TestProfiles : Profile
    {
        public TestProfiles()
        {
            CreateMap<Test, GetTestResultDTO>();
        }
    }
}
