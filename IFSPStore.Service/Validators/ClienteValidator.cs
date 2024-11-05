
using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Endereco)
                .NotEmpty().WithMessage("Por favor informe o endereço.")
                .NotNull().WithMessage("Por favor informe o endereço.");

            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("Por favor informe o bairro.")
                .NotNull().WithMessage("Por favor informe o bairro.");
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("Por favor informe a cidade.")
                .NotNull().WithMessage("Por favor informe a cidade.");

        }
    }
}