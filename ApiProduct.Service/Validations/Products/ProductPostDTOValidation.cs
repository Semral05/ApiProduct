using ApiProduct.Service.DTOs.Product;
using FluentValidation;
using ApiProduct.Service.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Service.Validations.Products
{
    public class ProductPostDTOValidation : AbstractValidator<ProductPostDTO>
    {
        public ProductPostDTOValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);
            RuleFor(x => x.Price)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x).Custom((x, context) =>
            {
                if (!x.File.IsImage())
                {
                    context.AddFailure("File", "The File is not an image");
                }
                if (!x.File.IsSizeOK(2))
                {
                    context.AddFailure("File", "The File size must be 2 mbs");
                }
            });
        }
    }
}
