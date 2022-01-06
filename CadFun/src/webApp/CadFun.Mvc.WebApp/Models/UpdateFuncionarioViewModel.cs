using System;

namespace CadFun.Mvc.WebApp.Models
{
    public class UpdateFuncionarioViewModel
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
