using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class CidadeValidator : AbstractValidator<Cidade>
    {
        public CidadeValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .Length(50)
                .WithMessage("Nome pode ter no máximo 50 caractreres.");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("Por favor informe o estado.")
                .NotNull().WithMessage("Por favor informe o estado.");
        }
    }
}
