using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductDto:BaseDto
    {
        public string Name { get; set; }
        public string NameEN { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }

        public string Img { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
