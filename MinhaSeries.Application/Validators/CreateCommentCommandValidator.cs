using FluentValidation;
using MinhaSeries.Application.Commands.CreateComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Validators
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(p => p.Content)
                .MinimumLength(20)
                .WithMessage("O conteúdo do comentário deve ter no mínimo 20 caracteres");
        }
    }
}
