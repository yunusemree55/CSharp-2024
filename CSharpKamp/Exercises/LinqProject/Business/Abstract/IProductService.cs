using LinqProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Business.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    List<Product> GetProductByCategoryId(int categoryId);
    Product GetProductById(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);


}
