using CadFun.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadFun.Domain.Interfaces
{
    public interface IFuncionarioRepository : IRepositoryBase<Funcionario>
    {
        Task<IEnumerable<Funcionario>> ToList();
        
    }
}
