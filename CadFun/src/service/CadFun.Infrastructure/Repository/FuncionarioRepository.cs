using CadFun.Domain.Interfaces;
using CadFun.Domain.Models;
using CadFun.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadFun.Infrastructure.Repository
{
    public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(CodFunContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Funcionario>> ToList()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
