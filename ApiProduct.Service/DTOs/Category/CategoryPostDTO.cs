using FluentValidation;
using System.Data;

namespace ApiProduct.Service.DTOs.Category
{
    public record CategoryPostDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
