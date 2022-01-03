using CadFun.Domain.Interfaces;
using CadFun.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadFun.Domain.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }       

        public async Task<IEnumerable<Funcionario>> ToList()
        {
            return await _funcionarioRepository.ToList();
        }

        public async Task AddFuncionario(Funcionario funcionario)
        {
            //Validar

            //Aplicar a regra de negocio

            //Salvar no banco


            await _funcionarioRepository.Insert(funcionario);

            await _funcionarioRepository.SaveChanges();
            await Task.CompletedTask;
        }
    }
}
