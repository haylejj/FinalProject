using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCatogoryId(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);
        public List<ProductDetailDto> GetProductDetails();
    }
}
