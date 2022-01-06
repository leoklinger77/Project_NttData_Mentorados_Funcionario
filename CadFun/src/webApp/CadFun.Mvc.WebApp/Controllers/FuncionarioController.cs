using AutoMapper;
using CadFun.Domain.Interfaces;
using CadFun.Domain.Models;
using CadFun.Mvc.WebApp.Extensions;
using CadFun.Mvc.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CadFun.Mvc.WebApp.Controllers
{
    public class FuncionarioController : MainController
    {
        private readonly IFuncionarioService _funcionarioService;
        public FuncionarioController(IFuncionarioService funcionarioService, 
                                        IMapper mapper, 
                                        INotificationService notificationService)
                                        : base(mapper, notificationService)
        {
            _funcionarioService = funcionarioService;

        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult NewFuncionario()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> NewFuncionario(NewFuncionarioViewModel viewModel)
        {
            //Validar
            if (ModelState.IsValid) return View(viewModel);

            //Submeter ao serviço

            var model = _mapper.Map<Funcionario>(viewModel);

            await _funcionarioService.AddFuncionario(model);

            //Verificar se foi operação valida
            if (OperationValid())
            {
                return View(viewModel);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
