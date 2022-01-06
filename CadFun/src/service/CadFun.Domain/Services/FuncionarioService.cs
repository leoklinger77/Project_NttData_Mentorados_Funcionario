using CadFun.Domain.Interfaces;
using CadFun.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadFun.Domain.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly INotificationService _notificationService;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository, INotificationService notificationService)
        {
            _funcionarioRepository = funcionarioRepository;
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<Funcionario>> ToList()
        {
            return await _funcionarioRepository.ToList();
        }

        public async Task AddFuncionario(Funcionario funcionario)
        {
            //Validar a model de entrada

            //Aplicar a regra de negocio
            var cpfExist = await _funcionarioRepository.Find(x => x.Cpf.Contains(funcionario.Cpf) || x.Email.Contains(funcionario.Email));
            if (cpfExist != null)
            {
                if (cpfExist.Cpf == funcionario.Cpf)
                    _notificationService.AddErro($"Cpf: {funcionario.Cpf} já cadastrado pra outro funcionario.");

                if (cpfExist.Email == funcionario.Email)
                    _notificationService.AddErro($"Email: {funcionario.Email} já cadastrado pra outro funcionario.");

                return;
            }            

            await _funcionarioRepository.Insert(funcionario);

            await _funcionarioRepository.SaveChanges();
            await Task.CompletedTask;
        }
    }
}
