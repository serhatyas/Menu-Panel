using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CategoryDto:BaseDto
    {
        public string Name { get; set; }
        public string NameEN { get; set; }

        public string Img { get; set; }
    }
}
