using System;

namespace CadFun.Mvc.WebApp.Models
{
    public class NewFuncionarioViewModel
    {
        public string NomeCompleto { get;  set; }
        public string Cpf { get;  set; }
        public string Email { get;  set; }
        public bool Ativo { get;  set; }
        public DateTime Nascimento { get;  set; }
    }
}
