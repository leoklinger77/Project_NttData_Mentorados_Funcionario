namespace CadFun.Domain.Notifier
{
    public class Notification
    {
        public string Erro { get; private set; }

        public Notification(string erro)
        {
            Erro = erro;
        }
    }
}
