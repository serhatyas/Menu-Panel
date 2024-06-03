using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public interface IProductService:IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithProducts>>> GetProductsWitCategory();
    }
}
