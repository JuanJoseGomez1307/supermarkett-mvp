using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarkett_mvp.Models
{
    internal interface IProductRepository
    {
        void Add(ProductsModel productsModel);
        void Edit(ProductsModel productsModel);
        void Delete(int id);
        IEnumerable<ProductsModel> GetAll();
        IEnumerable<ProductsModel> GetByValue(string value);
    }
}
