using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Core.Models.BaseModel
{
    public class Product : BaseModel
    {
        public string Name {  get; set; }
        public double Price {  get; set; }
        public string Image {  get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
    }
}
