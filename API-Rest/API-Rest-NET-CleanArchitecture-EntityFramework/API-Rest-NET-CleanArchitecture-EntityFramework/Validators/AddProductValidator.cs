using APIRest.Domains.DataTransferObjects;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace APIRest.Validators
{
    public class AddProductValidator : AbstractValidator<AddProductDto>
    {
        public AddProductValidator()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Se debe ingresar un nombre de producto de al menos 3 caracteres.")
                .MinimumLength(3);

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Se debe ingresar una descripción de producto de al menos 10 caracteres.")
                .MinimumLength(10);
        }
    }
}
