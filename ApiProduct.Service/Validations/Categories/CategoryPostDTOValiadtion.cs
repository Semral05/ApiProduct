using ApiProduct.Service.DTOs.Category;
using FluentValidation;

namespace ApiProduct.Service.Validations.Categories
{
    public class CategoryPostDTOValidation : AbstractValidator<CategoryPostDTO>
    {
        public CategoryPostDTOValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Boş dəyər girilə bilməz")
                .NotNull().WithMessage("Dəyər null ola bilməz")
                .MinimumLength(3)
                .MaximumLength(30);

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Boş dəyər girilə bilməz")
                .NotNull().WithMessage("Dəyər null ola bilməz")
                .MinimumLength(3)
                .MaximumLength(50);
        }
    }
}
