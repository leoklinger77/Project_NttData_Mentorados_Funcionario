using CadFun.Domain.Interfaces;
using CadFun.Domain.Notifier;
using System.Collections.Generic;
using System.Linq;

namespace CadFun.Domain.Services
{
    public class NotificationService : INotificationService
    {
        private List<Notification> _erros;

        public NotificationService()
        {
            _erros = new List<Notification>();
        }

        public void AddErro(string erro)
        {
            _erros.Add(new Notification(erro));
        }

        public IEnumerable<Notification> AllError()
        {
            return _erros;
        }

        public bool HasError()
        {
            return _erros.Any();
        }
    }
}
