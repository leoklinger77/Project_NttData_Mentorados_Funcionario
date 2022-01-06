using CadFun.Domain.Notifier;
using System.Collections.Generic;

namespace CadFun.Domain.Interfaces
{
    public interface INotificationService
    {
        void AddErro(string erro);
        IEnumerable<Notification> AllError();
        bool HasError();
    }
}
