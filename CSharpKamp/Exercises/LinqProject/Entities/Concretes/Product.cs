using LinqProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Entities.Concretes;

public class Product: IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

    public Product()
    {
        
    }

    public Product(int id, int categoryId, string name, string description, double unitPrice, int unitsInStock)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        Description = description;
        UnitPrice = unitPrice;
        UnitsInStock = unitsInStock;
    }
}
