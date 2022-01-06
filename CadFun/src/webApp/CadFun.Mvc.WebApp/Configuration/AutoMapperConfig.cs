using AutoMapper;
using CadFun.Domain.Models;
using CadFun.Mvc.WebApp.Models;

namespace CadFun.Mvc.WebApp.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<NewFuncionarioViewModel, Funcionario>().ReverseMap();
        }
    }
}
