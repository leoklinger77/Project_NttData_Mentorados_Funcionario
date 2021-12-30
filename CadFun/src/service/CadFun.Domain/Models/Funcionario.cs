using CadFun.Domain.Interfaces;
using CadFun.Domain.Tools;
using FluentValidation;
using System;

namespace CadFun.Domain.Models
{
    public class Funcionario : Entity, IAggregateRoot
    {
        public string NomeCompleto { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime Nascimento { get; private set; }

        protected Funcionario() { }

        public Funcionario(string nomeCompleto, string cpf)
        {          
            SetNomeCompleto(nomeCompleto);
            SetCpf(cpf);
            Ativar();

            //IsValid();            
        }

        public void SetNomeCompleto(string value)
        {
            //Validação
            if (!string.IsNullOrEmpty(value)) throw new DomainException("Nome completo invalido");
            NomeCompleto = value;
        }
        public void SetCpf(string value)
        {
            if (value.IsCpf()) throw new DomainException("Cpf invalido");
            Cpf = value;
        }
        public void SetEmail(string value)
        {
            //Validação
            Email = value;
        }
        public void SetNascimento(DateTime value)
        {
            //Validação
            Nascimento = value;
        }
        public void Ativar()
        {
            Ativo = true;
        }
        public void Desativar()
        {
            Ativo = false;
        }

        //public override bool IsValid()
        //{
        //    //if (!string.IsNullOrEmpty(NomeCompleto)) throw new DomainException("Nome completo invalido");            
        //    //if (Cpf.IsCpf()) throw new DomainException("Cpf invalido");

        //    var result = new FuncionarioValidator().Validate(this);
        //    return result.IsValid;
        //}

        public class FuncionarioValidator : AbstractValidator<Funcionario>
        {
            public FuncionarioValidator()
            {
                RuleFor(x => x.NomeCompleto)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("Nome completo invalido")
                    .Length(5, 256)
                    .WithMessage("O campo nome completo deve conter entre 5 e 256 caracteres");

                RuleFor(x => x.Cpf.IsCpf())
                    .Equal(true)
                    .WithMessage("");
                    

            }
        }

    }
}
