using CadFun.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadFun.Domain.Interfaces
{
    public interface IFuncionarioService
    {
        Task<IEnumerable<Funcionario>> ToList();

        Task AddFuncionario(Funcionario funcionario);
    }
}
