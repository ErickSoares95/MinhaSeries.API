using FluentValidation;
using MinhaSeries.Application.Commands.UpdateSerie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Validators
{
    public class UpdateSerieCommandValidator : AbstractValidator<UpdateSerieCommand>
    {
        public UpdateSerieCommandValidator()
        {
            RuleFor(p => p.Title)
               .MaximumLength(30)
               .WithMessage("O Titulo deve ter no máximo 30 caracteres");

            RuleFor(p => p.Description)
                .MaximumLength(255)
                .WithMessage("A Descrição deve ter no máximo 255 Caracteres");
        }
    }
}
