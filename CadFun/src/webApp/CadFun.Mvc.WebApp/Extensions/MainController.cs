using AutoMapper;
using CadFun.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CadFun.Mvc.WebApp.Extensions
{
    [Authorize]
    public class MainController : Controller
    {
        protected readonly IMapper _mapper;
        protected readonly INotificationService _notificationService;

        protected MainController(IMapper mapper, INotificationService notificationService)
        {
            _mapper = mapper;
            _notificationService = notificationService;
        }


        protected bool OperationValid()
        {
            return _notificationService.HasError();
        }
    }
}
