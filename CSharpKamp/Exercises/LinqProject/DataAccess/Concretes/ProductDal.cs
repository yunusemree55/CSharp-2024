using LinqProject.DataAccess.Abstract;
using LinqProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.DataAccess.Concretes;

public class ProductDal : IProductDal
{

    private  List<Product> products;

    public ProductDal()
    {
        products = new List<Product>
        {
            new Product(1,1,"Monster Laptop","16 GB RAM",35000,20),
            new Product(2,2,"LG Televizyon","4K Ekran",45000,12),
            new Product(3,2,"Vestel Televizyon","8K Ekran", 65000,10),
            new Product(4,1,"Apple Notebook","8 GB RAM",40000,4),
            new Product(5,3,"Apple Watch","GPS Tracker",20500,8)
        };
    }

    public void Add(Product product)
    {
        products.Add(product);
    }

    public void Delete(int id)
    {
        products = products.Where(p => p.Id != id).ToList();
    }

    public List<Product> GetAll()
    {
        return products;
    }

    public List<Product> GetProductByCategoryId(int categoryId)
    {
        return products.Where(p => p.CategoryId == categoryId).ToList();
    }

    public Product GetProductById(int id)
    {
        return products.Where(p => p.Id == id).FirstOrDefault();
    }

    public void Update(Product product)
    {

        products.Where(p => p.Id == product.Id).Single().Id = product.Id;
        products.Where(p => p.Id == product.Id).Single().CategoryId = product.CategoryId;
        products.Where(p => p.Id == product.Id).Single().Name = product.Name;
        products.Where(p => p.Id == product.Id).Single().Description = product.Description;
        products.Where(p => p.Id == product.Id).Single().UnitPrice = product.UnitPrice;
        products.Where(p => p.Id == product.Id).Single().UnitsInStock = product.UnitsInStock;




    }
}
