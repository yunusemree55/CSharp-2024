using LinqProject.Business.Abstract;
using LinqProject.DataAccess.Abstract;
using LinqProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Business.Concretes;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }


    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public void Delete(int id)
    {
        _productDal.Delete(id);
    }

    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }

    public List<Product> GetProductByCategoryId(int categoryId)
    {
        return _productDal.GetProductByCategoryId(categoryId);
    }

    public Product GetProductById(int id)
    {
        return _productDal.GetProductById(id);
    }

    public void Update(Product product)
    {
        _productDal.Update(product);
    }
}
