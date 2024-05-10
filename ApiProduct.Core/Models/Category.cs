namespace ApiProduct.Core.Models.BaseModel
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
