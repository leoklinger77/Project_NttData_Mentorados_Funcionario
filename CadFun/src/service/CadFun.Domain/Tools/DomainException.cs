using System;

namespace CadFun.Domain.Tools
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
